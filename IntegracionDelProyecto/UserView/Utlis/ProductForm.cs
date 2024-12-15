using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoProgramacion.Utlis
{
    public partial class ProductForm : UserControl
    {
        // ----- * * * PROPIEDADES * * * -----
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Novedad { get; set; }
        public double Descuento { get; set; }

        // ----- * * * EVENTOS * * * ----- 
        public event EventHandler ProductClicked;

        // ----- * * * CONSTRUCTOR * * * -----
        public ProductForm(int id = 0, string brand = "", string model = "", string description = "", List<string> images = null, decimal price = 0, int stock = 0, int novedad = 0, double descuento = 0)
        {
            InitializeComponent();

            Id = id;
            Model = model;
            Description = description;
            Images = images;
            Brand = brand;
            Price = price;
            Stock = stock;
            Novedad = novedad;
            Descuento = descuento;

            this.MarcaLabel.Text = brand;
            this.ModeloLabel.Text = model;
            this.PrecioLabel.Text = $"${price:F2}";
            this.StockLabel.Text = $"Stock {stock}";

            if (File.Exists(Images[0]))
            {
                this.ProductPicture.Image = System.Drawing.Image.FromFile(Images[0]);
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

        // ----- * * * METODOS * * * -----
        private void ProductPicture_Click(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);
        }

        private void LowPanel_Click(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
