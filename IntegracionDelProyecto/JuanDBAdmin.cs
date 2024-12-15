using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionView
{
    public class JuanDBAdmin
    {
        private string cadenaConexion = "Server=localhost;Database=tenisdb;Uid=root;Pwd=;";
        public int verificar(string username, string password)
        {
            if (username == null || password == null)
            {
                throw new ArgumentNullException("Campos no válidos, favor de insertar lo que se indica");
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT id FROM users WHERE user_login = @username AND password = @password";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@username", username);
                        comando.Parameters.AddWithValue("@password", password);

                        object result = comando.ExecuteScalar();
                        if (result != null)
                        {
                            int id = Convert.ToInt32(result);
                            return id;
                        }
                        else
                        {
                            // No se encontró ningún registro coincidente
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar en la base de datos: " + ex.Message);
                return -1;
            }
        }

        public string getName(int id)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT user FROM users WHERE id = @id";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);

                        return comando.ExecuteScalar()?.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el nombre: " + ex.Message);
                return "-1";
            }
        }
    }
}
