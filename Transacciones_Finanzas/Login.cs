using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transacciones_Finanzas
{
    public partial class Login : Form
    {
        private MySqlConnection _connection;
        public Login(MySqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public static int UsuarioID { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                UsuarioID = 0;
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open(); // Abrir la conexión si está cerrada
                }

                string correo = usuarioTxt.Text;
                string contraseña = contraseñaTxt.Text;
                string query = "SELECT No_Usuario, Nombres FROM Usuario WHERE Correo = @correo AND Contraseña = @contraseña";
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {

                            UsuarioID = reader.GetInt32("No_Usuario");
                            string nombreUsuario = reader.GetString("Nombres");
                            reader.Close();
                            MessageBox.Show($"Bienvenido al sistema, {nombreUsuario}");

                            Inicio inicioForm = new Inicio();
                            inicioForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrectas");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
    
