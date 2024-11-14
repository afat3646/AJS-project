namespace Transacciones_Finanzas
{
    partial class Login
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
        //hola mundo

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            usuarioTxt = new TextBox();
            contraseñaTxt = new TextBox();
            Contraseña = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(88, 235);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 67);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Correo";
            // 
            // usuarioTxt
            // 
            usuarioTxt.Location = new Point(50, 109);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(100, 23);
            usuarioTxt.TabIndex = 2;
            // 
            // contraseñaTxt
            // 
            contraseñaTxt.Location = new Point(189, 109);
            contraseñaTxt.Name = "contraseñaTxt";
            contraseñaTxt.Size = new Size(100, 23);
            contraseñaTxt.TabIndex = 3;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Location = new Point(192, 67);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(67, 15);
            Contraseña.TabIndex = 4;
            Contraseña.Text = "Contraseña";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 300);
            ControlBox = false;
            Controls.Add(Contraseña);
            Controls.Add(contraseñaTxt);
            Controls.Add(usuarioTxt);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox usuarioTxt;
        private TextBox contraseñaTxt;
        private Label Contraseña;
    }
}