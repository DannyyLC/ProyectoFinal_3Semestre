namespace ProyectoProgramacion.Views
{
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text Changed");
        }
    }
}
