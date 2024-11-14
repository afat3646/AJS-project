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
    public partial class Gaming : Form
    {
        public Gaming()
        {
            InitializeComponent();
            Monto_TxtBox.KeyPress += Monto_TxtBox_KeyPress;
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

        private void Regresar_Btn_Click(object sender, EventArgs e)
        {
            SrvOcio srvOcioForm = new SrvOcio();
            srvOcioForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Categoria_Txt.Visible = true;
            Categoria_Txt.Text = "XBOX GAME PASS";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Categoria_Txt.Visible = true;
            Categoria_Txt.Text = "PS PLUS";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Categoria_Txt.Visible = true;
            Categoria_Txt.Text = "SWITCH ONLINE";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Categoria_Txt.Visible = true;
            Categoria_Txt.Text = "EA PLAY";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Categoria_Txt.Visible = true;
            Categoria_Txt.Text = "EPIC GAMES";
        }

        private void Pagar_Btn_Click(object sender, EventArgs e)
        {
            // Parametros de la DB.
            string conexionString = "Server=localhost;Database=Control_Finanzas;User ID=root;Password=Fernaal1;";

            // Conexion DB.
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {

                try
                {
                    conexion.Open();
                    string pago_srvgaming = "UPDATE Usuario SET Balance = Balance - @MontoSrvGaming WHERE No_Usuario = 1";
                    string insert_registro = "INSERT INTO Registro_PagoSrv (No_Cuenta, Categoria, Servicio, Concepto, Monto) VALUES (@No_Cuenta, @CategoriaTxt, @ServicioTxt, @ConceptoTxt, @Monto_Pago)";

                    using (MySqlCommand restar_monto = new MySqlCommand(pago_srvgaming, conexion))
                    {
                        //Validar que los TextBoxes existen.
                        if (string.IsNullOrWhiteSpace(ConceptoTxtBox.Text) || string.IsNullOrWhiteSpace(Monto_TxtBox.Text))
                        {
                            MessageBox.Show("Por favor, llene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {
                            using (MySqlCommand insertar_registro_pagosrv = new MySqlCommand(insert_registro, conexion))
                            {
                                insertar_registro_pagosrv.Parameters.AddWithValue("@No_Cuenta", 1);
                                insertar_registro_pagosrv.Parameters.AddWithValue("@CategoriaTxt", "GAMING");
                                insertar_registro_pagosrv.Parameters.AddWithValue("@ServicioTxt", Categoria_Txt.Text);
                                insertar_registro_pagosrv.Parameters.AddWithValue("@ConceptoTxt", ConceptoTxtBox.Text);
                                insertar_registro_pagosrv.Parameters.AddWithValue("@Monto_Pago", Convert.ToDouble(Monto_TxtBox.Text));

                                insertar_registro_pagosrv.ExecuteNonQuery();
                            }

                            // Sustituye los parámetros con los valores reales.
                            restar_monto.Parameters.AddWithValue("@MontoSrvGaming", Convert.ToDouble(Monto_TxtBox.Text)); // El nuevo valor viene del TextBox Monto_TxtBox.

                            int rowsAffected = restar_monto.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Mostrar el estado de la transferencia.
                                MessageBox.Show("Pago realizado exitosamente", "STATUS PAGO", MessageBoxButtons.OK);
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

        private void Gaming_Load(object sender, EventArgs e)
        {

        }
    }
}
