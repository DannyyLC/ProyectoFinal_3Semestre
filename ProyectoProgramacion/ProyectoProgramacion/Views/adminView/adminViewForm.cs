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

                // Enviar el id a borrar a la funcion delete product
                dbManager.DeleteProduct(Convert.ToInt32(id));

                //Recargamos el datagridview
                this.cargarDataGrid();
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
    }
}
