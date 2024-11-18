namespace Transacciones_Finanzas
{
    partial class Exportacion
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
            comboBoxTablas = new ComboBox();
            btnExportarExcel = new Button();
            dataGridViewVista = new DataGridView();
            regresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVista).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTablas
            // 
            comboBoxTablas.BackColor = SystemColors.Menu;
            comboBoxTablas.FormattingEnabled = true;
            comboBoxTablas.Location = new Point(63, 39);
            comboBoxTablas.Name = "comboBoxTablas";
            comboBoxTablas.Size = new Size(121, 23);
            comboBoxTablas.TabIndex = 0;
            comboBoxTablas.SelectedIndexChanged += comboBoxTablas_SelectedIndexChanged;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Location = new Point(229, 38);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(75, 23);
            btnExportarExcel.TabIndex = 1;
            btnExportarExcel.Text = "Exportar";
            btnExportarExcel.UseVisualStyleBackColor = true;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // dataGridViewVista
            // 
            dataGridViewVista.BackgroundColor = Color.LightBlue;
            dataGridViewVista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVista.Location = new Point(12, 105);
            dataGridViewVista.Name = "dataGridViewVista";
            dataGridViewVista.Size = new Size(373, 294);
            dataGridViewVista.TabIndex = 2;
            dataGridViewVista.CellContentClick += dataGridViewVista_CellContentClick;
            // 
            // regresar
            // 
            regresar.Location = new Point(263, 414);
            regresar.Name = "regresar";
            regresar.Size = new Size(75, 23);
            regresar.TabIndex = 3;
            regresar.Text = "Regresar";
            regresar.UseVisualStyleBackColor = true;
            regresar.Click += regresar_Click;
            // 
            // Exportacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(399, 447);
            Controls.Add(regresar);
            Controls.Add(dataGridViewVista);
            Controls.Add(btnExportarExcel);
            Controls.Add(comboBoxTablas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Exportacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exportacion";
            Load += Exportacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxTablas;
        private Button btnExportarExcel;
        private DataGridView dataGridViewVista;
        private Button regresar;
    }
}