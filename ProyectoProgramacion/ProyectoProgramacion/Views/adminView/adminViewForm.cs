using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace adminView
{
    public partial class adminViewForm : Form
    {
        private AddProductForm productForm;
        public DbManager dbManager = new DbManager();
        public adminViewForm()
        {

            InitializeComponent();

            productForm = new AddProductForm(this);

            dataGridViewListado.AutoGenerateColumns = false;

            System.Windows.Forms.Timer timerHora = new System.Windows.Forms.Timer();
            DateTime fechaHoy = DateTime.Today;
            timerHora.Interval = 1000; // Intervalo de 1 segundo
            timerHora.Tick += (s, e) =>
            {
                labelHora.Text = $"Fecha: {fechaHoy.ToString("dd/MM/yyyy")}\nHora: {DateTime.Now.ToString("HH:mm:ss")}"; // Actualiza la hora en formato 24 horas
            };
            timerHora.Start();

            dataGridViewListado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewListado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            generarGrafica();
            actualizarResumen();
            cargarDataGrid();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            productForm.StartPosition = FormStartPosition.CenterParent;
            productForm.ShowDialog(this);
        }

        public void cargarDataGrid()
        {

            dataGridViewListado.Rows.Clear();

            // Vincula los datos
            List<AdminProduct> productos = dbManager.GetAllProducts();
            foreach (var product in productos)
            {
                dataGridViewListado.Rows.Add(product.Id, product.Nombre, product.Descripcion,
                                       product.Imagen, product.Marca, product.Colores,
                                       product.Tallas, product.Precio, product.Stock);
            }

            //Funcion que añade espacios en blanco a la ruta para que se ajuste al tamaño
            foreach (DataGridViewRow row in dataGridViewListado.Rows)
            {
                string content = row.Cells["Imagen"].Value.ToString();
                row.Cells["Imagen"].Value = InsertBreaks(content, 30); // Cada cuanto queremos que se inserte un espacio en blanco
            }

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dataGridViewListado.SelectedRows.Count > 0)
            {
                // Obtén la primera fila seleccionada
                var filaSeleccionada = dataGridViewListado.SelectedRows[0];

                // Obtén el valor de la primera celda
                var id = filaSeleccionada.Cells[0].Value;
                var nombreProducto = filaSeleccionada.Cells[1].Value; // Suponiendo que el nombre está en la columna 1

                // Mostrar un cuadro de diálogo para confirmar la eliminación
                DialogResult result = MessageBox.Show(
                    $"¿Estás seguro de que deseas eliminar el producto '{nombreProducto}' con ID {id}?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Si el usuario confirma, se procede a eliminar
                if (result == DialogResult.Yes)
                {
                    // Enviar el id a borrar a la función delete product
                    dbManager.DeleteProduct(Convert.ToInt32(id));

                    // Recargar el DataGridView
                    this.cargarDataGrid();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }


        private void btnSignOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string InsertBreaks(string input, int maxLength)
        {
            for (int i = maxLength; i < input.Length; i += maxLength)
            {
                input = input.Insert(i, " "); // Inserta un espacio como punto de quiebre
            }
            return input;
        }

        private void actualizarResumen()
        {
            List<string> data = dbManager.GetSummaryData();

            labelVentasTotalesDato.Text = data[0];
            labelNumeroPedidosDato.Text = data[1];
            labelStockDato.Text = data[2];
        }

        private void generarGrafica()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                // Subir tres niveles: bin -> Debug -> net8.0-windows
                string projectRoot = Directory.GetParent(baseDir).Parent.Parent.Parent.FullName;
                string exePath = Path.Combine(projectRoot, "python", "ChartGenerator.exe");

                // Verificar si el ejecutable existe en la ruta especificada
                if (!File.Exists(exePath))
                {
                    MessageBox.Show("El ejecutable de Python no se encuentra en la ruta especificada.");
                    return;
                }

                Dictionary<string, int> jsonData = dbManager.GetInfoMarca();
                string json = JsonSerializer.Serialize(jsonData);
                string escapedJson = json.Replace("\"", "\\\"");

                // Ejecutar el ejecutable de Python
                Process pythonProcess = new Process();
                pythonProcess.StartInfo.FileName = exePath; // Cambiar a la ruta del ejecutable
                pythonProcess.StartInfo.Arguments = $"\"{escapedJson}\""; // Pasa el JSON como argumento
                pythonProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(exePath); // Establecer el directorio de trabajo al de los scripts
                pythonProcess.StartInfo.RedirectStandardOutput = true;
                pythonProcess.StartInfo.UseShellExecute = false;
                pythonProcess.StartInfo.CreateNoWindow = true;
                pythonProcess.Start();
                pythonProcess.WaitForExit(); // Esperar a que termine la ejecución

                // Cargar la imagen generada en el PictureBox
                string imagenPath = Path.Combine(projectRoot, "python", "grafica_barras.png"); // Imagen en el directorio base
                if (File.Exists(imagenPath))
                {
                    pictureBoxGrafica.Image = Image.FromFile(imagenPath); // Cargar la imagen en el PictureBox
                }
                else
                {
                    MessageBox.Show("La imagen generada no se encontró.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la gráfica: " + ex.Message);
            }
        }

        private void roundedTableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
