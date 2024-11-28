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
    public partial class SrvOcio : Form
    {
        public SrvOcio()
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
            Streaming streamingForm = new Streaming();
            streamingForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Gaming gamingForm = new Gaming();
            gamingForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SrvOcio_Load(object sender, EventArgs e)
        {

        }
    }
}
