using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Interfaz
{
    public partial class NuevoUsuario : Form
    {
        private MySqlConnection connection;
        public NuevoUsuario()
        {
            InitializeComponent();
            Connect();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = 1;
            string query = "";

            try
            {
                query = "INSERT INTO users (user_login, user, password) " +
                "VALUES (@user_login, @user, @password)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                // Agregar parámetros
                cmd.Parameters.AddWithValue("@user_login", this.txtBoxUsuario.Text);
                cmd.Parameters.AddWithValue("@user", this.txtBoxNombre.Text);
                cmd.Parameters.AddWithValue("@password", this.txtBoxContra.Text);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError: " + ex.Message);
                this.Disconnect();
            }

            this.Disconnect();
            this.Close();
        }

        public void Connect()
        {
            string dataBase = "Server=localhost; Database=tenisdb; User=root; Password=; SslMode=none;";
            try
            {
                this.connection = new MySqlConnection(dataBase);
                this.connection.Open();
                Console.WriteLine("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Desconectar de la base de datos
        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
