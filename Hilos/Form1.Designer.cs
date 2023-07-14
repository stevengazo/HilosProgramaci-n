namespace Hilos
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dataGridViewNumeros = new DataGridView();
            groupBox3 = new GroupBox();
            dataGridViewPares = new DataGridView();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnEjecutar = new Button();
            txtTipo = new TextBox();
            txtNumero = new TextBox();
            txtNumeroHilo = new TextBox();
            dataGridViewImpares = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumeros).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImpares).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 0;
            label1.Text = "Procesando Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(240, 29);
            label2.Name = "label2";
            label2.Size = new Size(47, 19);
            label2.TabIndex = 1;
            label2.Text = "Tipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(383, 29);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 2;
            label3.Text = "Hilo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewNumeros);
            groupBox1.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 308);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // dataGridViewNumeros
            // 
            dataGridViewNumeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNumeros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewNumeros.BackgroundColor = Color.FromArgb(213, 205, 245);
            dataGridViewNumeros.BorderStyle = BorderStyle.None;
            dataGridViewNumeros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle1.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewNumeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle2.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewNumeros.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewNumeros.EnableHeadersVisualStyles = false;
            dataGridViewNumeros.Location = new Point(6, 22);
            dataGridViewNumeros.Name = "dataGridViewNumeros";
            dataGridViewNumeros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewNumeros.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.BlanchedAlmond;
            dataGridViewNumeros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewNumeros.RowTemplate.Height = 25;
            dataGridViewNumeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNumeros.Size = new Size(207, 277);
            dataGridViewNumeros.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewPares);
            groupBox3.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(252, 273);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(219, 192);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // dataGridViewPares
            // 
            dataGridViewPares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPares.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPares.BackgroundColor = Color.FromArgb(213, 205, 245);
            dataGridViewPares.BorderStyle = BorderStyle.None;
            dataGridViewPares.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle4.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewPares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewPares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle5.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewPares.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewPares.EnableHeadersVisualStyles = false;
            dataGridViewPares.Location = new Point(6, 22);
            dataGridViewPares.Name = "dataGridViewPares";
            dataGridViewPares.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPares.RowHeadersVisible = false;
            dataGridViewPares.RowTemplate.Height = 25;
            dataGridViewPares.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPares.Size = new Size(207, 161);
            dataGridViewPares.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightSteelBlue;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(391, 471);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 25);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightSteelBlue;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(126, 431);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(80, 25);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = Color.LightSteelBlue;
            btnEjecutar.FlatStyle = FlatStyle.Popup;
            btnEjecutar.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEjecutar.Location = new Point(29, 431);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(80, 25);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.FromArgb(213, 205, 245);
            txtTipo.BorderStyle = BorderStyle.None;
            txtTipo.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTipo.Location = new Point(283, 28);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(64, 20);
            txtTipo.TabIndex = 7;
            txtTipo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(213, 205, 245);
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumero.Location = new Point(176, 28);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(30, 20);
            txtNumero.TabIndex = 8;
            txtNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumeroHilo
            // 
            txtNumeroHilo.BackColor = Color.FromArgb(213, 205, 245);
            txtNumeroHilo.BorderStyle = BorderStyle.None;
            txtNumeroHilo.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumeroHilo.Location = new Point(426, 29);
            txtNumeroHilo.Name = "txtNumeroHilo";
            txtNumeroHilo.ReadOnly = true;
            txtNumeroHilo.Size = new Size(30, 20);
            txtNumeroHilo.TabIndex = 9;
            txtNumeroHilo.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewImpares
            // 
            dataGridViewImpares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewImpares.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewImpares.BackgroundColor = Color.FromArgb(213, 205, 245);
            dataGridViewImpares.BorderStyle = BorderStyle.None;
            dataGridViewImpares.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle6.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewImpares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewImpares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle7.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.BlanchedAlmond;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewImpares.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewImpares.EnableHeadersVisualStyles = false;
            dataGridViewImpares.Location = new Point(6, 22);
            dataGridViewImpares.Name = "dataGridViewImpares";
            dataGridViewImpares.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewImpares.RowHeadersVisible = false;
            dataGridViewImpares.RowTemplate.Height = 25;
            dataGridViewImpares.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewImpares.Size = new Size(207, 161);
            dataGridViewImpares.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewImpares);
            groupBox2.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(252, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(219, 192);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(213, 205, 245);
            ClientSize = new Size(479, 501);
            Controls.Add(btnEjecutar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(txtNumeroHilo);
            Controls.Add(txtNumero);
            Controls.Add(txtTipo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manejo Hilos";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumeros).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPares).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImpares).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView dataGridViewNumeros;
        private GroupBox groupBox3;
        private DataGridView dataGridViewPares;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnEjecutar;
        private TextBox txtTipo;
        private TextBox txtNumero;
        private TextBox txtNumeroHilo;
        private DataGridView dataGridViewImpares;
        private GroupBox groupBox2;
    }
}