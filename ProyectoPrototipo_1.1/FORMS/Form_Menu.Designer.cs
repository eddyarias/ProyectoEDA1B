﻿namespace ProyectoPrototipo_1._0
{
    partial class Form_Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            bttModuloInventario = new Button();
            label1 = new Label();
            label2 = new Label();
            BSalir = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bttModuloInventario
            // 
            bttModuloInventario.FlatAppearance.BorderColor = Color.LightSkyBlue;
            bttModuloInventario.FlatAppearance.BorderSize = 2;
            bttModuloInventario.FlatStyle = FlatStyle.Flat;
            bttModuloInventario.Location = new Point(300, 52);
            bttModuloInventario.Margin = new Padding(3, 4, 3, 4);
            bttModuloInventario.Name = "bttModuloInventario";
            bttModuloInventario.Size = new Size(143, 145);
            bttModuloInventario.TabIndex = 0;
            bttModuloInventario.Text = "MÓDULO DE INVENTARIO";
            bttModuloInventario.UseVisualStyleBackColor = true;
            bttModuloInventario.Click += bttModuloInventario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 212);
            label1.Name = "label1";
            label1.Size = new Size(0, 39);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 34.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(319, 212);
            label2.Name = "label2";
            label2.Size = new Size(0, 67);
            label2.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.FlatAppearance.BorderColor = Color.Red;
            BSalir.FlatAppearance.BorderSize = 2;
            BSalir.FlatStyle = FlatStyle.Flat;
            BSalir.Location = new Point(1419, 891);
            BSalir.Margin = new Padding(3, 4, 3, 4);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(88, 49);
            BSalir.TabIndex = 9;
            BSalir.Text = "SALIR";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(bttModuloInventario);
            panel1.Location = new Point(96, 14);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1402, 249);
            panel1.TabIndex = 13;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1510, 953);
            Controls.Add(panel1);
            Controls.Add(BSalir);
            Controls.Add(label2);
            Controls.Add(label1);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Menu";
            Text = "SISTEMA DE GESTIÓN DE FARMACIAS";
            FormClosing += Form_Menu_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttModuloInventario;
        private Label label1;
        private Label label2;
        private Button BSalir;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}

