using ProyectoProgramacion.Models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using ProyectoProgramacion.Utlis;
using System.Diagnostics;
using System.Xml.Linq;
using System.Reflection;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoProgramacion.Views
{
    public partial class UserMainForm : Form
    {
        // ----- * * * ATRIBUTOS * * * -----
        private List<Product> products;
        private MySqlConnection connection;
        public int Userid { get; set; }


        // ----- * * * CONSTRUCTOR * * * -----
        public UserMainForm(int id)
        {
            InitializeComponent();
            products = new List<Product>();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
            Connect();
            Query();
            LoadProducts();
            Userid = id;
        }


        // ----- * * * CLOCK Y MEJORA DE SEARCHBOX * * * -----
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


        // ----- * * * CARRITO * * * -----
        #region Carrito
        // Para ir al Carrito
        private void CartPicture_Click(object sender, EventArgs e)
        {
            CartForm cart = new CartForm(this.Userid);

            cart.StartPosition = FormStartPosition.Manual;
            cart.Location = this.Location;
            cart.Size = this.Bounds.Size;

            cart.ShowDialog();
        }
        #endregion


        // ----- * * * SEARCHBOX * * * -----
        #region SearchBox
        // Para hacer una busqueda
        private void LoupePicture_Click(object sender, EventArgs e)
        {
            string searchmodel = this.SearchBox.Texts;
            searchmodel = searchmodel.Replace(" ", "").ToLower();
            string comp;
            List<Product> filter = new List<Product>();

            if (searchmodel == "")
            {
                return;
            }

            for (int i = 0; i < products.Count; i++)
            {
                comp = this.products[i].Model;
                comp = comp.Replace(" ", "").ToLower();
                if (comp.Contains(searchmodel))
                {
                    filter.Add(products[i]);
                }
            }

            if (filter.Count > 0)
            {
                FlowLayoutProducts.Controls.Clear();
                foreach (var product in filter)
                {
                    ProductForm productForm = new ProductForm(
                        product.Id,
                        product.Brand,
                        product.Model,
                        product.Description,
                        product.Images,
                        product.Price,
                        product.Stock
                    );
                    productForm.ProductClicked += Product_ProductClicked;
                    FlowLayoutProducts.Controls.Add(productForm);
                }
                SearchBox.Texts = "";
            }
            else
            {
                SearchBox.Texts = "";
            }
        }
        #endregion


        // ----- * * * LOG OUT Y MENU DESLEGABLE * * * -----
        #region Log Out y Menu desplegable
        // Hacer Log Out
        private void LogoutPicture_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de confirmación con dos botones: Confirmar y Cancelar
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar la sesión?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            // Verifica si el usuario seleccionó "Sí" para confirmar
            if (result == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }
        // Hacer Log Out
        private void lblLogout_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de confirmación con dos botones: Confirmar y Cancelar
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar la sesión?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            // Verifica si el usuario seleccionó "Sí" para confirmar
            if (result == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();
            }
        }
        // Para Cerrar el Menu Desplegable
        private void ExitMenuPicture_Click(object sender, EventArgs e)
        {
            UserMenu.Visible = false;
        }
        // Para Mostrar Menu con el Log Out
        private void AccountPicture_Click(object sender, EventArgs e)
        {
            UserMenu.Visible = true;
        }
        #endregion


        // ----- * * * BASE DE DATOS Y MOSTRAR PRODUCTOS * * * -----
        #region Base de Datos y Mostrar Productos
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
            string brand;
            string model;
            string description;
            List<string> images = new List<string>(5);
            string img1;
            string img2;
            string img3;
            string img4;
            string img5;
            decimal price;
            int stock;

            try
            {
                string query = "SELECT * FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    brand = Convert.ToString(reader["marca"]) ?? "";
                    model = Convert.ToString(reader["modelo"]) ?? "";
                    description = Convert.ToString(reader["descripcion"]) ?? "";

                    img1 = Convert.ToString(reader["imagen"]) ?? "";
                    img2 = Convert.ToString(reader["imagen2"]) ?? "";
                    img3 = Convert.ToString(reader["imagen3"]) ?? "";
                    img4 = Convert.ToString(reader["imagen4"]) ?? "";
                    img5 = Convert.ToString(reader["imagen5"]) ?? "";
                    price = Convert.ToDecimal(reader["precio"]);
                    stock = Convert.ToInt32(reader["stock"]);

                    images.Add(img1);
                    images.Add(img2);
                    images.Add(img3);
                    images.Add(img4);
                    images.Add(img5);

                    item = new Product(id, brand, model, description, images, price, stock);
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
            FlowLayoutProducts.Controls.Clear(); // Limpia los controles anteriores

            foreach (var product in products)
            {
                // Asigna datos del producto al formulario
                ProductForm productForm = new ProductForm(
                    product.Id,
                    product.Brand,
                    product.Model,
                    product.Description,
                    product.Images,
                    product.Price,
                    product.Stock
                );

                // Suscribe el evento de clic
                productForm.ProductClicked += Product_ProductClicked;

                // Agrega el formulario al FlowLayoutPanel
                FlowLayoutProducts.Controls.Add(productForm);
            }
        }
        // Evento que se activa al hacer click en un producto
        private void Product_ProductClicked(object sender, EventArgs e)
        {
            if (sender is ProductForm productForm)
            {
                // Crear una instancia del control de usuario con el constructor
                var muestraProductos = new MuestraProductos(
                    userid: this.Userid,
                    productid: productForm.Id,
                    brand: productForm.Brand,
                    model: productForm.Model,
                    description: productForm.Description,
                    images: productForm.Images,
                    price: productForm.Price,
                    stock: productForm.Stock
                );

                // Agregar el control al formulario principal
                this.Controls.Add(muestraProductos);
                muestraProductos.Dock = DockStyle.Fill;
                muestraProductos.BringToFront();
            }
        }
        #endregion


        // ----- * * * BOTONES DE EL NAVBAR * * * -----
        #region Botones de el Nav Bar
        // Filtrar Productos de la Marca Nike
        private void btnNike_Click(object sender, EventArgs e)
        {
            var nikeProducts = products.Where(p => p.Brand.Equals("Nike", StringComparison.OrdinalIgnoreCase)).ToList();

            FlowLayoutProducts.Controls.Clear();

            foreach (var product in nikeProducts)
            {
                ProductForm productForm = new ProductForm(
                    product.Id,
                    product.Brand,
                    product.Model,
                    product.Description,
                    product.Images,
                    product.Price,
                    product.Stock
                );

                productForm.ProductClicked += Product_ProductClicked;

                FlowLayoutProducts.Controls.Add(productForm);
            }
        }
        // Filtrar Productos de la Marca Jordan
        private void btnJordan_Click(object sender, EventArgs e)
        {
            var jordanProducts = products.Where(p => p.Brand.Equals("Jordan", StringComparison.OrdinalIgnoreCase)).ToList();

            FlowLayoutProducts.Controls.Clear();

            foreach (var product in jordanProducts)
            {
                ProductForm productForm = new ProductForm(
                    product.Id,
                    product.Brand,
                    product.Model,
                    product.Description,
                    product.Images,
                    product.Price,
                    product.Stock
                );

                productForm.ProductClicked += Product_ProductClicked;

                FlowLayoutProducts.Controls.Add(productForm);
            }
        }
        // Filtrar Productos de la Marca Adidas
        private void btnAdidas_Click(object sender, EventArgs e)
        {
            var adidasProducts = products.Where(p => p.Brand.Equals("Adidas", StringComparison.OrdinalIgnoreCase)).ToList();

            FlowLayoutProducts.Controls.Clear();

            foreach (var product in adidasProducts)
            {
                ProductForm productForm = new ProductForm(
                    product.Id,
                    product.Brand,
                    product.Model,
                    product.Description,
                    product.Images,
                    product.Price,
                    product.Stock
                );

                productForm.ProductClicked += Product_ProductClicked;

                FlowLayoutProducts.Controls.Add(productForm);
            }
        }
        // Filtrar Novedades
        private void btnNovedades_Click(object sender, EventArgs e)
        {

        }
        // Filtrar Productos con Descuento
        private void btnDescuento_Click(object sender, EventArgs e)
        {

        }
        // Muestra todos los productos disponibles
        private void LogoPicture_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
        #endregion
    }
}


