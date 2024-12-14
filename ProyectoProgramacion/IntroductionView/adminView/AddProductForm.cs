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
        string[] selectedFiles = new string[5] { "", "", "", "", "" };
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
                openFileDialog.Multiselect = true;
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); // Carpeta inicial
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Solo imágenes
                openFileDialog.FilterIndex = 1; // Selecciona el primer filtro
                openFileDialog.Title = "Seleccione una imagen"; // Título del cuadro de diálogo

                // Mostrar el diálogo y verificar si se seleccionó un archivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Copiar solo los nombres de los archivos seleccionados al arreglo
                    for (int i = 0; i < openFileDialog.FileNames.Length && i < 5; i++)
                    {
                        selectedFiles[i] = Path.GetFileName(openFileDialog.FileNames[i]); // Obtiene el nombre del archivo
                    }
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
            int precio = Convert.ToInt32(this.textBoxPrecio.Text);
            int stock = Convert.ToInt32(this.textBoxStock.Text);

            if (this.selectedFiles != null && this.selectedFiles.Length > 0)
            {

                adminForm.dbManager.InsertProduct(id, nombre, descripcion, selectedFiles[0], selectedFiles[1], selectedFiles[2], 
               selectedFiles[3], selectedFiles[4], marca, precio, stock);

                this.textBoxID.Clear();
                this.textBoxNombre.Clear();
                this.textBoxDescripcion.Clear();
                this.textBoxMarca.Clear();
                this.textBoxMarca.Clear();
                this.textBoxPrecio.Clear();
                this.textBoxStock.Clear();

                adminForm.cargarDataGrid();

                this.Hide();
            }
            else
            {
                MessageBox.Show($"No se ha seleccionado una imagen.");
            }
        }
    }
}
