using ProyectoProgramacion.Models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using ProyectoProgramacion.Utlis;
using System.Diagnostics;
using System.Xml.Linq;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace ProyectoProgramacion.Views
{
    public partial class UserMainForm : Form
    {
        private List<Product> products;
        private MySqlConnection connection;
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

        // Para el Funcionamiento de el Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        // Para Mostrar Menu con el Log Out
        private void AccountPicture_Click(object sender, EventArgs e)
        {
            UserMenu.Visible = true;
        }
        // Para Cerrar el Menu Desplegable
        private void ExitMenuPicture_Click(object sender, EventArgs e)
        {
            UserMenu.Visible = false;
        }
        // Para ir al Carrito
        private void CartPicture_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm();

            cart.StartPosition = FormStartPosition.Manual;
            cart.Location = this.Location;
            cart.Size = this.Bounds.Size;

            cart.ShowDialog();
        }
        // Para hacer una busqueda
        private void LoupePicture_Click(object sender, EventArgs e)
        {

        }
        // Hacer Log Out
        private void LogoutPicture_Click(object sender, EventArgs e)
        {
            // Logica para Log Out
            this.Close();
            this.Dispose();
        }
        // Hacer Log Out
        private void lblLogout_Click(object sender, EventArgs e)
        {
            // Logica para Log Out
            this.Close();
            this.Dispose();
        }
        // Filtrar Productos Por Marca Nike
        private void btnNike_Click(object sender, EventArgs e)
        {

        }
        // Filtrar Productos con Descuento
        private void btnDescuento_Click(object sender, EventArgs e)
        {

        }
        // Salir de la vista de un producto
        private void PictureRegresar_Click(object sender, EventArgs e)
        {
            ProductView.Visible = false;
        }
        // Nos conectamos con la base de datos
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
        // Traer toda al informacion de la tabla de productos de la base de datos
        public void Query()
        {
            Product item;
            int id;
            string name;
            string description;
            string image;
            string brand;
            string colors;
            int stock;
            decimal price;

            try
            {
                string query = "SELECT * FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["nombre"]) ?? "";
                    description = Convert.ToString(reader["descripcion"]) ?? "";
                    image = Convert.ToString(reader["imagen"]) ?? "";
                    brand = Convert.ToString(reader["marca"]) ?? "";
                    colors = Convert.ToString(reader["colores"]) ?? "";
                    stock = Convert.ToInt32(reader["precio"]);
                    price = Convert.ToDecimal(reader["stock"]);

                    item = new Product(id, name, description, image, brand, colors, price, stock);
                    products.Add(item);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
        }
        // Cargamos los Forms de los productos para verlos en la interfaz
        public void LoadProducts()
        {

            for (int i = 0; i < products.Count; i++)  
            {
                ProductForm product = new ProductForm(products[i].Id);
                product.ProductClicked += Product_ProductClicked;  
                FlowLayoutProducts.Controls.Add(product);
            }
        }
        // Evento que se activa al hacer click en un producto
        private void Product_ProductClicked(object sender, EventArgs e)
        {
            // Aquí puedes ocultar el control en FormB
            var controlToHide = this.Controls["ProductView"];  // Cambia el nombre al control que deseas ocultar
            if (controlToHide != null)
            {
                controlToHide.Visible = true;
                controlToHide.BringToFront();
            }
        }
    }
}

