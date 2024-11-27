namespace adminView
{
    public partial class adminViewForm : Form
    {
        private AddProductForm productForm = new AddProductForm();
        public adminViewForm()
        {

            InitializeComponent();

            System.Windows.Forms.Timer timerHora = new System.Windows.Forms.Timer();
            DateTime fechaHoy = DateTime.Today;
            timerHora.Interval = 1000; // Intervalo de 1 segundo
            timerHora.Tick += (s, e) =>
            {
                labelHora.Text = $"Fecha: {fechaHoy.ToString("dd/MM/yyyy")}\nHora: {DateTime.Now.ToString("HH:mm:ss")}"; // Actualiza la hora en formato 24 horas
            };
            timerHora.Start();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            productForm.StartPosition = FormStartPosition.CenterParent;
            productForm.ShowDialog(this);
        }
    }
}
