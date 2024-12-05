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

namespace ProyectoProgramacion.Utlis
{
    public partial class ProductForm : UserControl
    {
        // ----- * * * PROPIEDADES * * * -----
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Imagen { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // ----- * * * EVENTOS * * * ----- 
        public event EventHandler ProductClicked;

        // ----- * * * CONSTRUCTOR * * * -----
        public ProductForm(int id = 0, string model = "", string description = "", string image = "", string brand = "", decimal price = 0, int stock = 0)
        {
            InitializeComponent();

            Id = id;
            Model = model;
            Description = description;
            Imagen = Path.Combine("ProductPictures", image);
            Brand = brand;
            Price = price;
            Stock = stock;

            this.MarcaLabel.Text = brand;
            this.ModeloLabel.Text = model;
            this.PrecioLabel.Text = $"${price:F2}";
            this.StockLabel.Text = Convert.ToString(stock);
            
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
