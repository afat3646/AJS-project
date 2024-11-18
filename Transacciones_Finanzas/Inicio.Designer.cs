namespace Transacciones_Finanzas
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            transacciones = new Button();
            estadoDeCuenta = new Button();
            Nombre_Txt = new Label();
            ActDirecBtn = new Button();
            PagoSrvBTN = new Button();
            guardaditoBTN = new Button();
            logoutBtn = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 67);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 0;
            label1.Text = "Hola seas bienvenido:";
            // 
            // transacciones
            // 
            transacciones.BackColor = SystemColors.Menu;
            transacciones.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            transacciones.ForeColor = SystemColors.MenuHighlight;
            transacciones.Location = new Point(153, 215);
            transacciones.Name = "transacciones";
            transacciones.Size = new Size(98, 44);
            transacciones.TabIndex = 1;
            transacciones.Text = "Transferir";
            transacciones.UseVisualStyleBackColor = false;
            transacciones.Click += transacciones_Click;
            // 
            // estadoDeCuenta
            // 
            estadoDeCuenta.BackColor = SystemColors.Menu;
            estadoDeCuenta.ForeColor = SystemColors.MenuHighlight;
            estadoDeCuenta.Location = new Point(21, 215);
            estadoDeCuenta.Name = "estadoDeCuenta";
            estadoDeCuenta.Size = new Size(97, 44);
            estadoDeCuenta.TabIndex = 2;
            estadoDeCuenta.Text = "Estado de cuenta";
            estadoDeCuenta.UseVisualStyleBackColor = false;
            estadoDeCuenta.Click += estadoDeCuenta_Click;
            // 
            // Nombre_Txt
            // 
            Nombre_Txt.AutoSize = true;
            Nombre_Txt.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Nombre_Txt.Location = new Point(27, 109);
            Nombre_Txt.Name = "Nombre_Txt";
            Nombre_Txt.Size = new Size(0, 30);
            Nombre_Txt.TabIndex = 3;
            // 
            // ActDirecBtn
            // 
            ActDirecBtn.Font = new Font("MS PGothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ActDirecBtn.Location = new Point(283, 12);
            ActDirecBtn.Name = "ActDirecBtn";
            ActDirecBtn.Size = new Size(122, 45);
            ActDirecBtn.TabIndex = 4;
            ActDirecBtn.Text = "Detalle de cuenta";
            ActDirecBtn.UseVisualStyleBackColor = true;
            ActDirecBtn.Click += ActDirecBtn_Click;
            // 
            // PagoSrvBTN
            // 
            PagoSrvBTN.BackColor = SystemColors.Menu;
            PagoSrvBTN.ForeColor = SystemColors.MenuHighlight;
            PagoSrvBTN.Location = new Point(21, 295);
            PagoSrvBTN.Name = "PagoSrvBTN";
            PagoSrvBTN.Size = new Size(97, 44);
            PagoSrvBTN.TabIndex = 5;
            PagoSrvBTN.Text = "Pago de servicios";
            PagoSrvBTN.UseVisualStyleBackColor = false;
            PagoSrvBTN.Click += PagoSrvBTN_Click;
            // 
            // guardaditoBTN
            // 
            guardaditoBTN.BackColor = SystemColors.Menu;
            guardaditoBTN.ForeColor = SystemColors.MenuHighlight;
            guardaditoBTN.Location = new Point(153, 295);
            guardaditoBTN.Name = "guardaditoBTN";
            guardaditoBTN.Size = new Size(98, 44);
            guardaditoBTN.TabIndex = 6;
            guardaditoBTN.Text = "Guardadito";
            guardaditoBTN.UseVisualStyleBackColor = false;
            guardaditoBTN.Click += guardaditoBTN_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.ForeColor = Color.Red;
            logoutBtn.Location = new Point(156, 360);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(95, 23);
            logoutBtn.TabIndex = 7;
            logoutBtn.Text = "Cerrar aplicacion";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(417, 422);
            Controls.Add(logoutBtn);
            Controls.Add(guardaditoBTN);
            Controls.Add(PagoSrvBTN);
            Controls.Add(ActDirecBtn);
            Controls.Add(Nombre_Txt);
            Controls.Add(estadoDeCuenta);
            Controls.Add(transacciones);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button transacciones;
        private Button estadoDeCuenta;
        private Label Nombre_Txt;
        private Button ActDirecBtn;
        private Button PagoSrvBTN;
        private Button guardaditoBTN;
        private Button logoutBtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}