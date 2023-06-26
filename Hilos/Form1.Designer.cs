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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dataGridViewNumeros = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewImpares = new DataGridView();
            groupBox3 = new GroupBox();
            dataGridViewPares = new DataGridView();
            groupBox4 = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnEjecutar = new Button();
            txtTipo = new TextBox();
            txtNumero = new TextBox();
            txtNumeroHilo = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNumeros).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImpares).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPares).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Procesando Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 9);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 9);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Hilo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewNumeros);
            groupBox1.Location = new Point(12, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 318);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enteros";
            // 
            // dataGridViewNumeros
            // 
            dataGridViewNumeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNumeros.Location = new Point(6, 22);
            dataGridViewNumeros.Name = "dataGridViewNumeros";
            dataGridViewNumeros.RowTemplate.Height = 25;
            dataGridViewNumeros.Size = new Size(121, 290);
            dataGridViewNumeros.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewImpares);
            groupBox2.Location = new Point(151, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(133, 318);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Impares";
            // 
            // dataGridViewImpares
            // 
            dataGridViewImpares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewImpares.Location = new Point(6, 22);
            dataGridViewImpares.Name = "dataGridViewImpares";
            dataGridViewImpares.RowTemplate.Height = 25;
            dataGridViewImpares.Size = new Size(121, 290);
            dataGridViewImpares.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewPares);
            groupBox3.Location = new Point(290, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(133, 318);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pares";
            // 
            // dataGridViewPares
            // 
            dataGridViewPares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPares.Location = new Point(6, 22);
            dataGridViewPares.Name = "dataGridViewPares";
            dataGridViewPares.RowTemplate.Height = 25;
            dataGridViewPares.Size = new Size(121, 290);
            dataGridViewPares.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSalir);
            groupBox4.Controls.Add(btnLimpiar);
            groupBox4.Controls.Add(btnEjecutar);
            groupBox4.Location = new Point(12, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(405, 48);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Acciones";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(168, 19);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(87, 19);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(6, 19);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(229, 6);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(112, 23);
            txtTipo.TabIndex = 7;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(134, 6);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(53, 23);
            txtNumero.TabIndex = 8;
            // 
            // txtNumeroHilo
            // 
            txtNumeroHilo.Location = new Point(382, 6);
            txtNumeroHilo.Name = "txtNumeroHilo";
            txtNumeroHilo.Size = new Size(35, 23);
            txtNumeroHilo.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 411);
            Controls.Add(txtNumeroHilo);
            Controls.Add(txtNumero);
            Controls.Add(txtTipo);
            Controls.Add(groupBox4);
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
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewImpares).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPares).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView dataGridViewNumeros;
        private GroupBox groupBox2;
        private DataGridView dataGridViewImpares;
        private GroupBox groupBox3;
        private DataGridView dataGridViewPares;
        private GroupBox groupBox4;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnEjecutar;
        private TextBox txtTipo;
        private TextBox txtNumero;
        private TextBox txtNumeroHilo;
    }
}