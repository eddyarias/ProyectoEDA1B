namespace ProyectoPrototipo_1._0
{
    partial class Form_Inventario
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
            dataGridView1 = new DataGridView();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            BAgregar = new Button();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox15 = new TextBox();
            label15 = new Label();
            textBox14 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            BBuscar = new Button();
            BActualizar = new Button();
            BEliminar = new Button();
            label2 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label14 = new Label();
            tabPage1 = new TabPage();
            bttUltimo = new Button();
            bttInicio = new Button();
            bttSiguiente = new Button();
            bttAnterior = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(271, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(616, 425);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Location = new Point(-1, -1);
            tabControl2.Margin = new Padding(3, 4, 3, 4);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(910, 591);
            tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BAgregar);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(textBox15);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(textBox14);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(BBuscar);
            tabPage3.Controls.Add(BActualizar);
            tabPage3.Controls.Add(BEliminar);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(textBox9);
            tabPage3.Controls.Add(textBox10);
            tabPage3.Controls.Add(textBox11);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(902, 558);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Inventario";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(25, 345);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(94, 38);
            BAgregar.TabIndex = 75;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(130, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 74;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(237, 510);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 73;
            label3.Text = "/2000 ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 506);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(27, 27);
            textBox1.TabIndex = 72;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(113, 297);
            textBox15.Margin = new Padding(3, 4, 3, 4);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(119, 27);
            textBox15.TabIndex = 71;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(71, 305);
            label15.Name = "label15";
            label15.Size = new Size(34, 20);
            label15.TabIndex = 70;
            label15.Text = "IVA:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(113, 158);
            textBox14.Margin = new Padding(3, 4, 3, 4);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(119, 27);
            textBox14.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 164);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 68;
            label1.Text = "P.V.P:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 262);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 27);
            textBox2.TabIndex = 66;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(113, 227);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(119, 27);
            textBox4.TabIndex = 65;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(113, 192);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(119, 27);
            textBox7.TabIndex = 64;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(113, 122);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(119, 27);
            textBox8.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 266);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 62;
            label8.Text = "%Descuento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 231);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 61;
            label7.Text = "Fec. cad.:";
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(130, 345);
            BBuscar.Margin = new Padding(3, 4, 3, 4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(88, 38);
            BBuscar.TabIndex = 60;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // BActualizar
            // 
            BActualizar.Location = new Point(464, 451);
            BActualizar.Margin = new Padding(3, 4, 3, 4);
            BActualizar.Name = "BActualizar";
            BActualizar.Size = new Size(84, 38);
            BActualizar.TabIndex = 59;
            BActualizar.Text = "Actualizar";
            BActualizar.UseVisualStyleBackColor = true;
            BActualizar.Click += BActualizar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(579, 451);
            BEliminar.Margin = new Padding(3, 4, 3, 4);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(80, 38);
            BEliminar.TabIndex = 58;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 196);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 57;
            label2.Text = "Precio/unidad:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(113, 87);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(119, 27);
            textBox9.TabIndex = 56;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(113, 52);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(119, 27);
            textBox10.TabIndex = 55;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(113, 17);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(119, 27);
            textBox11.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 56);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 53;
            label4.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 130);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 52;
            label9.Text = "Lote:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 91);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 51;
            label10.Text = "Descripción:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 21);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 50;
            label11.Text = "Código: (*)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(83, 510);
            label14.Name = "label14";
            label14.Size = new Size(116, 20);
            label14.TabIndex = 3;
            label14.Text = "# Productos:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bttUltimo);
            tabPage1.Controls.Add(bttInicio);
            tabPage1.Controls.Add(bttSiguiente);
            tabPage1.Controls.Add(bttAnterior);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(902, 558);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Leer Individual";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // bttUltimo
            // 
            bttUltimo.Location = new Point(542, 466);
            bttUltimo.Name = "bttUltimo";
            bttUltimo.Size = new Size(131, 85);
            bttUltimo.TabIndex = 5;
            bttUltimo.Text = "FINAL";
            bttUltimo.UseVisualStyleBackColor = true;
            // 
            // bttInicio
            // 
            bttInicio.Location = new Point(257, 466);
            bttInicio.Name = "bttInicio";
            bttInicio.Size = new Size(130, 85);
            bttInicio.TabIndex = 4;
            bttInicio.Text = "INICIO";
            bttInicio.UseVisualStyleBackColor = true;
            // 
            // bttSiguiente
            // 
            bttSiguiente.Location = new Point(749, 182);
            bttSiguiente.Name = "bttSiguiente";
            bttSiguiente.Size = new Size(93, 138);
            bttSiguiente.TabIndex = 3;
            bttSiguiente.Text = "SIGUIENTE";
            bttSiguiente.UseVisualStyleBackColor = true;
            // 
            // bttAnterior
            // 
            bttAnterior.Location = new Point(24, 182);
            bttAnterior.Name = "bttAnterior";
            bttAnterior.Size = new Size(97, 138);
            bttAnterior.TabIndex = 2;
            bttAnterior.Text = "ANTERIOR";
            bttAnterior.UseVisualStyleBackColor = true;
            bttAnterior.Click += bttAnterior_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(127, 34);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.Size = new Size(616, 425);
            dataGridView2.TabIndex = 1;
            // 
            // Form_Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 591);
            Controls.Add(tabControl2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Inventario";
            Text = "Inventario";
            Load += Form_Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private Label label14;
        private TextBox textBox15;
        private Label label15;
        private TextBox textBox14;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Label label7;
        private Button BBuscar;
        private Button BActualizar;
        private Button BEliminar;
        private Label label2;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Button BAgregar;
        private TabPage tabPage1;
        private DataGridView dataGridView2;
        private Button bttUltimo;
        private Button bttInicio;
        private Button bttSiguiente;
        private Button bttAnterior;
    }
}