using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones_Finanzas
{

    public static class ConexionDB
    {
        // Método para probar la conexión a la base de datos
        public static bool ProbarConexion()
        {
            string connectionString = "Server=localhost;Database=Control_Finanzas;User ID=root;Password=Fernaal1;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    return true; // Conexión exitosa
                    Console.WriteLine("Se pudo conectar a la base de datos correctamente");
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de fallo
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Conexión fallida
                Console.WriteLine("Error al conectar a la base de datos");
            }
        }

        public static MySqlConnection ObtenerConexion()
        {
            string connectionString = "Server=localhost;Database=Control_Finanzas;User ID=root;Password=Fernaal1;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open(); // Intenta abrir la conexión
                return connection; // Si es exitosa, devuelve la conexión abierta
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Si falla, devuelve null
            }
        }
    }
}
