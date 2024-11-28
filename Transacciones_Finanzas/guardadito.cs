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
    public partial class guardadito : Form
    {
        public guardadito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guardadito_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            DateTime fechaHoraEntrada = dateTimePicker1.Value;
            MessageBox.Show("Fecha y hora de entrada: " + fechaHoraEntrada.ToString("g"));
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            string conexionString = "Server=127.0.0.1;Database=Control_Finanzas;Uid=root;Pwd=roxellflores772;";

            // Conexion DB.
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {

                try
                {
                    conexion.Open();
                    string consulta_balance = "SELECT Balance FROM Usuario WHERE No_Usuario = @NoUsuario";

                    using (MySqlCommand consultar_balanceact = new MySqlCommand(consulta_balance, conexion))
                    {
                        consultar_balanceact.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                        object balance_actualizado = consultar_balanceact.ExecuteScalar();


                        // Mostrar el valor actualizado en el Label
                        balanceTxt.Visible = true;
                        balanceTxt.Text = "$" + balance_actualizado.ToString();
                    }
                    string consulta_guardadito = "SELECT Monto, Fecha_Fin FROM Guardadito WHERE No_Usuario = @NoUsuario LIMIT 1";

                    using (MySqlCommand consultar_guardadito = new MySqlCommand(consulta_guardadito, conexion))
                    {

                        consultar_guardadito.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                        using (MySqlDataReader reader = consultar_guardadito.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dineroGuardadoTxt.Text = "$" + reader.GetDouble("Monto").ToString();
                                fechaDispoTxt.Text = reader.GetDateTime("Fecha_Fin").ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                dineroGuardadoTxt.Text = "$0.00";
                                fechaDispoTxt.Text = "No disponible";
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

        private void Guardar_Click(object sender, EventArgs e)
        {
            double montoAGuardar;

            // Validar que el monto ingresado es un número y es positivo
            if (double.TryParse(textBox1.Text, out montoAGuardar) && montoAGuardar > 0)
            {
                string conexionString = "Server=localhost;Database=Control_Finanzas;User ID=root;Password=Fernaal1;";
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    try
                    {
                        conexion.Open();

                        // Obtener el balance actual del usuario
                        string consulta_balance = "SELECT Balance FROM Usuario WHERE No_Usuario = @NoUsuario";
                        double balanceActual;
                        using (MySqlCommand consultar_balance = new MySqlCommand(consulta_balance, conexion))
                        {
                            consultar_balance.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                            object result = consultar_balance.ExecuteScalar();
                            balanceActual = Convert.ToDouble(result);
                        }

                        // Verificar si el usuario tiene suficiente balance
                        if (balanceActual >= montoAGuardar)
                        {
                            // Restar el monto del balance del usuario
                            string actualizar_balance = "UPDATE Usuario SET Balance = Balance - @Monto WHERE No_Usuario = @NoUsuario";
                            using (MySqlCommand actualizarBalanceCmd = new MySqlCommand(actualizar_balance, conexion))
                            {
                                actualizarBalanceCmd.Parameters.AddWithValue("@Monto", montoAGuardar);
                                actualizarBalanceCmd.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                                actualizarBalanceCmd.ExecuteNonQuery();
                            }

                            // Insertar el monto en el guardadito con una fecha de disponibilidad a 5 días
                            DateTime fechaInicio = DateTime.Now;
                            DateTime fechaFin = fechaInicio.AddDays(5);
                            string insertar_guardadito = "INSERT INTO Guardadito (No_Usuario, Monto, Fecha_Inicio, Fecha_Fin) VALUES (@NoUsuario, @Monto, @FechaInicio, @FechaFin)";
                            using (MySqlCommand insertarGuardaditoCmd = new MySqlCommand(insertar_guardadito, conexion))
                            {
                                insertarGuardaditoCmd.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                                insertarGuardaditoCmd.Parameters.AddWithValue("@Monto", montoAGuardar);
                                insertarGuardaditoCmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                                insertarGuardaditoCmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                                insertarGuardaditoCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Dinero guardado exitosamente en el guardadito. Monto: $" + montoAGuardar);

                            // Refrescar los datos en el formulario después de guardar
                            consultar_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No tienes suficiente balance para guardar esa cantidad.");
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
            else
            {
                MessageBox.Show("Por favor, ingresa un monto válido.");
            }
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            string conexionString = "Server=127.0.0.1;Database=Control_Finanzas;Uid=root;Pwd=roxellflores772;";

            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string consulta_guardadito = "SELECT Monto, Fecha_Fin FROM Guardadito WHERE No_Usuario = @NoUsuario LIMIT 1";
                    double montoGuardado = 0;
                    DateTime fechaFin;
                    using (MySqlCommand cmd = new MySqlCommand(consulta_guardadito, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("No hay dinero guardado disponible para retiro.");
                                return;
                            }

                            montoGuardado = reader.GetDouble("Monto");
                            fechaFin = reader.GetDateTime("Fecha_Fin");
                        }
                    }
                    if (DateTime.Now < fechaFin)
                    {
                        MessageBox.Show("El dinero guardado no estará disponible hasta el " + fechaFin.ToString("dd/MM/yyyy"));
                        return;
                    }
                    string actualizar_balance = "UPDATE Usuario SET Balance = Balance + @Monto WHERE No_Usuario = @NoUsuario";
                    using (MySqlCommand actualizarBalanceCmd = new MySqlCommand(actualizar_balance, conexion))
                    {
                        actualizarBalanceCmd.Parameters.AddWithValue("@Monto", montoGuardado);
                        actualizarBalanceCmd.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                        actualizarBalanceCmd.ExecuteNonQuery();
                    }

                    // Eliminar el registro de guardadito
                    string eliminar_guardadito = "DELETE FROM Guardadito WHERE No_Usuario = @NoUsuario LIMIT 1";
                    using (MySqlCommand eliminarGuardaditoCmd = new MySqlCommand(eliminar_guardadito, conexion))
                    {
                        eliminarGuardaditoCmd.Parameters.AddWithValue("@NoUsuario", Login.UsuarioID);
                        eliminarGuardaditoCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dinero retirado del guardadito exitosamente. Monto: $" + montoGuardado);

                    // Refrescar los datos en el formulario después de retirar
                    consultar_Click(sender, e);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Inicio inicioForm = new Inicio();
            inicioForm.Show();
            this.Hide();
        }
    }
}
