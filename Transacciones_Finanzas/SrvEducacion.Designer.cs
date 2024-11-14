namespace Transacciones_Finanzas
{
    partial class SrvEducacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SrvEducacion));
            ConceptoTxtBox = new RichTextBox();
            label5 = new Label();
            Pagar_Btn = new Button();
            Monto_TxtBox = new TextBox();
            label16 = new Label();
            Categoria_Txt = new Label();
            label13 = new Label();
            Regresar_Btn = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ConceptoTxtBox
            // 
            ConceptoTxtBox.Cursor = Cursors.IBeam;
            ConceptoTxtBox.Location = new Point(235, 101);
            ConceptoTxtBox.Name = "ConceptoTxtBox";
            ConceptoTxtBox.Size = new Size(139, 106);
            ConceptoTxtBox.TabIndex = 66;
            ConceptoTxtBox.Text = "";
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 101);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 65;
            label5.Text = "Concepto:";
            // 
            // Pagar_Btn
            // 
            Pagar_Btn.BackColor = SystemColors.Menu;
            Pagar_Btn.Cursor = Cursors.Hand;
            Pagar_Btn.FlatAppearance.BorderColor = Color.Red;
            Pagar_Btn.FlatStyle = FlatStyle.Popup;
            Pagar_Btn.ForeColor = Color.DarkGreen;
            Pagar_Btn.Location = new Point(236, 213);
            Pagar_Btn.Name = "Pagar_Btn";
            Pagar_Btn.Size = new Size(59, 23);
            Pagar_Btn.TabIndex = 64;
            Pagar_Btn.Text = "PAGAR";
            Pagar_Btn.UseVisualStyleBackColor = false;
            Pagar_Btn.Click += Pagar_Btn_Click;
            // 
            // Monto_TxtBox
            // 
            Monto_TxtBox.BackColor = SystemColors.ControlLight;
            Monto_TxtBox.Cursor = Cursors.IBeam;
            Monto_TxtBox.Location = new Point(85, 212);
            Monto_TxtBox.Name = "Monto_TxtBox";
            Monto_TxtBox.Size = new Size(145, 23);
            Monto_TxtBox.TabIndex = 63;
            // 
            // label16
            // 
            label16.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(9, 213);
            label16.Name = "label16";
            label16.Size = new Size(70, 23);
            label16.TabIndex = 62;
            label16.Text = "MONTO";
            // 
            // Categoria_Txt
            // 
            Categoria_Txt.Font = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Categoria_Txt.ForeColor = Color.Brown;
            Categoria_Txt.Location = new Point(236, 75);
            Categoria_Txt.Name = "Categoria_Txt";
            Categoria_Txt.Size = new Size(139, 23);
            Categoria_Txt.TabIndex = 61;
            Categoria_Txt.Text = "CATEGORIA";
            Categoria_Txt.Visible = false;
            // 
            // label13
            // 
            label13.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(143, 75);
            label13.Name = "label13";
            label13.Size = new Size(95, 23);
            label13.TabIndex = 60;
            label13.Text = "Categoria:";
            // 
            // Regresar_Btn
            // 
            Regresar_Btn.BackColor = SystemColors.Menu;
            Regresar_Btn.Cursor = Cursors.Hand;
            Regresar_Btn.FlatAppearance.BorderColor = Color.Red;
            Regresar_Btn.FlatStyle = FlatStyle.Popup;
            Regresar_Btn.ForeColor = Color.Red;
            Regresar_Btn.Location = new Point(300, 213);
            Regresar_Btn.Name = "Regresar_Btn";
            Regresar_Btn.Size = new Size(75, 23);
            Regresar_Btn.TabIndex = 59;
            Regresar_Btn.Text = "REGRESAR";
            Regresar_Btn.UseVisualStyleBackColor = false;
            Regresar_Btn.Click += Regresar_Btn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 38);
            label2.Name = "label2";
            label2.Size = new Size(249, 23);
            label2.TabIndex = 55;
            label2.Text = "Seleccione un servicio:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            //pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 23);
            label1.TabIndex = 57;
            label1.Text = "SERVICIOS EDUCATIVOS";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(14, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 139);
            panel1.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 112);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 12;
            label3.Text = "PAGO COLEGIATURA";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            //pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // SrvEducacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(380, 243);
            ControlBox = false;
            Controls.Add(ConceptoTxtBox);
            Controls.Add(label5);
            Controls.Add(Pagar_Btn);
            Controls.Add(Monto_TxtBox);
            Controls.Add(label16);
            Controls.Add(Categoria_Txt);
            Controls.Add(label13);
            Controls.Add(Regresar_Btn);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SrvEducacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SrvEducacion";
            Load += SrvEducacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ConceptoTxtBox;
        private Label label5;
        private Button Pagar_Btn;
        private TextBox Monto_TxtBox;
        private Label label16;
        private Label Categoria_Txt;
        private Label label13;
        private Button Regresar_Btn;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox2;
    }
}