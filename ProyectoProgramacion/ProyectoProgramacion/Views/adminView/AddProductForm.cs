using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminView
{
    public partial class AddProductForm : Form
    {
        string imagen;
        adminViewForm adminForm;

        public AddProductForm(adminViewForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configuración del cuadro de diálogo
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // Carpeta inicial
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Solo imágenes
                openFileDialog.FilterIndex = 1; // Selecciona el primer filtro
                openFileDialog.Title = "Seleccione una imagen"; // Título del cuadro de diálogo

                // Mostrar el diálogo y verificar si se seleccionó un archivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta completa del archivo seleccionado
                    this.imagen = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún archivo.");
                }
            }
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.textBoxID.Text);
            string nombre = this.textBoxNombre.Text;
            string descripcion = this.textBoxDescripcion.Text;
            string marca = this.textBoxMarca.Text;
            string colores = this.textBoxColores.Text;
            string tallas = this.textBoxTallas.Text;
            int precio = Convert.ToInt32(this.textBoxPrecio.Text);
            int stock = Convert.ToInt32(this.textBoxStock.Text);

            if (this.imagen != null)
            {

                adminForm.dbManager.InsertProduct(id, nombre, descripcion, imagen, marca, colores, tallas, precio, stock);

                this.textBoxID.Clear();
                this.textBoxNombre.Clear();
                this.textBoxDescripcion.Clear();
                this.textBoxMarca.Clear();
                this.textBoxMarca.Clear();
                this.textBoxColores.Clear();
                this.textBoxTallas.Clear();
                this.textBoxPrecio.Clear();
                this.textBoxStock.Clear();

                adminForm.cargarDataGrid();

                this.Hide();
            }
            else
            {
                MessageBox.Show($"Imagen: {this.imagen}");
            }
        }
    }
}
