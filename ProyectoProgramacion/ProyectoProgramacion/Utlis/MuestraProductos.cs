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
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Imagen { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // CONSTRUCTOR
        public MuestraProductos(int id = 0, string model = "", string description = "", string image = "", string brand = "", decimal price = 0, int stock = 0)
        {
            InitializeComponent();

            Id = id;
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

        }
    }
}
