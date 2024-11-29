using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoProgramacion.Views
{
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }

        private void UserMainForm_Layout(object sender, LayoutEventArgs e)
        {
            SearchBox.PerformLayout();
            SearchBox.Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void AccountPicture_Click(object sender, EventArgs e)
        {
            UserMenu.Visible = true;
        }

        private void CartPicture_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm();

            cart.StartPosition = FormStartPosition.Manual;
            cart.Location = this.Location;
            cart.Size = this.Bounds.Size;

            cart.ShowDialog();
        }

        private void LoupePicture_Click(object sender, EventArgs e)
        {

        }

        private void ExitMenuPicture_Click(object sender, EventArgs e)
        {
            UserMenu.Visible = false;
        }

        private void LogoutPicture_Click(object sender, EventArgs e)
        {
            // Logica para Log Out
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            // Logica para Log Out
        }
    }
}

