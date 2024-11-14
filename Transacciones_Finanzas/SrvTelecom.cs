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
    public partial class SrvTelecom : Form
    {
        public SrvTelecom()
        {
            InitializeComponent();
        }

        private void Regresar_Btn_Click(object sender, EventArgs e)
        {
            PagoSrv pagoSrvForm = new PagoSrv();
            pagoSrvForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Internet internetForm = new Internet();
            internetForm.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Internet cableTVForm = new Internet();
            cableTVForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Telefonia telefoniaForm = new Telefonia();
            telefoniaForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
