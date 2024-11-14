namespace Transacciones_Finanzas
{
    partial class SrvMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SrvMedicos));
            Regresar_Btn = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label3 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            Monto_TxtBox = new TextBox();
            label16 = new Label();
            Categoria_Txt = new Label();
            label13 = new Label();
            Pagar_Btn = new Button();
            label5 = new Label();
            ConceptoTxtBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Regresar_Btn
            // 
            Regresar_Btn.BackColor = SystemColors.Menu;
            Regresar_Btn.Cursor = Cursors.Hand;
            Regresar_Btn.FlatAppearance.BorderColor = Color.Red;
            Regresar_Btn.FlatStyle = FlatStyle.Popup;
            Regresar_Btn.ForeColor = Color.Red;
            Regresar_Btn.Location = new Point(299, 302);
            Regresar_Btn.Name = "Regresar_Btn";
            Regresar_Btn.Size = new Size(75, 23);
            Regresar_Btn.TabIndex = 34;
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
            label2.TabIndex = 30;
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
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(217, 23);
            label1.TabIndex = 32;
            label1.Text = "SERVICIOS MÉDICOS";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(23, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 140);
            panel1.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(115, 115);
            label11.Name = "label11";
            label11.Size = new Size(101, 15);
            label11.TabIndex = 20;
            label11.Text = "INTERVENCIONES";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(242, 115);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 19;
            label10.Text = "CONSULTAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 115);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "INSUMOS";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            //pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(115, 6);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(101, 106);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            //pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(225, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(101, 106);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            //pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Monto_TxtBox
            // 
            Monto_TxtBox.BackColor = SystemColors.ControlLight;
            Monto_TxtBox.Cursor = Cursors.IBeam;
            Monto_TxtBox.Location = new Point(84, 301);
            Monto_TxtBox.Name = "Monto_TxtBox";
            Monto_TxtBox.Size = new Size(145, 23);
            Monto_TxtBox.TabIndex = 38;
            // 
            // label16
            // 
            label16.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(8, 302);
            label16.Name = "label16";
            label16.Size = new Size(70, 23);
            label16.TabIndex = 37;
            label16.Text = "MONTO";
            // 
            // Categoria_Txt
            // 
            Categoria_Txt.Font = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Categoria_Txt.ForeColor = Color.Brown;
            Categoria_Txt.Location = new Point(101, 210);
            Categoria_Txt.Name = "Categoria_Txt";
            Categoria_Txt.Size = new Size(127, 23);
            Categoria_Txt.TabIndex = 36;
            Categoria_Txt.Text = "CATEGORIA";
            Categoria_Txt.Visible = false;
            // 
            // label13
            // 
            label13.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(8, 210);
            label13.Name = "label13";
            label13.Size = new Size(95, 23);
            label13.TabIndex = 35;
            label13.Text = "Categoria:";
            // 
            // Pagar_Btn
            // 
            Pagar_Btn.BackColor = SystemColors.Menu;
            Pagar_Btn.Cursor = Cursors.Hand;
            Pagar_Btn.FlatAppearance.BorderColor = Color.Red;
            Pagar_Btn.FlatStyle = FlatStyle.Popup;
            Pagar_Btn.ForeColor = Color.DarkGreen;
            Pagar_Btn.Location = new Point(235, 302);
            Pagar_Btn.Name = "Pagar_Btn";
            Pagar_Btn.Size = new Size(59, 23);
            Pagar_Btn.TabIndex = 40;
            Pagar_Btn.Text = "PAGAR";
            Pagar_Btn.UseVisualStyleBackColor = false;
            Pagar_Btn.Click += Pagar_Btn_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 236);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 41;
            label5.Text = "Concepto:";
            // 
            // ConceptoTxtBox
            // 
            ConceptoTxtBox.Cursor = Cursors.IBeam;
            ConceptoTxtBox.Location = new Point(100, 236);
            ConceptoTxtBox.Name = "ConceptoTxtBox";
            ConceptoTxtBox.Size = new Size(274, 59);
            ConceptoTxtBox.TabIndex = 42;
            ConceptoTxtBox.Text = "";
            // 
            // SrvMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(380, 333);
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
            Name = "SrvMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SrvMedicos";
            Load += SrvMedicos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Regresar_Btn;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label11;
        private Label label10;
        private Label label3;
        private PictureBox pictureBox9;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private TextBox Monto_TxtBox;
        private Label label16;
        private Label Categoria_Txt;
        private Label label13;
        private Button Pagar_Btn;
        private Label label5;
        private RichTextBox ConceptoTxtBox;
    }
}