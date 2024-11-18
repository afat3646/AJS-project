using MySql.Data.MySqlClient;

namespace Transacciones_Finanzas

{

    public partial class Balance_Cuenta : Form
    {
        public Balance_Cuenta()
        {
            InitializeComponent();
            Monto_TxtBox.KeyPress += Monto_TxtBox_KeyPress;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void transferirAOtraCuentaDeBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transacciones transacciones = new Transacciones();
            transacciones.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parametros de la DB.
            string conexionString = "Server=localhost;Database=Control_Finanzas;User ID=root;Password=Fernaal1;";

            // Conexion DB.
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {

                try
                {
                    conexion.Open();
                    //Aqui se le cambio el valor de = 1 a @NoUsuario el cual ya est a declarado en el login asi que solo eso se cambia en cualquier string que se tenga que sacar informacion del usuario 
                    //Sigue esta recomendacion
                    string update_monto = "UPDATE Usuario SET Balance = Balance + @nuevoBalance WHERE No_Usuario = @NoUsuario";


                    using (MySqlCommand incrementar_monto = new MySqlCommand(update_monto, conexion))
                    {

                        if (string.IsNullOrWhiteSpace(Monto_TxtBox.Text))
                        {
                            MessageBox.Show("Por favor, llene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                             
                            // Sustituye los parámetros con los valores reales
                            incrementar_monto.Parameters.AddWithValue("@nuevoBalance", Convert.ToDouble(Monto_TxtBox.Text)); // El nuevo valor viene del TextBox Monto_TxtBox.

                            //Aqui se debe poner los parametros que se usaran en este caso el @NoUsuario para que lo tome del login el usuario ID el cual es el usuario activo con el que se inicia sesion 
                            //Sigue esta recomendacion
                            incrementar_monto.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                            // Ejecuta el comando
                            int rowsAffected = incrementar_monto.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                
                                string nuevo_balance = "SELECT Balance FROM Usuario WHERE No_Usuario = @NoUsuario";

                                using (MySqlCommand consultar_balanceact = new MySqlCommand(nuevo_balance, conexion))
                                {
                                    consultar_balanceact.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                                    object balance_actualizado = consultar_balanceact.ExecuteScalar();

                                    // Mostrar el valor actualizado en el Label
                                    BalanceTxt.Visible = true;
                                    BalanceTxt.Text = "$" + balance_actualizado.ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro.");
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

        private void Salir_Btn_Click(object sender, EventArgs e)
        {
            Inicio inicioForm = new Inicio();
            inicioForm.Show();
            this.Hide();
        }

        private void Consultar_BalanceBtn_Click(object sender, EventArgs e)
        {
            // Parametros de la DB.
            string conexionString = "Server=localhost;Database=Control_Finanzas;User ID=root;Password=Fernaal1;";

            // Conexion DB.
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {

                try
                {
                    conexion.Open();
                    string consulta_nombre = "SELECT Nombres FROM Usuario WHERE No_Usuario = @NoUsuario";
                    string consulta_balance = "SELECT Balance FROM Usuario WHERE No_Usuario = @NoUsuario";

                    using (MySqlCommand consultardatos = new MySqlCommand(consulta_nombre, conexion))
                    {
                        consultardatos.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                        object nombre = consultardatos.ExecuteScalar();

                        // Mostrar nombre en la etiqueta.
                        Nombre_Txt.Visible = true;
                        Nombre_Txt.Text = nombre.ToString();

                        using (MySqlCommand consultar_balance = new MySqlCommand(consulta_balance, conexion))
                        {
                            consultar_balance.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                            object balance = consultar_balance.ExecuteScalar();

                            // Mostrar el valor del balance en la etiqueta.
                            BalanceTxt.Visible = true;
                            BalanceTxt.Text = "$" + balance.ToString();

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

        private void Monto_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Monto_TxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número o si no es el carácter de control (como backspace).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // Si es así, cancela el evento para que el carácter no se ingrese en el TextBox.
                e.Handled = true;
            }
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoSrv SrvForm = new PagoSrv();
            SrvForm.Show();
            this.Hide();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SrvMedicos srvMedicosForm = new SrvMedicos();
            srvMedicosForm.Show();
            this.Hide();
        }

        private void electricidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SrvElectricidad srvElectricidadForm = new SrvElectricidad();
            srvElectricidadForm.Show();
            this.Hide();
        }

        private void telecomunicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SrvTelecom srvTelecomForm = new SrvTelecom();
            srvTelecomForm.Show();
            this.Hide();
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Internet internetForm = new Internet();
            internetForm.Show();
            this.Hide();
        }

        private void cableTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Internet cableTVForm = new Internet();
            cableTVForm.Show();
            this.Hide();
        }

        private void telefoníaCelularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefonia telefoniaForm = new Telefonia();
            telefoniaForm.Show();
            this.Hide();
        }

        private void ocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SrvOcio srvOcioForm = new SrvOcio();
            srvOcioForm.Show();
            this.Hide();
        }

        private void streamingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Streaming srvStreamingForm = new Streaming();
            srvStreamingForm.Show();
            this.Hide();
        }

        private void suscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gaming gamingForm = new Gaming();
            gamingForm.Show();
            this.Hide();
        }

        private void alimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SrvAlimentos srvAlimentosForm = new SrvAlimentos();
            srvAlimentosForm.Show();
            this.Hide();
        }

        private void educaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SrvEducacion srvEducacionForm = new SrvEducacion();
            srvEducacionForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Txt_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BalanceTxt_Click(object sender, EventArgs e)
        {

        }

        private void export_Click(object sender, EventArgs e)
        {
            Exportacion exportacion = new Exportacion();
            exportacion.Show();
            this.Hide();
        }
    }
}
