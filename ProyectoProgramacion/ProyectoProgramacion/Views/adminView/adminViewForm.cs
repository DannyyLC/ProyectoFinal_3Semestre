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

                    MessageBox.Show("Producto eliminado exitosamente.");
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
    }
}
