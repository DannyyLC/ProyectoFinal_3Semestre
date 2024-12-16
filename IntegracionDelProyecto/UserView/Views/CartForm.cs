using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using ProyectoProgramacion.Models;
using ProyectoProgramacion.Utlis;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Quic;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoProgramacion.Views
{
    public partial class CartForm : Form
    {
        // ----- * * * PROPIEDADES Y ATRIBUTOS * * * -----
        private List<ProductCart> cartProducts;
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Username { get; set; }
        private MySqlConnection connection;
        private Label totalLabel;
        private Form _creatorForm;

        // ----- * * * CONSTRUCTOR * * * -----
        public CartForm(int id, string nombre, Form creatorForm)
        {
            InitializeComponent();
            this.Id = id;
            cartProducts = new List<ProductCart>();
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Timer.Start();
            this.Total = 0;


            this.totalLabel = new Label
            {
                Text = $"Total: ${this.Total:F2}",
                Font = new Font("Tahoma", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Height = 60
            };

            Query();
            AddCartProducts();
            Username = nombre;
            this.lblNombre.Text = nombre;
            _creatorForm = creatorForm;
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

            ProductCart cart;
            string imagen;
            string marca;
            string modelo;
            decimal precio;
            int userid;
            int productid;
            int cantidad;

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

                Dictionary<int, int> cantidadPorProducto = new Dictionary<int, int>();

                while (reader.Read())
                {
                    userid = Convert.ToInt32(reader["userid"]);
                    productid = Convert.ToInt32(reader["productid"]);
                    marca = Convert.ToString(reader["marca"]) ?? "";
                    modelo = Convert.ToString(reader["modelo"]) ?? "";
                    precio = Convert.ToDecimal(reader["precio"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    cantidad = Convert.ToInt32(reader["cantidad"]);

                    if (cantidadPorProducto.ContainsKey(productid))
                    {
                        cantidadPorProducto[productid] += cantidad;
                    }
                    else
                    {
                        cantidadPorProducto[productid] = cantidad;
                        int stock = GetProductStock(productid);

                        cart = new ProductCart(imagen, marca, modelo, precio, userid, productid, cantidad, stock);
                        cartProducts.Add(cart);
                    }
                }

                reader.Close(); // Cierra el DataReader antes de ejecutar otros comandos

                // Actualiza las cantidades en la base de datos
                foreach (var item in cantidadPorProducto)
                {
                    string updateQuery = "UPDATE carrito SET cantidad = @cantidad WHERE productid = @productid AND userid = @userid";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, this.connection);
                    updateCommand.Parameters.AddWithValue("@cantidad", item.Value);
                    updateCommand.Parameters.AddWithValue("@productid", item.Key);
                    updateCommand.Parameters.AddWithValue("@userid", this.Id);

                    updateCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
            }
            finally
            {
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
                int cantidad;
                int stock;
                int userid;
                int productid;
                this.Total = 0;

                for (int i = 0; i < cartProducts.Count; i++)
                {
                    imagen = cartProducts[i].Imagen;
                    marca = cartProducts[i].Marca;
                    modelo = cartProducts[i].Modelo;
                    precio = cartProducts[i].Precio;
                    cantidad = cartProducts[i].Cantidad;
                    stock = cartProducts[i].Stock;
                    userid = cartProducts[i].Userid;
                    productid = cartProducts[i].ProductId;

                    this.Total += precio * cantidad;

                    CartProduct product = new CartProduct(imagen, marca, modelo, precio, cantidad, stock, userid, productid, cartProducts[i]);
                    product.PriceChanged += Product_PriceChanged;
                    TableProducts.Controls.Add(product, 1, i);
                }

                this.totalLabel.Text = $"Total: ${this.Total:F2}";

                TableProducts.Controls.Add(totalLabel, 1, cartProducts.Count);
            }
        }
        // Retorna el Sstock disponible para algun producto
        private int GetProductStock(int productId)
        {
            int stock = 0;

            try
            {
                // Nueva conexión para esta consulta
                string connectionString = "Server=localhost; Database=tenisdb; User=root; Password=; SslMode=none;";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string stockQuery = "SELECT stock FROM productos WHERE id = @productId";
                    using (MySqlCommand stockCommand = new MySqlCommand(stockQuery, connection))
                    {
                        stockCommand.Parameters.AddWithValue("@productId", productId);

                        object result = stockCommand.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            stock = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el stock del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return stock;
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
                Connect(); // Conectar a la base de datos

                foreach (Control control in TableProducts.Controls)
                {
                    if (control is CartProduct cartProduct)
                    {
                        int cantidad = cartProduct.Cantidad;
                        int productId = cartProduct.ProductId; 

                        string query = "UPDATE productos SET stock = stock - @cantidad WHERE id = @productid AND stock >= @cantidad";

                        using (MySqlCommand command = new MySqlCommand(query, this.connection))
                        {
                            command.Parameters.AddWithValue("@cantidad", cantidad);
                            command.Parameters.AddWithValue("@productid", productId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine($"Stock actualizado para el producto con ID: {productId}");
                            }
                            else
                            {
                                Console.WriteLine($"No se pudo actualizar el stock para el producto con ID: {productId}. Puede que no haya suficiente stock.");
                            }
                        }
                    }
                }

                Disconnect(); // Desconectar de la base de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        // ----- * * * BOTONES * * * -----
        #region Botones
        private void btnPagar_Click(object sender, EventArgs e)
        {
            this.txtCVC.Texts = "";
            this.txtEmail.Texts = "";
            this.txtFecha.Texts = "";
            this.txtNumeroTarjeta.Texts = "";
            this.txtTitular.Texts = "";

            if (cartProducts.Count == 0)
            {
                MessageBox.Show("No se puede realizar la compra porque el carrito esta vacio", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //Llamada a funcion que agrega la informacion del pedido a la tabla de pedidos en la db
            RegistrarPedido();

            //Llamando el PaymentForm
            PaymentForm paymentform = new PaymentForm(cartProducts, Total);
            paymentform.StartPosition = FormStartPosition.CenterParent;
            paymentform.ShowDialog(this);

            UpdateProductStock();
            DeleteCartItemsByUserId();
            cartProducts.Clear();
            Query();
            TableProducts.Controls.Clear();
            AddCartProducts();

            MessageBox.Show("Compra realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
            this.Close();
        }
        // Cierra el form de el carrito y volvemos al principal
        private void LogoPicture_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            this.MenuPanel.Visible = true;
        }

        private void LogOutPanel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            if (_creatorForm != null)
            {
                _creatorForm.Dispose();
                _creatorForm.Close();
            }
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            this.MenuPanel.Visible = false;
        }

        private void LogoutPicture_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            if (_creatorForm != null)
            {
                _creatorForm.Dispose();
                _creatorForm.Close();
            }
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            if (_creatorForm != null)
            {
                _creatorForm.Dispose();
                _creatorForm.Close();
            }
        }
        #endregion Botones

        // ----- * * * MUESTRA LA FECHA Y HORA ACTUAL * * * -----
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // ----- * * * REGISTRA EL PEDIDO * * * -----
        private void RegistrarPedido()
        {
            string modelo = "";
            string marcas = "";
            decimal precio = 0;
            for (int i = 0; i < cartProducts.Count ; i++) 
            {
                for (int j = 0; j < cartProducts[i].Cantidad; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        modelo += cartProducts[i].Modelo;
                        marcas += cartProducts[i].Marca;
                    }
                    else
                    {
                        modelo += "\n" + cartProducts[i].Modelo;
                        marcas += "\n" + cartProducts[i].Marca;
                    }

                    precio += cartProducts[i].Precio;
                }
            }
            int usuario = cartProducts[0].Userid;

            // Eliminar 'id' de la lista de columnas
            string query = "INSERT INTO pedidos (productos, marcas, precio, id_usuario) " +
               "VALUES (@productos, @marcas, @precio, @id_usuario)";

            try
            {
                Connect();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // Eliminar el parámetro para id
                cmd.Parameters.AddWithValue("@productos", modelo);
                cmd.Parameters.AddWithValue("@marcas", marcas);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@id_usuario", usuario);
                cmd.ExecuteNonQuery();
                Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError: " + ex.Message);
                this.Disconnect();
            }

        }

        // ----- * * * ACTUALIZAR LABEL DE PRECIO * * * -----
        private void Product_PriceChanged(object sender, decimal priceChange)
        {
            this.Total += priceChange;
            totalLabel.Text = $"Total: ${this.Total:F2}";
        } 
    }
}
