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
    public partial class PagoSrv : Form
    {
        public PagoSrv()
        {
            InitializeComponent();
        }

        private void Regresar_Btn_Click(object sender, EventArgs e)
        {
            Balance_Cuenta balance_Cuenta = new Balance_Cuenta();
            balance_Cuenta.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SrvMedicos srvMedicosForm = new SrvMedicos();
            srvMedicosForm.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SrvElectricidad srvElectricidadForm = new SrvElectricidad();
            srvElectricidadForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SrvTelecom srvTelecomForm = new SrvTelecom();
            srvTelecomForm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SrvOcio srvOcioForm = new SrvOcio();
            srvOcioForm.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SrvAlimentos srvAlimentosForm = new SrvAlimentos();
            srvAlimentosForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SrvEducacion srvEducacionForm = new SrvEducacion();
            srvEducacionForm.Show();
            this.Hide();
        }

        private void PagoSrv_Load(object sender, EventArgs e)
        {

        }
    }
}
