using adminView;
using Interfaz;
using Microsoft.VisualBasic.Logging;
using ProyectoProgramacion.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroductionView
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Portada portada = new Portada();
            this.Hide();
            portada.WindowState = FormWindowState.Maximized;
            portada.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
            this.Show();
        }

        private void labelAcceso_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitProgram_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            this.SignInAttempt();
            this.ClearFields();

        }
        private void ClearFields()
        {
            this.textBoxUsername.Text = "";
            this.textBoxPassword.Text = "";
            this.textBoxUsername.PlaceholderText = "Usuario";
            this.textBoxPassword.PlaceholderText = "Contraseña";
        }
        private void SignInAttempt()
        {
            JuanDBAdmin attempt = new JuanDBAdmin();

            string username, password;
            int user = 0;

            username = this.textBoxUsername.Text;
            password = this.textBoxPassword.Text;

            user = attempt.verificar(username, password);


            if (user == -1)
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
                this.ClearFields();
            }
            else if (user == 0)
            {
                {
                    adminViewForm adminview = new adminViewForm();
                    adminview.WindowState = FormWindowState.Maximized;
                    this.Hide();
                    adminview.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                UserMainForm userform = new UserMainForm(user, username);
                userform.WindowState = FormWindowState.Maximized;
                this.Hide();

                userform.ShowDialog();
                this.Show();
            }
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.StartPosition = FormStartPosition.CenterParent;
            nuevoUsuario.ShowDialog();
        }
    }
}