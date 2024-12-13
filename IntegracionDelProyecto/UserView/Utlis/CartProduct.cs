using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoProgramacion.Views
{
    public partial class CartProduct : UserControl
    {
        // ATRIBUTOS
        public string Imagen { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int Stock { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        private MySqlConnection connection;

        public CartProduct(string image = "", string marca = "", string modelo = "", decimal precio = 0, int cantidad = 1, int stock = 100, int userid = 0, int productid = 0)
        {
            InitializeComponent();
            this.Imagen = image;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Stock = stock;
            this.UserId = userid;
            this.ProductId = productid;

            this.MarcaLabel.Text = marca;
            this.ModeloLabel.Text = modelo;
            this.PrecioLabel.Text = $"${precio:F2}";
            this.Cantidadlbl.Text = $"{this.Cantidad}";
            this.Stocklbl.Text = $"{this.Stock}";

            if (File.Exists(Imagen))
            {
                this.ProductPicture.Image = System.Drawing.Image.FromFile(Imagen);
                this.ProductPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Error al mostrar la imagen");
            }
        }

        private void PictureMore_Click(object sender, EventArgs e)
        {
            if (this.Cantidad >= this.Stock)
            {
                MessageBox.Show("No hay más productos disponibles en stock.");
            }
            else
            {
                this.Cantidad++;
                this.Cantidadlbl.Text = $"{this.Cantidad}";
            }
        }

        private void PictureLess_Click(object sender, EventArgs e)
        {
            if (this.Cantidad <= 1)
            {
                var result = MessageBox.Show("¿Deseas eliminar este producto del carrito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DeleteProductFromDatabase())
                    {
                        var parent = this.Parent as TableLayoutPanel;
                        if (parent != null)
                        {
                            parent.Controls.Remove(this);
                            this.Dispose(); 
                        }
                    }
                }
            }
            else
            {
                this.Cantidad--;
                this.Cantidadlbl.Text = $"{this.Cantidad}";
            }
        }

        private bool DeleteProductFromDatabase()
        {
            try
            {
                Connect();
                if (this.connection.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("La conexión no está abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string query = "DELETE FROM carrito WHERE productid = @productid AND userid = @userid";
                using (var command = new MySqlCommand(query, this.connection))
                {
                    command.Parameters.AddWithValue("@productid", this.ProductId);
                    command.Parameters.AddWithValue("@userid", this.UserId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto eliminado del carrito correctamente.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el producto del carrito.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public void Connect()
        {
            if (this.connection == null)
            {
                string dataBase = "Server=localhost; Database=tenisdb; User=root; Password=; SslMode=none;";
                try
                {
                    this.connection = new MySqlConnection(dataBase);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al inicializar la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                if (this.connection.State != System.Data.ConnectionState.Open)
                {
                    this.connection.Open();
                    Console.WriteLine("Conexión establecida exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
