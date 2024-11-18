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
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(18, 191);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            label1.Location = new Point(50, 67);
            label1.Name = "label1";
            label1.Size = new Size(63, 18);
            label1.TabIndex = 1;
            label1.Text = "Correo";
            // 
            // usuarioTxt
            // 
            usuarioTxt.BackColor = SystemColors.ControlLight;
            usuarioTxt.Location = new Point(50, 109);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(100, 23);
            usuarioTxt.TabIndex = 2;
            // 
            // contraseñaTxt
            // 
            contraseñaTxt.BackColor = SystemColors.ControlLight;
            contraseñaTxt.Location = new Point(189, 109);
            contraseñaTxt.Name = "contraseñaTxt";
            contraseñaTxt.PasswordChar = '*';
            contraseñaTxt.Size = new Size(100, 23);
            contraseñaTxt.TabIndex = 3;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            Contraseña.Location = new Point(192, 67);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(102, 18);
            Contraseña.TabIndex = 4;
            Contraseña.Text = "Contraseña";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(202, 191);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(322, 256);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(Contraseña);
            Controls.Add(contraseñaTxt);
            Controls.Add(usuarioTxt);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button button2;
    }
}