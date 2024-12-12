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
        public string Imagen {  get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }

        public CartProduct(string image = "", string marca = "", string modelo = "", decimal precio = 0)
        {
            InitializeComponent();
            this.Imagen = image;
            this.Marca = marca; 
            this.Modelo = modelo;   
            this.Precio = precio;

            this.MarcaLabel.Text = marca;
            this.ModeloLabel.Text = modelo;
            this.PrecioLabel.Text = $"${precio:F2}";

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
    }
}
