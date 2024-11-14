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

namespace Transacciones_Finanzas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            string conexionString = "Server=localhost;Database=Control_Finanzas;User ID=root;Password=Fernaal1;";

            // Conexion DB.
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {

                try
                {
                    conexion.Open();
                    string consulta_nombre = "SELECT Nombres FROM Usuario WHERE No_Usuario = 1";


                    using (MySqlCommand consultardatos = new MySqlCommand(consulta_nombre, conexion))
                    {
                        object nombre = consultardatos.ExecuteScalar();

                        // Mostrar nombre en la etiqueta.
                        Nombre_Txt.Visible = true;
                        Nombre_Txt.Text = nombre.ToString();
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
    }
}
