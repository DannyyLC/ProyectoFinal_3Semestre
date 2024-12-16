using MySql.Data.MySqlClient;
using ProyectoProgramacion.Models;
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
        // * * * * * EVENTOS * * * * *
        public event EventHandler<decimal> PriceChanged;

        // * * * * * PROPIEDADES Y ATRIBUTOS * * * * *
        public string Imagen { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int Stock { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public ProductCart ProductCartObject { get; set; }
        private MySqlConnection connection;

        //  * * * * * CONSTRUCTOR * * * * * 
        public CartProduct(string image = "", string marca = "", string modelo = "", decimal precio = 0, int cantidad = 1, int stock = 100, int userid = 0, int productid = 0, ProductCart productObject = null)
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
            this.ProductCartObject = productObject;


            this.MarcaLabel.Text = marca;
            this.ModeloLabel.Text = modelo;
            this.PrecioLabel.Text = $"Precio: ${precio:F2}";
            this.Cantidadlbl.Text = $"Cantidad: {this.Cantidad}";
            this.Stocklbl.Text = $"Stock disponible: {this.Stock}";

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

        //  * * * * * BOTONES * * * * * 
        #region Botones
        //  * * * * * AUMENTAR LA CANTIDAD DE UN PRODUCTO * * * * * 
        private void PictureMore_Click(object sender, EventArgs e)
        {
            if (this.Cantidad >= this.Stock)
            {
                MessageBox.Show("No hay más productos disponibles en stock.");
            }
            else
            {
                if (UpdateQuantityInDatabase(this.Cantidad + 1))
                {
                    this.Cantidad++;
                    this.Cantidadlbl.Text = $"Cantidad: {this.Cantidad}";
                    // Notificar el cambio en el precio
                    PriceChanged?.Invoke(this, this.Precio);
                    //Alterar la lista cartProducts
                    this.ProductCartObject.Cantidad++;
                }
            }
        }

        // * * * * *  DISMINUIR LA CANTIDAD DE UN PRODUCTO * * * * * 
        private void PictureLess_Click(object sender, EventArgs e)
        {
            if (this.Cantidad <= 1)
            {
                var result = MessageBox.Show("¿Deseas eliminar este producto del carrito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DeleteProductFromDatabase())
                    {
                        // Notificar que el precio debe reducirse a cero
                        PriceChanged?.Invoke(this, -this.Precio * this.Cantidad);
                        //Alterar la lista cartProducts
                        this.ProductCartObject.Cantidad--;
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
                if (UpdateQuantityInDatabase(this.Cantidad - 1))
                {
                    this.Cantidad--;
                    this.Cantidadlbl.Text = $"Cantidad: {this.Cantidad}";
                    // Notificar el cambio en el precio
                    PriceChanged?.Invoke(this, -this.Precio);
                }
            }
        }

        #endregion

        //  * * * * * BASE DE DATOS * * * * * 
        #region Base de Datos
        // * * * * *  ACTUALIZAR LA BASE DE DATOS * * * * * 
        private bool UpdateQuantityInDatabase(int newQuantity)
        {
            try
            {
                Connect();
                if (this.connection.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("La conexión no está abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string query = "UPDATE carrito SET cantidad = @cantidad WHERE productid = @productid AND userid = @userid";
                using (var command = new MySqlCommand(query, this.connection))
                {
                    command.Parameters.AddWithValue("@cantidad", newQuantity);
                    command.Parameters.AddWithValue("@productid", this.ProductId);
                    command.Parameters.AddWithValue("@userid", this.UserId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la cantidad en el carrito.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la cantidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // * * * * *  ELIMINAR PRODUCTO DE LA BASE DE DATOS Y DE LA VISTA DE EL USUARIO * * * * * 
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
        //  * * * * * CONXION CON LA BASE DE DATOS * * * * * 
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
        #endregion
    }
}
