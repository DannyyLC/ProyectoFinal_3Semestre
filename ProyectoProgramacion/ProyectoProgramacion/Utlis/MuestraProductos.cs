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
            // Encuentra el formulario contenedor del control
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                // Crea una instancia de CartForm
                CartForm cart = new CartForm(this.Userid)
                {
                    StartPosition = FormStartPosition.Manual, // Posicionamiento manual
                    Location = parentForm.Location,          // Posición del formulario principal
                    Size = parentForm.Bounds.Size            // Tamaño del formulario principal
                };

                // Muestra el formulario de carrito como un diálogo modal
                cart.ShowDialog();
            }
            else
            {
                // Si no se encontró el formulario contenedor, muestra un mensaje de error
                MessageBox.Show("No se pudo acceder al formulario principal desde el control de usuario.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void AgregarCarrito()
        {
            string connectionString = "Server=localhost;Database=tenisdb;User ID=root;Password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO carrito (userid, productid, precio, imagen, marca, modelo) VALUES (@userid, @productid, @precio, @imagen, @marca, @modelo)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userid", this.Userid);
                        command.Parameters.AddWithValue("@productid", this.Productid);
                        command.Parameters.AddWithValue("@precio", this.Price);
                        command.Parameters.AddWithValue("@imagen", this.Imagen);
                        command.Parameters.AddWithValue("@marca", this.Brand);
                        command.Parameters.AddWithValue("@modelo", this.Model);

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
