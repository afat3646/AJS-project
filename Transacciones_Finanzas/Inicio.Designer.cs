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
            transacciones.BackColor = Color.CornflowerBlue;
            transacciones.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            transacciones.Location = new Point(30, 294);
            transacciones.Name = "transacciones";
            transacciones.Size = new Size(127, 44);
            transacciones.TabIndex = 1;
            transacciones.Text = "Transferir";
            transacciones.UseVisualStyleBackColor = false;
            transacciones.Click += transacciones_Click;
            // 
            // estadoDeCuenta
            // 
            estadoDeCuenta.Location = new Point(285, 298);
            estadoDeCuenta.Name = "estadoDeCuenta";
            estadoDeCuenta.Size = new Size(100, 40);
            estadoDeCuenta.TabIndex = 2;
            estadoDeCuenta.Text = "Estado de cuenta";
            estadoDeCuenta.UseVisualStyleBackColor = true;
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
            ActDirecBtn.Location = new Point(298, 68);
            ActDirecBtn.Name = "ActDirecBtn";
            ActDirecBtn.Size = new Size(122, 45);
            ActDirecBtn.TabIndex = 4;
            ActDirecBtn.Text = "Actualizar dirección";
            ActDirecBtn.UseVisualStyleBackColor = true;
            ActDirecBtn.Click += ActDirecBtn_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(452, 370);
            Controls.Add(ActDirecBtn);
            Controls.Add(Nombre_Txt);
            Controls.Add(estadoDeCuenta);
            Controls.Add(transacciones);
            Controls.Add(label1);
            Name = "Inicio";
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
    }
}