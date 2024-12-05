using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using ProyectoProgramacion.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion.Utlis
{
    public partial class MuestraProductos : UserControl
    {
        // PROPIEDADES
        public int Userid { get; set; }
        public int Productid { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Imagen { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // CONSTRUCTOR
        public MuestraProductos(int userid = 0, int productid = 0, string model = "", string description = "", string image = "", string brand = "", decimal price = 0, int stock = 0)
        {
            InitializeComponent();

            Userid = userid;
            Productid = productid;
            Model = model;
            Description = description;
            Imagen = image;
            Brand = brand;
            Price = price;
            Stock = stock;

            this.ProductMarca.Text = brand;
            this.ProductModel.Text = model;
            this.lblPrecio.Text = $"${price:F2}";
            this.lblStock.Text = Convert.ToString(stock);
            this.ProductDescription.Text = description;

            if (File.Exists(Imagen))
            {
                this.ProductPicture.Image = Image.FromFile(Imagen);
                this.ProductPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Error al mostrar la imagen");
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            AgregarCarrito();
        }
        private void PictureRegresar_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void PictureLeft_Click(object sender, EventArgs e)
        {

        }

        private void PictuteRight_Click(object sender, EventArgs e)
        {

        }

        private void btnComprarYa_Click(object sender, EventArgs e)
        {
            // Llamar a la función que agrega el producto al carrito
            AgregarCarrito();

            // Obtener el formulario contenedor
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                // Eliminar el control actual del formulario
                this.Parent.Controls.Remove(this);

                // Crear una nueva instancia del formulario del carrito
                CartForm cart = new CartForm(this.Userid);
                cart.StartPosition = FormStartPosition.Manual;

                // Establecer la ubicación en la esquina superior izquierda del formulario principal
                cart.Location = parentForm.Location;

                // Establecer el tamaño para que coincida con el tamaño total del formulario contenedor
                cart.Size = new Size(parentForm.Width, parentForm.Height);

                // Establecer el estilo de borde para que no tenga bordes
                cart.FormBorderStyle = FormBorderStyle.None;

                // Asegurarse de que el carrito esté al frente y visible
                cart.TopMost = true;

                // Mostrar el formulario del carrito
                cart.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo acceder al formulario contenedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AgregarCarrito()
        {
            // Crear la conexión a la base de datos
            string connectionString = "Server=localhost;Database=tenisdb;User ID=root;Password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO carrito (userid, productid, precio, imagen, marca, modelo) VALUES (@userid, @productid, @precio, @imagen, @marca, @modelo)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Asignar los valores de los parámetros
                        command.Parameters.AddWithValue("@userid", this.Userid);
                        command.Parameters.AddWithValue("@productid", this.Productid);
                        command.Parameters.AddWithValue("@precio", this.Price);
                        command.Parameters.AddWithValue("@imagen", this.Imagen);
                        command.Parameters.AddWithValue("@marca", this.Brand);
                        command.Parameters.AddWithValue("@modelo", this.Model);

                        // Ejecutar el comando
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto agregado al carrito con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el producto al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
