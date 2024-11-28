using System.Windows.Forms;

namespace adminView
{
    public partial class adminViewForm : Form
    {
        private AddProductForm productForm = new AddProductForm();
        DbManager dbManager = new DbManager();
        public adminViewForm()
        {

            InitializeComponent();

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

        private void cargarDataGrid()
        {
            // Vincula los datos
            List<AdminProduct> productos = dbManager.GetAllProducts();
            foreach (var product in productos)
            {
                dataGridViewListado.Rows.Add(product.Id, product.Nombre, product.Descripcion,
                                       product.Imagen, product.Marca, product.Colores,
                                       product.Tallas, product.Precio, product.Stock);
            }

        }

    }
}
