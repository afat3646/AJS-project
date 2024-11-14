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
         //hola mundo 
        private void button1_Click(object sender, EventArgs e)
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open(); // Abrir la conexión si está cerrada
            }
            string correo = usuarioTxt.Text;
            string contraseña = contraseñaTxt.Text;
            string query = "SELECT * FROM Usuario WHERE Correo = @correo AND Contraseña = @contraseña";
            using (MySqlCommand command = new MySqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@contraseña", contraseña);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Bienvenido al sistema");
                        Inicio inicioForm = new Inicio();
                        inicioForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas");
                    }
                }
            }
        }
    }
}
