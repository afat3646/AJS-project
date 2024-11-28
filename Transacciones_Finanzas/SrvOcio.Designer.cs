namespace Transacciones_Finanzas
{
    partial class SrvOcio
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label10 = new Label();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            Regresar_Btn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(238, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(23, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 144);
            panel1.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(153, 117);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 19;
            label10.Text = "GAMING";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 117);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 12;
            label3.Text = "    STREAMING";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(122, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(113, 108);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(3, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 39);
            label2.Name = "label2";
            label2.Size = new Size(249, 23);
            label2.TabIndex = 49;
            label2.Text = "Seleccione un servicio:";
            label2.Click += label2_Click;
            // 
            // Regresar_Btn
            // 
            Regresar_Btn.BackColor = SystemColors.Menu;
            Regresar_Btn.Cursor = Cursors.Hand;
            Regresar_Btn.FlatAppearance.BorderColor = Color.Red;
            Regresar_Btn.FlatStyle = FlatStyle.Popup;
            Regresar_Btn.ForeColor = Color.Red;
            Regresar_Btn.Location = new Point(212, 218);
            Regresar_Btn.Name = "Regresar_Btn";
            Regresar_Btn.Size = new Size(75, 23);
            Regresar_Btn.TabIndex = 52;
            Regresar_Btn.Text = "REGRESAR";
            Regresar_Btn.UseVisualStyleBackColor = false;
            Regresar_Btn.Click += Regresar_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 50;
            label1.Text = "SERVICIOS OCIO";
            // 
            // SrvOcio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(290, 246);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(Regresar_Btn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SrvOcio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SrvOcio";
            Load += SrvOcio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label10;
        private Label label3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private Label label2;
        private Button Regresar_Btn;
        private Label label1;
    }
}