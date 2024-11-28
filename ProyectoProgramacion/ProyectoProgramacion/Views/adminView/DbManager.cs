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
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<AdminProduct> GetAllProducts()
        {
            List<AdminProduct> products = new List<AdminProduct>();
            
            try
            {
                string query = "SELECT * FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    AdminProduct product = new AdminProduct(
                        reader.GetInt32("id"),
                        reader.GetString("nombre"),
                        reader.GetString("descripcion"),
                        reader.GetString("imagen"),
                        reader.GetString("marca"),
                        reader.GetString("colores"),
                        reader.GetString("tallas"),
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
    }
}
