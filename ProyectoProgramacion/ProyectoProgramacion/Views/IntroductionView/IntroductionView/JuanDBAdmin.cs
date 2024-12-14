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
        private string cadenaConexion = "Server=localhost;Database=base_de_datos;Uid=root;Pwd=;";
        public bool verificar(string username, string password)
        {
            if (username == null || password == null)
            {
                throw new ArgumentNullException("Campos no valida, favor de insertar lo que se indica");
            }
            // Intenta conectarse  y consultar la base de datos
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Crea consulta parametrizada para evitar inyeccion SQL
                    string consulta = "SELECT COUNT(*) FROM pruebas WHERE Usuario = @username AND Contraseña = @password";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        Console.WriteLine(consulta);
                        // Se agregan los parametros
                        comando.Parameters.AddWithValue("@username", username);
                        comando.Parameters.AddWithValue("@password", password);

                        // Se ejecuta una consulta y se verifica si existe el usuario
                        int count = Convert.ToInt32(comando.ExecuteScalar());
                        return count > 0; // Si se encuentra al menos una coincidencia, regresa true
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar en la base de datos: " + ex.Message);
                return false;
            }
        }
    }
}
