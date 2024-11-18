namespace Transacciones_Finanzas
{
    partial class Balance_Cuenta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            BalanceTxt = new Label();
            menuStrip1 = new MenuStrip();
            transferirAOtraCuentaToolStripMenuItem = new ToolStripMenuItem();
            transferirAOtraCuentaDeBancoToolStripMenuItem = new ToolStripMenuItem();
            pagoDeServiciosToolStripMenuItem = new ToolStripMenuItem();
            serviciosToolStripMenuItem = new ToolStripMenuItem();
            médicosToolStripMenuItem = new ToolStripMenuItem();
            electricidadToolStripMenuItem = new ToolStripMenuItem();
            telecomunicacionesToolStripMenuItem = new ToolStripMenuItem();
            internetToolStripMenuItem = new ToolStripMenuItem();
            cableTVToolStripMenuItem = new ToolStripMenuItem();
            telefoníaCelularToolStripMenuItem = new ToolStripMenuItem();
            ocioToolStripMenuItem = new ToolStripMenuItem();
            suscripcionesToolStripMenuItem = new ToolStripMenuItem();
            streamingToolStripMenuItem = new ToolStripMenuItem();
            alimentosToolStripMenuItem = new ToolStripMenuItem();
            educaciToolStripMenuItem = new ToolStripMenuItem();
            Monto_TxtBox = new TextBox();
            Depositar_Btn = new Button();
            dateTimePicker1 = new DateTimePicker();
            imageList1 = new ImageList(components);
            Salir_Btn = new Button();
            Nombre_Txt = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            Consultar_BalanceBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 201);
            label1.Name = "label1";
            label1.Size = new Size(183, 26);
            label1.TabIndex = 0;
            label1.Text = "INGRESAR MONTO";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(327, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 2;
            label2.Text = "BALANCE ACTUAL:";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // BalanceTxt
            // 
            BalanceTxt.AutoSize = true;
            BalanceTxt.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BalanceTxt.ForeColor = Color.LightSeaGreen;
            BalanceTxt.Location = new Point(215, 135);
            BalanceTxt.Name = "BalanceTxt";
            BalanceTxt.Size = new Size(27, 25);
            BalanceTxt.TabIndex = 3;
            BalanceTxt.Text = "$";
            BalanceTxt.TextAlign = ContentAlignment.TopCenter;
            BalanceTxt.Click += BalanceTxt_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { transferirAOtraCuentaToolStripMenuItem, pagoDeServiciosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(412, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // transferirAOtraCuentaToolStripMenuItem
            // 
            transferirAOtraCuentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transferirAOtraCuentaDeBancoToolStripMenuItem });
            transferirAOtraCuentaToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            transferirAOtraCuentaToolStripMenuItem.Name = "transferirAOtraCuentaToolStripMenuItem";
            transferirAOtraCuentaToolStripMenuItem.Size = new Size(107, 20);
            transferirAOtraCuentaToolStripMenuItem.Text = "Transferencias";
            // 
            // transferirAOtraCuentaDeBancoToolStripMenuItem
            // 
            transferirAOtraCuentaDeBancoToolStripMenuItem.Name = "transferirAOtraCuentaDeBancoToolStripMenuItem";
            transferirAOtraCuentaDeBancoToolStripMenuItem.Size = new Size(273, 22);
            transferirAOtraCuentaDeBancoToolStripMenuItem.Text = "Transferir a otra cuenta de banco";
            transferirAOtraCuentaDeBancoToolStripMenuItem.Click += transferirAOtraCuentaDeBancoToolStripMenuItem_Click;
            // 
            // pagoDeServiciosToolStripMenuItem
            // 
            pagoDeServiciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serviciosToolStripMenuItem });
            pagoDeServiciosToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            pagoDeServiciosToolStripMenuItem.Name = "pagoDeServiciosToolStripMenuItem";
            pagoDeServiciosToolStripMenuItem.Size = new Size(122, 20);
            pagoDeServiciosToolStripMenuItem.Text = "Pago de Servicios";
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { médicosToolStripMenuItem, electricidadToolStripMenuItem, telecomunicacionesToolStripMenuItem, ocioToolStripMenuItem, alimentosToolStripMenuItem, educaciToolStripMenuItem });
            serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            serviciosToolStripMenuItem.Size = new Size(127, 22);
            serviciosToolStripMenuItem.Text = "Servicios";
            serviciosToolStripMenuItem.Click += serviciosToolStripMenuItem_Click;
            // 
            // médicosToolStripMenuItem
            // 
            médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            médicosToolStripMenuItem.Size = new Size(193, 22);
            médicosToolStripMenuItem.Text = "Médicos";
            médicosToolStripMenuItem.Click += médicosToolStripMenuItem_Click;
            // 
            // electricidadToolStripMenuItem
            // 
            electricidadToolStripMenuItem.Name = "electricidadToolStripMenuItem";
            electricidadToolStripMenuItem.Size = new Size(193, 22);
            electricidadToolStripMenuItem.Text = "Electricidad";
            electricidadToolStripMenuItem.Click += electricidadToolStripMenuItem_Click;
            // 
            // telecomunicacionesToolStripMenuItem
            // 
            telecomunicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { internetToolStripMenuItem, cableTVToolStripMenuItem, telefoníaCelularToolStripMenuItem });
            telecomunicacionesToolStripMenuItem.Name = "telecomunicacionesToolStripMenuItem";
            telecomunicacionesToolStripMenuItem.Size = new Size(193, 22);
            telecomunicacionesToolStripMenuItem.Text = "Telecomunicaciones";
            telecomunicacionesToolStripMenuItem.Click += telecomunicacionesToolStripMenuItem_Click;
            // 
            // internetToolStripMenuItem
            // 
            internetToolStripMenuItem.Name = "internetToolStripMenuItem";
            internetToolStripMenuItem.Size = new Size(173, 22);
            internetToolStripMenuItem.Text = "Internet";
            internetToolStripMenuItem.Click += internetToolStripMenuItem_Click;
            // 
            // cableTVToolStripMenuItem
            // 
            cableTVToolStripMenuItem.Name = "cableTVToolStripMenuItem";
            cableTVToolStripMenuItem.Size = new Size(173, 22);
            cableTVToolStripMenuItem.Text = "Cable TV";
            cableTVToolStripMenuItem.Click += cableTVToolStripMenuItem_Click;
            // 
            // telefoníaCelularToolStripMenuItem
            // 
            telefoníaCelularToolStripMenuItem.Name = "telefoníaCelularToolStripMenuItem";
            telefoníaCelularToolStripMenuItem.Size = new Size(173, 22);
            telefoníaCelularToolStripMenuItem.Text = "Telefonía/Celular";
            telefoníaCelularToolStripMenuItem.Click += telefoníaCelularToolStripMenuItem_Click;
            // 
            // ocioToolStripMenuItem
            // 
            ocioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { suscripcionesToolStripMenuItem, streamingToolStripMenuItem });
            ocioToolStripMenuItem.Name = "ocioToolStripMenuItem";
            ocioToolStripMenuItem.Size = new Size(193, 22);
            ocioToolStripMenuItem.Text = "Ocio";
            ocioToolStripMenuItem.Click += ocioToolStripMenuItem_Click;
            // 
            // suscripcionesToolStripMenuItem
            // 
            suscripcionesToolStripMenuItem.Name = "suscripcionesToolStripMenuItem";
            suscripcionesToolStripMenuItem.Size = new Size(156, 22);
            suscripcionesToolStripMenuItem.Text = "Suscripciones";
            suscripcionesToolStripMenuItem.Click += suscripcionesToolStripMenuItem_Click;
            // 
            // streamingToolStripMenuItem
            // 
            streamingToolStripMenuItem.Name = "streamingToolStripMenuItem";
            streamingToolStripMenuItem.Size = new Size(156, 22);
            streamingToolStripMenuItem.Text = "Streaming";
            streamingToolStripMenuItem.Click += streamingToolStripMenuItem_Click;
            // 
            // alimentosToolStripMenuItem
            // 
            alimentosToolStripMenuItem.Name = "alimentosToolStripMenuItem";
            alimentosToolStripMenuItem.Size = new Size(193, 22);
            alimentosToolStripMenuItem.Text = "Alimentos";
            alimentosToolStripMenuItem.Click += alimentosToolStripMenuItem_Click;
            // 
            // educaciToolStripMenuItem
            // 
            educaciToolStripMenuItem.Name = "educaciToolStripMenuItem";
            educaciToolStripMenuItem.Size = new Size(193, 22);
            educaciToolStripMenuItem.Text = "Educación";
            educaciToolStripMenuItem.Click += educaciToolStripMenuItem_Click;
            // 
            // Monto_TxtBox
            // 
            Monto_TxtBox.BackColor = SystemColors.ControlLight;
            Monto_TxtBox.Cursor = Cursors.IBeam;
            Monto_TxtBox.Location = new Point(112, 247);
            Monto_TxtBox.MaxLength = 13;
            Monto_TxtBox.Name = "Monto_TxtBox";
            Monto_TxtBox.Size = new Size(183, 22);
            Monto_TxtBox.TabIndex = 5;
            Monto_TxtBox.TextChanged += Monto_TxtBox_TextChanged;
            // 
            // Depositar_Btn
            // 
            Depositar_Btn.Cursor = Cursors.Hand;
            Depositar_Btn.FlatAppearance.BorderColor = Color.Blue;
            Depositar_Btn.Font = new Font("Verdana", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Depositar_Btn.ForeColor = SystemColors.Highlight;
            Depositar_Btn.Location = new Point(144, 290);
            Depositar_Btn.Name = "Depositar_Btn";
            Depositar_Btn.Size = new Size(120, 34);
            Depositar_Btn.TabIndex = 6;
            Depositar_Btn.Text = "DEPOSITAR";
            Depositar_Btn.UseVisualStyleBackColor = true;
            Depositar_Btn.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaption;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(12, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 22);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Salir_Btn
            // 
            Salir_Btn.BackColor = SystemColors.Menu;
            Salir_Btn.Cursor = Cursors.Hand;
            Salir_Btn.FlatAppearance.BorderColor = Color.Red;
            Salir_Btn.FlatStyle = FlatStyle.Popup;
            Salir_Btn.ForeColor = Color.Red;
            Salir_Btn.Location = new Point(325, 347);
            Salir_Btn.Name = "Salir_Btn";
            Salir_Btn.Size = new Size(75, 23);
            Salir_Btn.TabIndex = 8;
            Salir_Btn.Text = "SALIR";
            Salir_Btn.UseVisualStyleBackColor = false;
            Salir_Btn.Click += Salir_Btn_Click;
            // 
            // Nombre_Txt
            // 
            Nombre_Txt.AutoSize = true;
            Nombre_Txt.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Nombre_Txt.ForeColor = SystemColors.Highlight;
            Nombre_Txt.Location = new Point(12, 103);
            Nombre_Txt.Name = "Nombre_Txt";
            Nombre_Txt.Size = new Size(59, 14);
            Nombre_Txt.TabIndex = 9;
            Nombre_Txt.Text = "NOMBRE";
            Nombre_Txt.Visible = false;
            Nombre_Txt.Click += Nombre_Txt_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(97, 76);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 14);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "No. Cuenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 76);
            label4.Name = "label4";
            label4.Size = new Size(79, 14);
            label4.TabIndex = 11;
            label4.Text = "No.Cuenta:";
            // 
            // Consultar_BalanceBtn
            // 
            Consultar_BalanceBtn.BackColor = SystemColors.Menu;
            Consultar_BalanceBtn.Cursor = Cursors.Hand;
            Consultar_BalanceBtn.FlatAppearance.BorderColor = Color.Red;
            Consultar_BalanceBtn.FlatStyle = FlatStyle.Popup;
            Consultar_BalanceBtn.ForeColor = SystemColors.MenuHighlight;
            Consultar_BalanceBtn.Location = new Point(230, 347);
            Consultar_BalanceBtn.Name = "Consultar_BalanceBtn";
            Consultar_BalanceBtn.Size = new Size(89, 23);
            Consultar_BalanceBtn.TabIndex = 28;
            Consultar_BalanceBtn.Text = "CONSULTAR";
            Consultar_BalanceBtn.UseVisualStyleBackColor = false;
            Consultar_BalanceBtn.Click += Consultar_BalanceBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Balance_Cuenta
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightCyan;
            ClientSize = new Size(412, 382);
            ControlBox = false;
            Controls.Add(Consultar_BalanceBtn);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(Nombre_Txt);
            Controls.Add(Salir_Btn);
            Controls.Add(dateTimePicker1);
            Controls.Add(Depositar_Btn);
            Controls.Add(Monto_TxtBox);
            Controls.Add(BalanceTxt);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Balance_Cuenta";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BALANCE CUENTA";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label BalanceTxt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem transferirAOtraCuentaToolStripMenuItem;
        private ToolStripMenuItem pagoDeServiciosToolStripMenuItem;
        private ToolStripMenuItem transferirAOtraCuentaDeBancoToolStripMenuItem;
        private ToolStripMenuItem serviciosToolStripMenuItem;
        private ToolStripMenuItem médicosToolStripMenuItem;
        private ToolStripMenuItem electricidadToolStripMenuItem;
        private ToolStripMenuItem telecomunicacionesToolStripMenuItem;
        private ToolStripMenuItem internetToolStripMenuItem;
        private ToolStripMenuItem cableTVToolStripMenuItem;
        private ToolStripMenuItem telefoníaCelularToolStripMenuItem;
        private ToolStripMenuItem ocioToolStripMenuItem;
        private ToolStripMenuItem suscripcionesToolStripMenuItem;
        private ToolStripMenuItem streamingToolStripMenuItem;
        private ToolStripMenuItem alimentosToolStripMenuItem;
        private TextBox Monto_TxtBox;
        private Button Depositar_Btn;
        private DateTimePicker dateTimePicker1;
        private ImageList imageList1;
        private Button Salir_Btn;
        private Label Nombre_Txt;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button Consultar_BalanceBtn;
        private ToolStripMenuItem educaciToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}
