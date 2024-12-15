using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Text.RegularExpressions;


namespace adminView
{
    public class DbManager
    {
        private MySqlConnection connection;

        public DbManager()
        {
            this.Connect();
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=tenisdb; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                // Primero verificamos el número total de registros
                string countQuery = "SELECT COUNT(*) FROM productos";
                MySqlCommand countCmd = new MySqlCommand(countQuery, connection);
                int totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                // Solo eliminamos si hay más de 6 registros
                if (totalRecords > 6)
                {
                    string deleteQuery = $"DELETE from productos WHERE id = {id}";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                    deleteCmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar. Debe haber al menos 7 registros.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                this.Disconnect();
            }
        }

        public void InsertProduct(int id, string modelo, string descripcion, string imagen1, string imagen2,
            string imagen3, string imagen4, string imagen5, string marca, int precio, int stock, int novedad, float descuento)
        {
            string query = "INSERT INTO productos (id, modelo, descripcion, imagen1, imagen2,imagen3,imagen4,imagen5, marca, precio, stock, novedad, descuento) " +
                           "VALUES (@id, @modelo, @descripcion, @imagen1, @imagen2, @imagen3, @imagen4, @imagen5, @marca, @precio, @stock, @novedad, @descuento)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                // Agregar parámetros
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@imagen1", imagen1);
                cmd.Parameters.AddWithValue("@imagen2", imagen2);
                cmd.Parameters.AddWithValue("@imagen3", imagen3);
                cmd.Parameters.AddWithValue("@imagen4", imagen4);
                cmd.Parameters.AddWithValue("@imagen5", imagen5);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@novedad", novedad);
                cmd.Parameters.AddWithValue("@descuento", descuento);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError: " + ex.Message);
                this.Disconnect();
            }
        }

        public List<AdminProduct> GetAllProducts()
        {
            List<AdminProduct> products = new List<AdminProduct>();
            
            try
            {
                string query = "SELECT * FROM productos ORDER BY stock DESC";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    AdminProduct product = new AdminProduct(
                        reader.GetInt32("id"),
                        reader.GetString("modelo"),
                        reader.GetString("descripcion"),
                        reader.GetString("imagen1"),
                        reader.GetString("marca"),
                        reader.GetInt32("precio"),
                        reader.GetInt32("stock")
                    );
                    products.Add(product);

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return products;
        }

        public List<string> GetSummaryData()
        {
            List<string> data = new List<string>();
            int totalStock = 0;
            int totalPrice = 0;
            int totalCount = 0;

            try
            {
                string query = "SELECT SUM(stock) AS totalStock FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y obtener el resultado
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalStock = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la suma de stock: " + ex.Message);
                this.Disconnect();
            }


            try
            {
                string query = "SELECT SUM(precio) AS totalPrice FROM pedidos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y obtener el resultado
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalPrice = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la suma de price: " + ex.Message);
                this.Disconnect();
            }

            try
            {
                string query = "SELECT COUNT(*) FROM pedidos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y obtener el resultado
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalCount = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la suma de price: " + ex.Message);
                this.Disconnect();
            }

            data.Add(totalPrice.ToString());
            data.Add(totalCount.ToString());
            data.Add(totalStock.ToString());

            return data;
        }

        public Dictionary<string, int> GetInfoMarca()
        {
            string connectionString = "Server=localhost;Database=tenisdb;Uid=root;Pwd=;";
            var categories = new Dictionary<string, int>(); // Diccionario para almacenar los conteos

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // Ejecutar consulta
                    string query = "SELECT marcas FROM pedidos";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Leer el valor de la columna "marcas"
                                string marcas = reader.GetString(0);

                                // Dividir el contenido de la columna usando Regex
                                string[] marcasArray = Regex.Split(marcas, @"[\r\n]+");

                                foreach (string marca in marcasArray)
                                {
                                    if (categories.ContainsKey(marca))
                                    {
                                        categories[marca]++;
                                    }
                                    else
                                    {
                                        categories[marca] = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return categories;
        }
    }
}
