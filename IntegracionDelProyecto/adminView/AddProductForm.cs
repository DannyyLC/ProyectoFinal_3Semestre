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
                openFileDialog.Multiselect = true;
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "Seleccione una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Ruta relativa al directorio raíz del proyecto
                    string projectFolder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                    string targetFolder = Path.Combine(projectFolder, "ProductPictures");

                    for (int i = 0; i < openFileDialog.FileNames.Length && i < 5; i++)
                    {
                        selectedFiles[i] = "ProductPictures/" + Path.GetFileName(openFileDialog.FileNames[i]); // Obtiene el nombre del archivo
                    }

                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }

                    foreach (string sourceFile in openFileDialog.FileNames)
                    {
                        string targetFile = Path.Combine(targetFolder, Path.GetFileName(sourceFile));
                        string targetFile2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"ProductPictures", Path.GetFileName(sourceFile));

                        if (Path.GetFullPath(sourceFile).Equals(Path.GetFullPath(targetFile), StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show($"El archivo {Path.GetFileName(sourceFile)} ya está en la carpeta destino.");
                            continue;
                        }

                        try
                        {
                            File.Copy(sourceFile, targetFile, true);
                            File.Copy(sourceFile, targetFile2, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al copiar el archivo: {ex.Message}");
                        }
                    }

                    MessageBox.Show("Archivos movidos a la carpeta ProductPictures.");
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
            int novedad;
            if (checkBoxNovedad.Checked) 
            {
                novedad = 1;
            }
            else
            {
                novedad = 0;
            }
            float descuento = Convert.ToSingle(this.textBoxDescuento.Text);

            if (this.selectedFiles != null && this.selectedFiles.Length > 0)
            {

                adminForm.dbManager.InsertProduct(id, nombre, descripcion, selectedFiles[0], selectedFiles[1], selectedFiles[2], 
               selectedFiles[3], selectedFiles[4], marca, precio, stock, novedad, descuento);

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
