﻿namespace ProyectoPrototipo_1._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inventario));
            dgvTablaInventario = new DataGridView();
            tabControlCrud = new TabControl();
            tabPageCrear = new TabPage();
            btnLimpiar = new Button();
            txtTipoCrear = new TextBox();
            label6 = new Label();
            btnAgregar = new Button();
            txtPVPCrear = new TextBox();
            label1 = new Label();
            txtDescuentoCrear = new TextBox();
            txtFechaCaducidadCrear = new TextBox();
            txtPrecioUnidadCrear = new TextBox();
            txtLoteCrear = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            txtNombreCrear = new TextBox();
            txtCantidadCrear = new TextBox();
            txtCodigoCrear = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tabPageActualizar = new TabPage();
            txtTipoActualizar = new TextBox();
            label12 = new Label();
            txtPVPActualizar = new TextBox();
            label13 = new Label();
            txtDescuentoActualizar = new TextBox();
            txtFechaCaducidadActualizar = new TextBox();
            txtPrecioUnidadActualizar = new TextBox();
            txtLoteActualizar = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtNombreActualizar = new TextBox();
            txtCantidadActualizar = new TextBox();
            txtCodigoActualizar = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            btnActualizar = new Button();
            tabPageEliminar = new TabPage();
            txtTipoEliminar = new TextBox();
            label22 = new Label();
            txtPVPEliminar = new TextBox();
            label23 = new Label();
            txtDescuentoEliminar = new TextBox();
            txtFechaCaducidadEliminar = new TextBox();
            txtPrecioUnidadEliminar = new TextBox();
            txtLoteEliminar = new TextBox();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            txtNombreEliminar = new TextBox();
            txtCantidadEliminar = new TextBox();
            txtCodigoEliminar = new TextBox();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            btnEliminar = new Button();
            tabPageLeerIndividual = new TabPage();
            btnCancelarBusqueda = new Button();
            label3 = new Label();
            txtNumeroProductos = new TextBox();
            btnBuscar = new Button();
            label14 = new Label();
            groupBoxBuscar = new GroupBox();
            txtBuscar = new TextBox();
            cmbBuscar = new ComboBox();
            btnOrdenar = new Button();
            label5 = new Label();
            groupBoxOrdenar = new GroupBox();
            cmbOrdenar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTablaInventario).BeginInit();
            tabControlCrud.SuspendLayout();
            tabPageCrear.SuspendLayout();
            tabPageActualizar.SuspendLayout();
            tabPageEliminar.SuspendLayout();
            groupBoxBuscar.SuspendLayout();
            groupBoxOrdenar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTablaInventario
            // 
            dgvTablaInventario.AllowUserToAddRows = false;
            dgvTablaInventario.AllowUserToDeleteRows = false;
            dgvTablaInventario.BackgroundColor = Color.WhiteSmoke;
            dgvTablaInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaInventario.Location = new Point(434, 32);
            dgvTablaInventario.Margin = new Padding(3, 4, 3, 4);
            dgvTablaInventario.Name = "dgvTablaInventario";
            dgvTablaInventario.RowHeadersWidth = 51;
            dgvTablaInventario.RowTemplate.Height = 24;
            dgvTablaInventario.Size = new Size(915, 351);
            dgvTablaInventario.TabIndex = 0;
            dgvTablaInventario.CellClick += dgvTablaInventario_CellClick;
            // 
            // tabControlCrud
            // 
            tabControlCrud.Controls.Add(tabPageCrear);
            tabControlCrud.Controls.Add(tabPageActualizar);
            tabControlCrud.Controls.Add(tabPageEliminar);
            tabControlCrud.Controls.Add(tabPageLeerIndividual);
            tabControlCrud.Location = new Point(-1, -1);
            tabControlCrud.Margin = new Padding(3, 4, 3, 4);
            tabControlCrud.Name = "tabControlCrud";
            tabControlCrud.SelectedIndex = 0;
            tabControlCrud.Size = new Size(375, 489);
            tabControlCrud.TabIndex = 3;
            tabControlCrud.SelectedIndexChanged += tabControlCrud_SelectedIndexChanged;
            // 
            // tabPageCrear
            // 
            tabPageCrear.Controls.Add(btnLimpiar);
            tabPageCrear.Controls.Add(txtTipoCrear);
            tabPageCrear.Controls.Add(label6);
            tabPageCrear.Controls.Add(btnAgregar);
            tabPageCrear.Controls.Add(txtPVPCrear);
            tabPageCrear.Controls.Add(label1);
            tabPageCrear.Controls.Add(txtDescuentoCrear);
            tabPageCrear.Controls.Add(txtFechaCaducidadCrear);
            tabPageCrear.Controls.Add(txtPrecioUnidadCrear);
            tabPageCrear.Controls.Add(txtLoteCrear);
            tabPageCrear.Controls.Add(label8);
            tabPageCrear.Controls.Add(label7);
            tabPageCrear.Controls.Add(label2);
            tabPageCrear.Controls.Add(txtNombreCrear);
            tabPageCrear.Controls.Add(txtCantidadCrear);
            tabPageCrear.Controls.Add(txtCodigoCrear);
            tabPageCrear.Controls.Add(label4);
            tabPageCrear.Controls.Add(label9);
            tabPageCrear.Controls.Add(label10);
            tabPageCrear.Controls.Add(label11);
            tabPageCrear.Location = new Point(4, 29);
            tabPageCrear.Margin = new Padding(3, 4, 3, 4);
            tabPageCrear.Name = "tabPageCrear";
            tabPageCrear.Padding = new Padding(3, 4, 3, 4);
            tabPageCrear.Size = new Size(367, 456);
            tabPageCrear.TabIndex = 0;
            tabPageCrear.Text = "Crear";
            tabPageCrear.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(185, 368);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 38);
            btnLimpiar.TabIndex = 78;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtTipoCrear
            // 
            txtTipoCrear.Location = new Point(127, 118);
            txtTipoCrear.Margin = new Padding(3, 4, 3, 4);
            txtTipoCrear.Name = "txtTipoCrear";
            txtTipoCrear.Size = new Size(152, 27);
            txtTipoCrear.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 119);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 76;
            label6.Text = "Tipo:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btnAgregar.FlatAppearance.BorderSize = 2;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(61, 368);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 38);
            btnAgregar.TabIndex = 63;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += BAgregar_Click;
            // 
            // txtPVPCrear
            // 
            txtPVPCrear.Location = new Point(127, 212);
            txtPVPCrear.Margin = new Padding(3, 4, 3, 4);
            txtPVPCrear.Name = "txtPVPCrear";
            txtPVPCrear.Size = new Size(152, 27);
            txtPVPCrear.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 216);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 68;
            label1.Text = "P.V.P:";
            // 
            // txtDescuentoCrear
            // 
            txtDescuentoCrear.Location = new Point(127, 318);
            txtDescuentoCrear.Margin = new Padding(3, 4, 3, 4);
            txtDescuentoCrear.Name = "txtDescuentoCrear";
            txtDescuentoCrear.Size = new Size(152, 27);
            txtDescuentoCrear.TabIndex = 62;
            // 
            // txtFechaCaducidadCrear
            // 
            txtFechaCaducidadCrear.Location = new Point(127, 282);
            txtFechaCaducidadCrear.Margin = new Padding(3, 4, 3, 4);
            txtFechaCaducidadCrear.Name = "txtFechaCaducidadCrear";
            txtFechaCaducidadCrear.Size = new Size(152, 27);
            txtFechaCaducidadCrear.TabIndex = 61;
            // 
            // txtPrecioUnidadCrear
            // 
            txtPrecioUnidadCrear.Location = new Point(127, 247);
            txtPrecioUnidadCrear.Margin = new Padding(3, 4, 3, 4);
            txtPrecioUnidadCrear.Name = "txtPrecioUnidadCrear";
            txtPrecioUnidadCrear.Size = new Size(152, 27);
            txtPrecioUnidadCrear.TabIndex = 60;
            // 
            // txtLoteCrear
            // 
            txtLoteCrear.Location = new Point(127, 175);
            txtLoteCrear.Margin = new Padding(3, 4, 3, 4);
            txtLoteCrear.Name = "txtLoteCrear";
            txtLoteCrear.Size = new Size(152, 27);
            txtLoteCrear.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 320);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 62;
            label8.Text = "%Descuento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 289);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 61;
            label7.Text = "Fec. cad.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 254);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 57;
            label2.Text = "Precio/unidad:";
            // 
            // txtNombreCrear
            // 
            txtNombreCrear.Location = new Point(127, 83);
            txtNombreCrear.Margin = new Padding(3, 4, 3, 4);
            txtNombreCrear.Name = "txtNombreCrear";
            txtNombreCrear.Size = new Size(152, 27);
            txtNombreCrear.TabIndex = 55;
            // 
            // txtCantidadCrear
            // 
            txtCantidadCrear.Location = new Point(127, 146);
            txtCantidadCrear.Margin = new Padding(3, 4, 3, 4);
            txtCantidadCrear.Name = "txtCantidadCrear";
            txtCantidadCrear.Size = new Size(152, 27);
            txtCantidadCrear.TabIndex = 57;
            // 
            // txtCodigoCrear
            // 
            txtCodigoCrear.Location = new Point(127, 49);
            txtCodigoCrear.Margin = new Padding(3, 4, 3, 4);
            txtCodigoCrear.Name = "txtCodigoCrear";
            txtCodigoCrear.Size = new Size(152, 27);
            txtCodigoCrear.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 153);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 53;
            label4.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 182);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 52;
            label9.Text = "Lote:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 84);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 51;
            label10.Text = "Nombre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(48, 52);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 50;
            label11.Text = "Código: (*)";
            // 
            // tabPageActualizar
            // 
            tabPageActualizar.Controls.Add(txtTipoActualizar);
            tabPageActualizar.Controls.Add(label12);
            tabPageActualizar.Controls.Add(txtPVPActualizar);
            tabPageActualizar.Controls.Add(label13);
            tabPageActualizar.Controls.Add(txtDescuentoActualizar);
            tabPageActualizar.Controls.Add(txtFechaCaducidadActualizar);
            tabPageActualizar.Controls.Add(txtPrecioUnidadActualizar);
            tabPageActualizar.Controls.Add(txtLoteActualizar);
            tabPageActualizar.Controls.Add(label15);
            tabPageActualizar.Controls.Add(label16);
            tabPageActualizar.Controls.Add(label17);
            tabPageActualizar.Controls.Add(txtNombreActualizar);
            tabPageActualizar.Controls.Add(txtCantidadActualizar);
            tabPageActualizar.Controls.Add(txtCodigoActualizar);
            tabPageActualizar.Controls.Add(label18);
            tabPageActualizar.Controls.Add(label19);
            tabPageActualizar.Controls.Add(label20);
            tabPageActualizar.Controls.Add(label21);
            tabPageActualizar.Controls.Add(btnActualizar);
            tabPageActualizar.Location = new Point(4, 29);
            tabPageActualizar.Name = "tabPageActualizar";
            tabPageActualizar.Padding = new Padding(3);
            tabPageActualizar.Size = new Size(367, 456);
            tabPageActualizar.TabIndex = 1;
            tabPageActualizar.Text = "Actualizar";
            tabPageActualizar.UseVisualStyleBackColor = true;
            // 
            // txtTipoActualizar
            // 
            txtTipoActualizar.Location = new Point(128, 115);
            txtTipoActualizar.Margin = new Padding(3, 4, 3, 4);
            txtTipoActualizar.Name = "txtTipoActualizar";
            txtTipoActualizar.Size = new Size(150, 27);
            txtTipoActualizar.TabIndex = 84;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(79, 120);
            label12.Name = "label12";
            label12.Size = new Size(42, 20);
            label12.TabIndex = 94;
            label12.Text = "Tipo:";
            // 
            // txtPVPActualizar
            // 
            txtPVPActualizar.Location = new Point(128, 210);
            txtPVPActualizar.Margin = new Padding(3, 4, 3, 4);
            txtPVPActualizar.Name = "txtPVPActualizar";
            txtPVPActualizar.Size = new Size(150, 27);
            txtPVPActualizar.TabIndex = 87;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(79, 214);
            label13.Name = "label13";
            label13.Size = new Size(43, 20);
            label13.TabIndex = 92;
            label13.Text = "P.V.P:";
            // 
            // txtDescuentoActualizar
            // 
            txtDescuentoActualizar.Location = new Point(128, 316);
            txtDescuentoActualizar.Margin = new Padding(3, 4, 3, 4);
            txtDescuentoActualizar.Name = "txtDescuentoActualizar";
            txtDescuentoActualizar.Size = new Size(150, 27);
            txtDescuentoActualizar.TabIndex = 90;
            // 
            // txtFechaCaducidadActualizar
            // 
            txtFechaCaducidadActualizar.Location = new Point(128, 280);
            txtFechaCaducidadActualizar.Margin = new Padding(3, 4, 3, 4);
            txtFechaCaducidadActualizar.Name = "txtFechaCaducidadActualizar";
            txtFechaCaducidadActualizar.Size = new Size(150, 27);
            txtFechaCaducidadActualizar.TabIndex = 89;
            // 
            // txtPrecioUnidadActualizar
            // 
            txtPrecioUnidadActualizar.Location = new Point(128, 245);
            txtPrecioUnidadActualizar.Margin = new Padding(3, 4, 3, 4);
            txtPrecioUnidadActualizar.Name = "txtPrecioUnidadActualizar";
            txtPrecioUnidadActualizar.Size = new Size(150, 27);
            txtPrecioUnidadActualizar.TabIndex = 88;
            // 
            // txtLoteActualizar
            // 
            txtLoteActualizar.Location = new Point(128, 177);
            txtLoteActualizar.Margin = new Padding(3, 4, 3, 4);
            txtLoteActualizar.Name = "txtLoteActualizar";
            txtLoteActualizar.Size = new Size(150, 27);
            txtLoteActualizar.TabIndex = 86;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(30, 321);
            label15.Name = "label15";
            label15.Size = new Size(94, 20);
            label15.TabIndex = 87;
            label15.Text = "%Descuento:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(54, 287);
            label16.Name = "label16";
            label16.Size = new Size(68, 20);
            label16.TabIndex = 86;
            label16.Text = "Fec. cad.:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(18, 250);
            label17.Name = "label17";
            label17.Size = new Size(105, 20);
            label17.TabIndex = 85;
            label17.Text = "Precio/unidad:";
            // 
            // txtNombreActualizar
            // 
            txtNombreActualizar.Location = new Point(128, 82);
            txtNombreActualizar.Margin = new Padding(3, 4, 3, 4);
            txtNombreActualizar.Name = "txtNombreActualizar";
            txtNombreActualizar.Size = new Size(150, 27);
            txtNombreActualizar.TabIndex = 83;
            // 
            // txtCantidadActualizar
            // 
            txtCantidadActualizar.Location = new Point(128, 144);
            txtCantidadActualizar.Margin = new Padding(3, 4, 3, 4);
            txtCantidadActualizar.Name = "txtCantidadActualizar";
            txtCantidadActualizar.Size = new Size(150, 27);
            txtCantidadActualizar.TabIndex = 85;
            // 
            // txtCodigoActualizar
            // 
            txtCodigoActualizar.Enabled = false;
            txtCodigoActualizar.Location = new Point(128, 47);
            txtCodigoActualizar.Margin = new Padding(3, 4, 3, 4);
            txtCodigoActualizar.Name = "txtCodigoActualizar";
            txtCodigoActualizar.ReadOnly = true;
            txtCodigoActualizar.Size = new Size(150, 27);
            txtCodigoActualizar.TabIndex = 82;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(52, 149);
            label18.Name = "label18";
            label18.Size = new Size(72, 20);
            label18.TabIndex = 81;
            label18.Text = "Cantidad:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(81, 180);
            label19.Name = "label19";
            label19.Size = new Size(41, 20);
            label19.TabIndex = 80;
            label19.Text = "Lote:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(55, 82);
            label20.Name = "label20";
            label20.Size = new Size(67, 20);
            label20.TabIndex = 79;
            label20.Text = "Nombre:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(52, 52);
            label21.Name = "label21";
            label21.Size = new Size(81, 20);
            label21.TabIndex = 78;
            label21.Text = "Código: (*)";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            btnActualizar.FlatAppearance.BorderSize = 2;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(129, 368);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 38);
            btnActualizar.TabIndex = 91;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += BActualizar_Click;
            // 
            // tabPageEliminar
            // 
            tabPageEliminar.Controls.Add(txtTipoEliminar);
            tabPageEliminar.Controls.Add(label22);
            tabPageEliminar.Controls.Add(txtPVPEliminar);
            tabPageEliminar.Controls.Add(label23);
            tabPageEliminar.Controls.Add(txtDescuentoEliminar);
            tabPageEliminar.Controls.Add(txtFechaCaducidadEliminar);
            tabPageEliminar.Controls.Add(txtPrecioUnidadEliminar);
            tabPageEliminar.Controls.Add(txtLoteEliminar);
            tabPageEliminar.Controls.Add(label24);
            tabPageEliminar.Controls.Add(label25);
            tabPageEliminar.Controls.Add(label26);
            tabPageEliminar.Controls.Add(txtNombreEliminar);
            tabPageEliminar.Controls.Add(txtCantidadEliminar);
            tabPageEliminar.Controls.Add(txtCodigoEliminar);
            tabPageEliminar.Controls.Add(label27);
            tabPageEliminar.Controls.Add(label28);
            tabPageEliminar.Controls.Add(label29);
            tabPageEliminar.Controls.Add(label30);
            tabPageEliminar.Controls.Add(btnEliminar);
            tabPageEliminar.Location = new Point(4, 29);
            tabPageEliminar.Name = "tabPageEliminar";
            tabPageEliminar.Size = new Size(367, 456);
            tabPageEliminar.TabIndex = 2;
            tabPageEliminar.Text = "Eliminar";
            tabPageEliminar.UseVisualStyleBackColor = true;
            // 
            // txtTipoEliminar
            // 
            txtTipoEliminar.Enabled = false;
            txtTipoEliminar.Location = new Point(134, 116);
            txtTipoEliminar.Margin = new Padding(3, 4, 3, 4);
            txtTipoEliminar.Name = "txtTipoEliminar";
            txtTipoEliminar.ReadOnly = true;
            txtTipoEliminar.Size = new Size(143, 27);
            txtTipoEliminar.TabIndex = 113;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(84, 117);
            label22.Name = "label22";
            label22.Size = new Size(42, 20);
            label22.TabIndex = 112;
            label22.Text = "Tipo:";
            // 
            // txtPVPEliminar
            // 
            txtPVPEliminar.Enabled = false;
            txtPVPEliminar.Location = new Point(134, 210);
            txtPVPEliminar.Margin = new Padding(3, 4, 3, 4);
            txtPVPEliminar.Name = "txtPVPEliminar";
            txtPVPEliminar.ReadOnly = true;
            txtPVPEliminar.Size = new Size(143, 27);
            txtPVPEliminar.TabIndex = 111;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(84, 214);
            label23.Name = "label23";
            label23.Size = new Size(43, 20);
            label23.TabIndex = 110;
            label23.Text = "P.V.P:";
            // 
            // txtDescuentoEliminar
            // 
            txtDescuentoEliminar.Enabled = false;
            txtDescuentoEliminar.Location = new Point(134, 316);
            txtDescuentoEliminar.Margin = new Padding(3, 4, 3, 4);
            txtDescuentoEliminar.Name = "txtDescuentoEliminar";
            txtDescuentoEliminar.ReadOnly = true;
            txtDescuentoEliminar.Size = new Size(143, 27);
            txtDescuentoEliminar.TabIndex = 109;
            // 
            // txtFechaCaducidadEliminar
            // 
            txtFechaCaducidadEliminar.Enabled = false;
            txtFechaCaducidadEliminar.Location = new Point(134, 280);
            txtFechaCaducidadEliminar.Margin = new Padding(3, 4, 3, 4);
            txtFechaCaducidadEliminar.Name = "txtFechaCaducidadEliminar";
            txtFechaCaducidadEliminar.ReadOnly = true;
            txtFechaCaducidadEliminar.Size = new Size(143, 27);
            txtFechaCaducidadEliminar.TabIndex = 108;
            // 
            // txtPrecioUnidadEliminar
            // 
            txtPrecioUnidadEliminar.Enabled = false;
            txtPrecioUnidadEliminar.Location = new Point(134, 245);
            txtPrecioUnidadEliminar.Margin = new Padding(3, 4, 3, 4);
            txtPrecioUnidadEliminar.Name = "txtPrecioUnidadEliminar";
            txtPrecioUnidadEliminar.ReadOnly = true;
            txtPrecioUnidadEliminar.Size = new Size(143, 27);
            txtPrecioUnidadEliminar.TabIndex = 107;
            // 
            // txtLoteEliminar
            // 
            txtLoteEliminar.Enabled = false;
            txtLoteEliminar.Location = new Point(134, 174);
            txtLoteEliminar.Margin = new Padding(3, 4, 3, 4);
            txtLoteEliminar.Name = "txtLoteEliminar";
            txtLoteEliminar.ReadOnly = true;
            txtLoteEliminar.Size = new Size(143, 27);
            txtLoteEliminar.TabIndex = 106;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(39, 321);
            label24.Name = "label24";
            label24.Size = new Size(94, 20);
            label24.TabIndex = 105;
            label24.Text = "%Descuento:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(62, 287);
            label25.Name = "label25";
            label25.Size = new Size(68, 20);
            label25.TabIndex = 104;
            label25.Text = "Fec. cad.:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(26, 253);
            label26.Name = "label26";
            label26.Size = new Size(105, 20);
            label26.TabIndex = 103;
            label26.Text = "Precio/unidad:";
            // 
            // txtNombreEliminar
            // 
            txtNombreEliminar.Enabled = false;
            txtNombreEliminar.Location = new Point(134, 82);
            txtNombreEliminar.Margin = new Padding(3, 4, 3, 4);
            txtNombreEliminar.Name = "txtNombreEliminar";
            txtNombreEliminar.ReadOnly = true;
            txtNombreEliminar.Size = new Size(143, 27);
            txtNombreEliminar.TabIndex = 102;
            // 
            // txtCantidadEliminar
            // 
            txtCantidadEliminar.Enabled = false;
            txtCantidadEliminar.Location = new Point(134, 144);
            txtCantidadEliminar.Margin = new Padding(3, 4, 3, 4);
            txtCantidadEliminar.Name = "txtCantidadEliminar";
            txtCantidadEliminar.ReadOnly = true;
            txtCantidadEliminar.Size = new Size(143, 27);
            txtCantidadEliminar.TabIndex = 101;
            // 
            // txtCodigoEliminar
            // 
            txtCodigoEliminar.Enabled = false;
            txtCodigoEliminar.Location = new Point(134, 47);
            txtCodigoEliminar.Margin = new Padding(3, 4, 3, 4);
            txtCodigoEliminar.Name = "txtCodigoEliminar";
            txtCodigoEliminar.ReadOnly = true;
            txtCodigoEliminar.Size = new Size(143, 27);
            txtCodigoEliminar.TabIndex = 100;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(58, 151);
            label27.Name = "label27";
            label27.Size = new Size(72, 20);
            label27.TabIndex = 99;
            label27.Text = "Cantidad:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(86, 180);
            label28.Name = "label28";
            label28.Size = new Size(41, 20);
            label28.TabIndex = 98;
            label28.Text = "Lote:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(65, 84);
            label29.Name = "label29";
            label29.Size = new Size(67, 20);
            label29.TabIndex = 97;
            label29.Text = "Nombre:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(57, 51);
            label30.Name = "label30";
            label30.Size = new Size(81, 20);
            label30.TabIndex = 96;
            label30.Text = "Código: (*)";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatAppearance.BorderColor = Color.Red;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(134, 368);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 38);
            btnEliminar.TabIndex = 58;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BEliminar_Click;
            // 
            // tabPageLeerIndividual
            // 
            tabPageLeerIndividual.Location = new Point(4, 29);
            tabPageLeerIndividual.Name = "tabPageLeerIndividual";
            tabPageLeerIndividual.Padding = new Padding(3);
            tabPageLeerIndividual.Size = new Size(367, 456);
            tabPageLeerIndividual.TabIndex = 3;
            tabPageLeerIndividual.Text = "Leer individual";
            tabPageLeerIndividual.UseVisualStyleBackColor = true;
            // 
            // btnCancelarBusqueda
            // 
            btnCancelarBusqueda.BackColor = Color.White;
            btnCancelarBusqueda.FlatAppearance.BorderColor = Color.Red;
            btnCancelarBusqueda.FlatAppearance.BorderSize = 2;
            btnCancelarBusqueda.FlatStyle = FlatStyle.Flat;
            btnCancelarBusqueda.Location = new Point(203, 81);
            btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            btnCancelarBusqueda.Size = new Size(94, 31);
            btnCancelarBusqueda.TabIndex = 74;
            btnCancelarBusqueda.Text = "Cancelar";
            btnCancelarBusqueda.UseVisualStyleBackColor = false;
            btnCancelarBusqueda.Click += BCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(185, 517);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 73;
            label3.Text = "/2000 ";
            // 
            // txtNumeroProductos
            // 
            txtNumeroProductos.BackColor = Color.White;
            txtNumeroProductos.Enabled = false;
            txtNumeroProductos.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumeroProductos.Location = new Point(152, 513);
            txtNumeroProductos.Name = "txtNumeroProductos";
            txtNumeroProductos.ReadOnly = true;
            txtNumeroProductos.Size = new Size(27, 27);
            txtNumeroProductos.TabIndex = 72;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(67, 81);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 31);
            btnBuscar.TabIndex = 60;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BBuscar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(30, 517);
            label14.Name = "label14";
            label14.Size = new Size(116, 20);
            label14.TabIndex = 3;
            label14.Text = "# Productos:";
            // 
            // groupBoxBuscar
            // 
            groupBoxBuscar.BackColor = Color.WhiteSmoke;
            groupBoxBuscar.Controls.Add(txtBuscar);
            groupBoxBuscar.Controls.Add(cmbBuscar);
            groupBoxBuscar.Controls.Add(btnBuscar);
            groupBoxBuscar.Controls.Add(btnCancelarBusqueda);
            groupBoxBuscar.Location = new Point(509, 405);
            groupBoxBuscar.Name = "groupBoxBuscar";
            groupBoxBuscar.Size = new Size(362, 125);
            groupBoxBuscar.TabIndex = 75;
            groupBoxBuscar.TabStop = false;
            groupBoxBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(224, 36);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 76;
            // 
            // cmbBuscar
            // 
            cmbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Items.AddRange(new object[] { "Código", "Nombre", "Tipo", "Cantidad", "Lote", "PVP", "Precio Unitario", "Fecha de Caducidad", "Descuento" });
            cmbBuscar.Location = new Point(20, 36);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(151, 28);
            cmbBuscar.TabIndex = 75;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.White;
            btnOrdenar.FlatAppearance.BorderColor = Color.Fuchsia;
            btnOrdenar.FlatAppearance.BorderSize = 2;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Location = new Point(198, 39);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(94, 34);
            btnOrdenar.TabIndex = 77;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 405);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 76;
            // 
            // groupBoxOrdenar
            // 
            groupBoxOrdenar.BackColor = Color.WhiteSmoke;
            groupBoxOrdenar.Controls.Add(btnOrdenar);
            groupBoxOrdenar.Controls.Add(cmbOrdenar);
            groupBoxOrdenar.Location = new Point(970, 421);
            groupBoxOrdenar.Name = "groupBoxOrdenar";
            groupBoxOrdenar.Size = new Size(315, 109);
            groupBoxOrdenar.TabIndex = 77;
            groupBoxOrdenar.TabStop = false;
            groupBoxOrdenar.Text = "Ordenar";
            // 
            // cmbOrdenar
            // 
            cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrdenar.FormattingEnabled = true;
            cmbOrdenar.Items.AddRange(new object[] { "Código", "Nombre", "Tipo", "Cantidad", "Lote", "PVP", "Precio Unitario", "Fecha de Caducidad", "Descuento" });
            cmbOrdenar.Location = new Point(19, 43);
            cmbOrdenar.Name = "cmbOrdenar";
            cmbOrdenar.Size = new Size(151, 28);
            cmbOrdenar.TabIndex = 76;
            // 
            // Form_Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1410, 564);
            Controls.Add(groupBoxOrdenar);
            Controls.Add(label5);
            Controls.Add(groupBoxBuscar);
            Controls.Add(tabControlCrud);
            Controls.Add(label3);
            Controls.Add(label14);
            Controls.Add(txtNumeroProductos);
            Controls.Add(dgvTablaInventario);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Inventario";
            Text = "Inventario";
            Load += Form_Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaInventario).EndInit();
            tabControlCrud.ResumeLayout(false);
            tabPageCrear.ResumeLayout(false);
            tabPageCrear.PerformLayout();
            tabPageActualizar.ResumeLayout(false);
            tabPageActualizar.PerformLayout();
            tabPageEliminar.ResumeLayout(false);
            tabPageEliminar.PerformLayout();
            groupBoxBuscar.ResumeLayout(false);
            groupBoxBuscar.PerformLayout();
            groupBoxOrdenar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTablaInventario;
        private TabControl tabControlCrud;
        private TabPage tabPageCrear;
        private Label label14;
        private TextBox txtPVPCrear;
        private Label label1;
        private TextBox txtDescuentoCrear;
        private TextBox txtFechaCaducidadCrear;
        private TextBox txtPrecioUnidadCrear;
        private TextBox txtLoteCrear;
        private Label label8;
        private Label label7;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtNombreCrear;
        private TextBox txtCantidadCrear;
        private TextBox txtCodigoCrear;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label3;
        private TextBox txtNumeroProductos;
        private Button btnCancelarBusqueda;
        private Button btnAgregar;
        private TabPage tabPageActualizar;
        private TabPage tabPageEliminar;
        private GroupBox groupBoxBuscar;
        private ComboBox cmbBuscar;
        private TextBox txtBuscar;
        private Label label5;
        private TextBox txtTipoCrear;
        private Label label6;
        private TextBox txtTipoActualizar;
        private Label label12;
        private TextBox txtPVPActualizar;
        private Label label13;
        private TextBox txtDescuentoActualizar;
        private TextBox txtFechaCaducidadActualizar;
        private TextBox txtPrecioUnidadActualizar;
        private TextBox txtLoteActualizar;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtNombreActualizar;
        private TextBox txtCantidadActualizar;
        private TextBox txtCodigoActualizar;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox txtTipoEliminar;
        private Label label22;
        private TextBox txtPVPEliminar;
        private Label label23;
        private TextBox txtDescuentoEliminar;
        private TextBox txtFechaCaducidadEliminar;
        private TextBox txtPrecioUnidadEliminar;
        private TextBox txtLoteEliminar;
        private Label label24;
        private Label label25;
        private Label label26;
        private TextBox txtNombreEliminar;
        private TextBox txtCantidadEliminar;
        private TextBox txtCodigoEliminar;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Button btnLimpiar;
        private TabPage tabPageLeerIndividual;
        private Button btnOrdenar;
        private GroupBox groupBoxOrdenar;
        private ComboBox cmbOrdenar;
    }
}