using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using ProyectoProgramacion.Models;
using System.Net.Quic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ProyectoProgramacion.Views
{
    public partial class CartForm : Form
    {
        // ----- * * * ATRIBUTOS * * * -----
        private List<ProductCart> cartProducts;
        public int Id { get; set; }
        public decimal Total { get; set; }
        private MySqlConnection connection;

        // ----- * * * CONSTRUCTOR * * * -----
        public CartForm(int id)
        {
            InitializeComponent();
            this.Id = id;
            cartProducts = new List<ProductCart>();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
            Query();
            AddCartProducts();
        }

        // ----- * * * BASE DE DATOS Y MOSTRAR PRODUCTOS * * * -----
        #region Base de Datos y Mostrar Productos
        // Nos conectamos con la base de datos
        public void Connect()
        {
            if (this.connection == null)
            {
                string dataBase = "Server=localhost; Database=tenisdb; User=root; Password=; SslMode=none;";
                try
                {
                    this.connection = new MySqlConnection(dataBase);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al inicializar la conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                if (this.connection.State != System.Data.ConnectionState.Open)
                {
                    this.connection.Open();
                    Console.WriteLine("Conexión establecida exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // Traer toda al informacion de la tabla de carrito de la base de datos
        public void Query()
        {
            Connect();

            ProductCart cart = new ProductCart();
            string imagen;
            string marca;
            string modelo;
            decimal precio;
            int userid;
            int productid;

            try
            {
                if (this.connection.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("La conexión no está abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string query = "SELECT * FROM carrito WHERE userid = @userid";

                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.Parameters.AddWithValue("@userid", this.Id);

                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No se encontraron productos en el carrito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                while (reader.Read())
                {
                    userid = Convert.ToInt32(reader["userid"]);
                    productid = Convert.ToInt32(reader["productid"]);
                    marca = Convert.ToString(reader["marca"]) ?? "";
                    modelo = Convert.ToString(reader["modelo"]) ?? "";
                    precio = Convert.ToDecimal(reader["precio"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";

                    cart = new ProductCart(imagen, marca, modelo, precio, userid, productid);
                    cartProducts.Add(cart);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
        }
        // Añade los productos de la lista a la interfaz grafica
        public void AddCartProducts()
        {
            if (TableProducts == null)
            {
                MessageBox.Show("El control TableProducts no está inicializado.");
                return;
            }

            if (cartProducts == null)
            {
                MessageBox.Show("La lista cartProducts no está inicializada.");
                return;
            }

            if (cartProducts.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = "El carrito está vacío.",
                    Font = new Font("Tahoma", 28, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                TableProducts.Controls.Add(lblEmpty, 1, 0);
            }
            else
            {
                TableProducts.RowCount = cartProducts.Count + 1;
                TableProducts.RowStyles.Clear();

                for (int i = 0; i < cartProducts.Count; i++)
                {
                    TableProducts.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                TableProducts.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                TableProducts.Controls.Clear();

                string imagen;
                string marca;
                string modelo;
                decimal precio;
                this.Total = 0;

                for (int i = 0; i < cartProducts.Count; i++)
                {
                    imagen = cartProducts[i].Imagen;
                    marca = cartProducts[i].Marca;
                    modelo = cartProducts[i].Modelo;
                    precio = cartProducts[i].Precio;

                    this.Total += precio;

                    CartProduct product = new CartProduct(imagen, marca, modelo, precio);
                    TableProducts.Controls.Add(product, 1, i);
                }

                Label totalLabel = new Label
                {
                    Text = $"Total: ${this.Total:F2}",
                    Font = new Font("Tahoma", 18, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Height = 60
                };

                TableProducts.Controls.Add(totalLabel, 1, cartProducts.Count);
            }
        }
        //  Elimina los productos de el carrito
        public void DeleteCartItemsByUserId()
        {
            try
            {
                Connect();

                if (this.connection.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("La conexión no está abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "DELETE FROM carrito WHERE userid = @userid";
                using (MySqlCommand command = new MySqlCommand(query, this.connection))
                {
                    command.Parameters.AddWithValue("@userid", this.Id);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"{rowsAffected} filas eliminadas del carrito.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron productos para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar productos del carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Actualiza la tabla de productos
        public void UpdateProductStock()
        {
            try
            {
                Connect();

                foreach (var product in cartProducts)
                {
                    string query = "UPDATE productos SET stock = stock - 1 WHERE id = @productid AND stock > 0";

                    using (MySqlCommand command = new MySqlCommand(query, this.connection))
                    {
                        command.Parameters.AddWithValue("@productid", product.ProductId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Stock actualizado para el producto con ID: {product.ProductId}");
                        }
                        else
                        {
                            Console.WriteLine($"No se pudo actualizar el stock para el producto con ID: {product.ProductId}. Puede que no haya suficiente stock.");
                        }
                    }
                }

                Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // ----- * * * BOTONES * * * -----
        #region
        private void btnPagar_Click(object sender, EventArgs e)
        {
            this.txtCVC.Texts = "";
            this.txtEmail.Texts = "";
            this.txtFecha.Texts = "";
            this.txtNumeroTarjeta.Texts = "";
            this.txtTitular.Texts = "";

            UpdateProductStock();
            DeleteCartItemsByUserId();
            cartProducts.Clear();
            Query();
            TableProducts.Controls.Clear();
            AddCartProducts();

            MessageBox.Show("Compra realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Cierra el form de el carrito y volvemos al principal
        private void LogoPicture_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
