using MySql.Data.MySqlClient;

namespace Transacciones_Finanzas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static MySqlConnection conexion;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            conexion = ConexionDB.ObtenerConexion(); // Aquí obtenemos la conexión y la guardamos en la variable global

            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Conexión exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pasamos la conexión al formulario Login
                Application.Run(new Login(conexion));
                Console.WriteLine("Se pudo realizar la conección correctamente");
            }
            else
            {
                MessageBox.Show("Error al conectar con la base de datos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // Cerrar la aplicación si la conexión falla
                Console.WriteLine("No se pudo conectar a la base de datos");
                Console.WriteLine("Cerrando aplicación");
            }

        }
    }
}