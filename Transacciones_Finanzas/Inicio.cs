using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Transacciones_Finanzas
{
    
    public partial class Inicio : Form
    {

        public static class UsuarioActivo
        {

            public static int No_Usuario { get; set; }
        }

        public Inicio()
        {
            if (Login.UsuarioID == 0)
            {
                MessageBox.Show("No hay un usuario activo.");
                this.Close();
                return;
            }

            InitializeComponent();
            string conexionString = "Server=127.0.0.1;Database=Control_Finanzas;Uid=root;Pwd=roxellflores772;";

            // Conexion DB.
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                conexion.Open();

                try
                {
                    

                    string consultarUsuario = "SELECT * FROM Usuario WHERE No_Usuario = @NoUsuario";
                    using (MySqlCommand command = new MySqlCommand(consultarUsuario, conexion))
                    {
                        command.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Aquí puedes obtener y mostrar otros datos del usuario
                                string nombreUsuario = reader.GetString("Nombres");
                                Nombre_Txt.Visible = true;
                                Nombre_Txt.Text = "HOLA SEAS BIENVENIDO: " + nombreUsuario;
                            }

                        }

                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la Base de Datos: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }



        private void transacciones_Click(object sender, EventArgs e)
        {
            Transacciones transaccionesFrom = new Transacciones();
            transaccionesFrom.Show();
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void estadoDeCuenta_Click(object sender, EventArgs e)
        {
            Balance_Cuenta balance_Cuentaform = new Balance_Cuenta();
            balance_Cuentaform.Show();
            this.Close();
        }

        private void ActDirecBtn_Click(object sender, EventArgs e)
        {

        }

        private void PagoSrvBTN_Click(object sender, EventArgs e)
        {
            PagoSrv pagoSrvForm = new PagoSrv();
            pagoSrvForm.Show();
            this.Hide();
        }

        private void guardaditoBTN_Click(object sender, EventArgs e)
        {
            guardadito guardaditoForm = new guardadito();
            guardaditoForm.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
