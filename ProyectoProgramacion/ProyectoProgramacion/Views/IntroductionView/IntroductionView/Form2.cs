using Microsoft.VisualBasic.Logging;
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
            portada.ShowDialog();
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
            bool band = false;

            while (!band)
            {
                username = this.textBoxUsername.Text;
                password = this.textBoxPassword.Text;

                band = attempt.verificar(username, password);

                if (!band)
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                    this.ClearFields();
                }
                else
                {
                    //Console.WriteLine("Bienvenido " + username);
                }
            }
        }
    }
}