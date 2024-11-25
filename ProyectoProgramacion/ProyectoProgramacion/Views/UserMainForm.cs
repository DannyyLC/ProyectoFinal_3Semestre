using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoProgramacion.Views
{
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();
        }

        private void UserMainForm_Layout(object sender, LayoutEventArgs e)
        {
            SearchBox.PerformLayout();
            SearchBox.Invalidate();
        }
    }
}

