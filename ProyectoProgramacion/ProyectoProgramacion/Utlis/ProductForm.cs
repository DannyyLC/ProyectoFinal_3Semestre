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
    public partial class ProductForm : UserControl
    {
        public int Id { get; set; }
        public event EventHandler ProductClicked;
        public ProductForm(int id, string marca, string modelo, decimal precio, int stock, string image)
        {
            InitializeComponent();
            Id = id;
            this.MarcaLabel.Text = marca;
            this.ModeloLabel.Text = modelo;
            this.PrecioLabel.Text = $"${precio:F2}";
            this.StockLabel.Text = Convert.ToString(stock);

            string fullImagePath = Path.Combine("ProductPictures", image);
            if (File.Exists(fullImagePath))
            {
                this.ProductPicture.Image = Image.FromFile(fullImagePath);
                this.ProductPicture.SizeMode = PictureBoxSizeMode.Zoom; // Opcional: ajusta el modo de visualización
            }
            else
            {
                MessageBox.Show("Error al mostrar la imagen");
            }
        }

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
