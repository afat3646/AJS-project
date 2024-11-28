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
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace Transacciones_Finanzas
{
    public partial class Exportacion : Form
    {
        public Exportacion()
        {
            InitializeComponent();
        }

        private void Exportacion_Load(object sender, EventArgs e)
        {


            comboBoxTablas.Items.Add(new KeyValuePair<string, string>("Transacciones", "Registro_Trans"));
            comboBoxTablas.Items.Add(new KeyValuePair<string, string>("Pagos de servicios", "V_Mov_PagoSrv"));
            comboBoxTablas.Items.Add(new KeyValuePair<string, string>("Guardadito", "Guardadito"));


            comboBoxTablas.DisplayMember = "Key";
            comboBoxTablas.ValueMember = "Value";
            comboBoxTablas.SelectedIndex = 0;
        }

        private void comboBoxTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conexionString = "Server=127.0.0.1;Database=Control_Finanzas;Uid=root;Pwd=roxellflores772;";


            if (comboBoxTablas.SelectedItem is KeyValuePair<string, string> selectedItem)
            {
                string nombreTablaReal = selectedItem.Value;

                if (nombreTablaReal != "Consolidado")
                {
                    using (MySqlConnection conexion = new MySqlConnection(conexionString))
                    {
                        try
                        {
                            conexion.Open();
                            string consulta = $"SELECT * FROM {nombreTablaReal}";
                            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
                            DataTable tablaDatos = new DataTable();
                            adapter.Fill(tablaDatos);

                            if (tablaDatos.Rows.Count > 0)
                            {
                                dataGridViewVista.DataSource = tablaDatos;
                            }
                            else
                            {
                                MessageBox.Show("No hay datos disponibles en esta tabla.", "Información");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al conectar con la Base de Datos: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {

            if (comboBoxTablas.SelectedItem is KeyValuePair<string, string> selectedItem)
            {
                string nombreTablaReal = selectedItem.Value;

                if (nombreTablaReal == "Consolidado")
                {
                    ExportarConsolidadoExcel();
                }
                else
                {
                    ExportarTablaSeleccionadaExcel(nombreTablaReal);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tabla antes de exportar.", "Advertencia");
            }
        }
        private void ExportarTablaSeleccionadaExcel(string nombreTablaReal)
        {
            string conexionString = "Server=127.0.0.1;Database=Control_Finanzas;Uid=root;Pwd=roxellflores772        ";
            using (MySqlConnection conexion = new MySqlConnection(conexionString))

            {
                conexion.Open();
                string consulta = $"SELECT * FROM {nombreTablaReal}";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
                DataTable tablaDatos = new DataTable();
                adapter.Fill(tablaDatos);

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = nombreTablaReal;


                for (int i = 1; i <= tablaDatos.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = tablaDatos.Columns[i - 1].ColumnName;
                }


                for (int i = 0; i < tablaDatos.Rows.Count; i++)
                {
                    for (int j = 0; j < tablaDatos.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = tablaDatos.Rows[i][j].ToString();
                    }
                }


                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    Title = "Guardar archivo Excel",
                    FileName = nombreTablaReal + ".xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados exitosamente a Excel.");
                }

                workbook.Close();
                excelApp.Quit();
            }

        }
        private void ExportarConsolidadoExcel()
        {
            string conexionString = "Server=127.0.0.1;Database=Control_Finanzas;Uid=root;Pwd=roxellflores772;";
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

            Dictionary<string, string> tablas = new Dictionary<string, string>
            {
            { "Transacciones", "Registro_Trans" },
            { "Pagos de servicios", "V_Mov_PagoSrv" },
            { "Guardadito", "Guardadito" }
            };

            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                conexion.Open();
                foreach (var tabla in tablas)
                {
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets.Add();
                    worksheet.Name = tabla.Key;

                    string consulta = $"SELECT * FROM {tabla.Value}";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
                    DataTable tablaDatos = new DataTable();
                    adapter.Fill(tablaDatos);


                    for (int i = 1; i <= tablaDatos.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i] = tablaDatos.Columns[i - 1].ColumnName;
                    }


                    for (int i = 0; i < tablaDatos.Rows.Count; i++)
                    {
                        for (int j = 0; j < tablaDatos.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = tablaDatos.Rows[i][j].ToString();
                        }
                    }
                }
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Guardar archivo Excel",
                FileName = "ConsolidadoDatos.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Datos exportados exitosamente a Excel.");
            }

            workbook.Close();
            excelApp.Quit();
        }
        private void dataGridViewVista_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
