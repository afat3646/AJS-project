namespace Transacciones_Finanzas
{
    partial class guardadito
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
            label2 = new Label();
            textBox1 = new TextBox();
            Guardar = new Button();
            consultar = new Button();
            balanceTxt = new Label();
            retirar = new Button();
            dateTimePicker1 = new DateTimePicker();
            guardadoTxtlabel = new Label();
            fechadisponiblelabel = new Label();
            dineroGuardadoTxt = new Label();
            fechaDispoTxt = new Label();
            regresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F);
            label1.Location = new Point(16, 61);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 0;
            label1.Text = "BALANCE ACTUAL: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 15.75F);
            label2.Location = new Point(10, 143);
            label2.Name = "label2";
            label2.Size = new Size(188, 26);
            label2.TabIndex = 1;
            label2.Text = "Monto para guardar";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Verdana", 9F);
            textBox1.Location = new Point(39, 183);
            textBox1.MaxLength = 13;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 22);
            textBox1.TabIndex = 2;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(16, 235);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(119, 23);
            Guardar.TabIndex = 3;
            Guardar.Text = "Guardar dinero";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // consultar
            // 
            consultar.Location = new Point(22, 92);
            consultar.Name = "consultar";
            consultar.Size = new Size(145, 23);
            consultar.TabIndex = 4;
            consultar.Text = "Consultar balance";
            consultar.UseVisualStyleBackColor = true;
            consultar.Click += consultar_Click;
            // 
            // balanceTxt
            // 
            balanceTxt.AutoSize = true;
            balanceTxt.Location = new Point(236, 69);
            balanceTxt.Name = "balanceTxt";
            balanceTxt.Size = new Size(0, 15);
            balanceTxt.TabIndex = 5;
            // 
            // retirar
            // 
            retirar.Location = new Point(262, 235);
            retirar.Name = "retirar";
            retirar.Size = new Size(75, 23);
            retirar.TabIndex = 6;
            retirar.Text = "Retirar";
            retirar.UseVisualStyleBackColor = true;
            retirar.Click += retirar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(16, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // guardadoTxtlabel
            // 
            guardadoTxtlabel.AutoSize = true;
            guardadoTxtlabel.Font = new Font("Franklin Gothic Medium", 15.75F);
            guardadoTxtlabel.Location = new Point(262, 143);
            guardadoTxtlabel.Name = "guardadoTxtlabel";
            guardadoTxtlabel.Size = new Size(165, 26);
            guardadoTxtlabel.TabIndex = 8;
            guardadoTxtlabel.Text = "Dinero guardado:";
            // 
            // fechadisponiblelabel
            // 
            fechadisponiblelabel.AutoSize = true;
            fechadisponiblelabel.Font = new Font("Franklin Gothic Medium", 15.75F);
            fechadisponiblelabel.Location = new Point(510, 143);
            fechadisponiblelabel.Name = "fechadisponiblelabel";
            fechadisponiblelabel.Size = new Size(162, 26);
            fechadisponiblelabel.TabIndex = 10;
            fechadisponiblelabel.Text = "Fecha disponible";
            // 
            // dineroGuardadoTxt
            // 
            dineroGuardadoTxt.AutoSize = true;
            dineroGuardadoTxt.Location = new Point(271, 192);
            dineroGuardadoTxt.Name = "dineroGuardadoTxt";
            dineroGuardadoTxt.Size = new Size(0, 15);
            dineroGuardadoTxt.TabIndex = 11;
            // 
            // fechaDispoTxt
            // 
            fechaDispoTxt.AutoSize = true;
            fechaDispoTxt.Location = new Point(518, 201);
            fechaDispoTxt.Name = "fechaDispoTxt";
            fechaDispoTxt.Size = new Size(0, 15);
            fechaDispoTxt.TabIndex = 12;
            // 
            // regresar
            // 
            regresar.Location = new Point(608, 317);
            regresar.Name = "regresar";
            regresar.Size = new Size(75, 23);
            regresar.TabIndex = 13;
            regresar.Text = "Regresar";
            regresar.UseVisualStyleBackColor = true;
            regresar.Click += regresar_Click;
            // 
            // guardadito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(778, 381);
            Controls.Add(regresar);
            Controls.Add(fechaDispoTxt);
            Controls.Add(dineroGuardadoTxt);
            Controls.Add(fechadisponiblelabel);
            Controls.Add(guardadoTxtlabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(retirar);
            Controls.Add(balanceTxt);
            Controls.Add(consultar);
            Controls.Add(Guardar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "guardadito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "'¿95";
            Load += guardadito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button Guardar;
        private Button consultar;
        private Label balanceTxt;
        private Button retirar;
        private DateTimePicker dateTimePicker1;
        private Label guardadoTxtlabel;
        private Label fechadisponiblelabel;
        private Label dineroGuardadoTxt;
        private Label fechaDispoTxt;
        private Button regresar;
    }
}