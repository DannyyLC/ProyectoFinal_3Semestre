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
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Index { get; set; }
        public string Username { get; set; }
        public double Descuento { get; set; }

        public Form Creator { get; set; }

        // CONSTRUCTOR
        public MuestraProductos(Form creator, int userid = 0, string username = "", int productid = 0, string brand = "", string model = "", string description = "", List<string> images = null, decimal price = 0, int stock = 0, double descuento = 0)
        {
            InitializeComponent();

            Userid = userid;
            Productid = productid;
            Brand = brand;
            Model = model;
            Description = description;
            Images = images ?? new List<string>();
            Price = price;
            Stock = stock;
            Username = username;
            Descuento = descuento;
            Creator = creator;
            this.Index = 0;

            this.ProductMarca.Text = brand;
            this.ProductModel.Text = model;
            this.lblPrecio.Text = $"${price:F2}";
            this.lblStock.Text = Convert.ToString(stock);
            this.ProductDescription.Text = description;

            if (File.Exists(Images[this.Index]))
            {
                this.ProductPicture.Image = System.Drawing.Image.FromFile(Images[this.Index]);
                this.ProductPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Error al mostrar la imagen");
            }

            if (this.Descuento > 0)
                this.lblDescuento.Text = $"- %{this.Descuento}";
            else
                this.lblDescuento.Text = "";
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            AgregarCarrito();
        }
        private void PictureRegresar_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        // Cambia a la imagen anterior
        private void PictureLeft_Click(object sender, EventArgs e)
        {
            if (this.Index == 0)
                this.Index = 4;
            else
                this.Index--;

            this.ProductPicture.Image = Image.FromFile(Images[this.Index]);
            this.ProductPicture.SizeMode = PictureBoxSizeMode.Zoom;
        }
        // Cambia a la imagen siguiente
        private void PictuteRight_Click(object sender, EventArgs e)
        {
            if (this.Index == 4)
                this.Index = 0;
            else
                this.Index++;

            this.ProductPicture.Image = Image.FromFile(Images[this.Index]);
            this.ProductPicture.SizeMode = PictureBoxSizeMode.Zoom;
        }
        // Añade el producto al carrito y te lleva a la pagina de el carrito
        private void btnComprarYa_Click(object sender, EventArgs e)
        {
            AgregarCarrito();
            // Encuentra el formulario contenedor del control
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                // Crea una instancia de CartForm
                CartForm cart = new CartForm(this.Userid, this.Username, this.Creator)
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = parentForm.Location,          
                    Size = parentForm.Bounds.Size           
                };

                // Muestra el formulario de carrito como un diálogo modal
                cart.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo acceder al formulario principal desde el control de usuario.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Añade el producto al carrito 
        public void AgregarCarrito()
        {
            string connectionString = "Server=localhost;Database=tenisdb;User ID=root;Password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    string checkQuery = "SELECT cantidad FROM carrito WHERE userid = @userid AND productid = @productid";

                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@userid", this.Userid);
                        checkCommand.Parameters.AddWithValue("@productid", this.Productid);

                        object result = checkCommand.ExecuteScalar();

                        if (result != null) 
                        {
                            string updateQuery = "UPDATE carrito SET cantidad = cantidad + 1 WHERE userid = @userid AND productid = @productid";

                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@userid", this.Userid);
                                updateCommand.Parameters.AddWithValue("@productid", this.Productid);

                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cantidad actualizada en el carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error al actualizar la cantidad en el carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else 
                        {
                            string insertQuery = "INSERT INTO carrito (userid, productid, precio, imagen, marca, modelo, cantidad) VALUES (@userid, @productid, @precio, @imagen, @marca, @modelo, @cantidad)";

                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@userid", this.Userid);
                                insertCommand.Parameters.AddWithValue("@productid", this.Productid);
                                insertCommand.Parameters.AddWithValue("@precio", this.Price);
                                insertCommand.Parameters.AddWithValue("@imagen", this.Images[0]);
                                insertCommand.Parameters.AddWithValue("@marca", this.Brand);
                                insertCommand.Parameters.AddWithValue("@modelo", this.Model);
                                insertCommand.Parameters.AddWithValue("@cantidad", 1);

                                int rowsAffected = insertCommand.ExecuteNonQuery();
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
