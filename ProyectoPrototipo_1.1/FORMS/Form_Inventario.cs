﻿using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._0.CLASES;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoPrototipo_1._0
{
    public partial class Form_Inventario : Form
    {
        Class_Inventario inventario;
        public Form_Inventario()
        {
            this.inventario = new Class_Inventario();
            InitializeComponent();
            // Suscribirse al evento SelectedIndexChanged del TabControl
            tabControl2.SelectedIndexChanged += tabControl2_SelectedIndexChanged;

        }

        private void Form_Inventario_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

            // READ: inventario en el dataGridView1
            dgvTablaInventario.DataSource = inventario.productos;
        }

        private void ClearTextBoxes()
        {
            txtNumeroProductos.Clear();
            txtDescuentoCrear.Clear();
            txtFechaCaducidadCrear.Clear();
            txtPrecioUnidadCrear.Clear();
            txtLoteCrear.Clear();
            txtNombreCrear.Clear();
            txtCantidadCrear.Clear();
            txtCodigoCrear.Clear();
            txtPVPCrear.Clear();

            //tabPage4.Text = string.Empty;
        }
        private void dgvTablaInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el código del producto desde la fila seleccionada
                int codigo = Convert.ToInt32(dgvTablaInventario.Rows[e.RowIndex].Cells["Codigo"].Value);

                // Buscar el producto en la lista de productos del inventario
                Class_Producto? productoToUpdate = inventario.productos.FirstOrDefault(p => p.codigo == codigo);

                if (productoToUpdate != null)
                {
                    txtCodigoActualizar.Text = productoToUpdate.codigo.ToString();
                    txtNombreActualizar.Text = productoToUpdate.nombre;
                    txtTipoActualizar.Text = productoToUpdate.tipo;
                    txtCantidadActualizar.Text = productoToUpdate.cantidad.ToString();
                    txtLoteActualizar.Text = productoToUpdate.lote;
                    txtPVPActualizar.Text = productoToUpdate.PVP.ToString();
                    txtPrecioUnidadActualizar.Text = productoToUpdate.precio_unitario.ToString();
                    txtFechaCaducidadActualizar.Text = productoToUpdate.fecha_caducidad.ToString();
                    txtDescuentoActualizar.Text = productoToUpdate.descuento.ToString();

                    txtCodigoEliminar.Text = productoToUpdate.codigo.ToString();
                    txtNombreEliminar.Text = productoToUpdate.nombre;
                    txtTipoEliminar.Text = productoToUpdate.tipo;
                    txtCantidadEliminar.Text = productoToUpdate.cantidad.ToString();
                    txtLoteEliminar.Text = productoToUpdate.lote;
                    txtPVPEliminar.Text = productoToUpdate.PVP.ToString();
                    txtPrecioUnidadEliminar.Text = productoToUpdate.precio_unitario.ToString();
                    txtFechaCaducidadEliminar.Text = productoToUpdate.fecha_caducidad.ToString();
                    txtDescuentoEliminar.Text = productoToUpdate.descuento.ToString();

                }
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados por el usuario
            int codigo;
            if (!int.TryParse(txtCodigoCrear.Text, out codigo))
            {
                MessageBox.Show("Ingrese un código válido.");
                return; // Salir del método sin crear el producto
            }

            int cantidad;
            if (!int.TryParse(txtCantidadCrear.Text, out cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return; // Salir del método sin crear el producto
            }

            string nombre = txtNombreCrear.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese una descripción válida.");
                return; // Salir del método sin crear el producto
            }

            string lote = txtLoteCrear.Text.Trim();
            if (string.IsNullOrEmpty(lote))
            {
                MessageBox.Show("Ingrese un lote válido.");
                return; // Salir del método sin crear el producto
            }

            decimal pvp;
            if (!decimal.TryParse(txtPVPCrear.Text, out pvp))
            {
                MessageBox.Show("Ingrese un PVP válido.");
                return; // Salir del método sin crear el producto
            }

            decimal precioUnitario;
            if (!decimal.TryParse(txtPrecioUnidadCrear.Text, out precioUnitario))
            {
                MessageBox.Show("Ingrese un precio unitario válido.");
                return; // Salir del método sin crear el producto
            }

            DateTime fechaCaducidad;
            if (!DateTime.TryParse(txtFechaCaducidadCrear.Text, out fechaCaducidad))
            {
                MessageBox.Show("Ingrese una fecha de caducidad válida.");
                return; // Salir del método sin crear el producto
            }

            decimal descuento;
            if (!decimal.TryParse(txtDescuentoCrear.Text, out descuento))
            {
                MessageBox.Show("Ingrese un descuento válido.");
                return; // Salir del método sin crear el producto
            }

            string tipo = txtTipoCrear.Text.Trim(); ;
            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Ingrese un tipo válido.");
                return; // Salir del método sin crear el producto
            }

            // Verificar si el código de producto ya existe en la base de datos
            /*bool codigoExists = dbContext.Producto.Any(p => p.codigo == codigo);*/

            bool codigoExists = inventario.productos.Any(p => p.codigo == codigo);

            if (codigoExists)
            {
                MessageBox.Show("El código de producto ya existe. Ingrese un código único.");
                return; // Salir del método sin crear el producto
            }


            // Crear una nueva instancia de Producto y asignar los valores
            Class_Producto newProducto = new Class_Producto
            {
                codigo = codigo,
                cantidad = cantidad,
                nombre = nombre,
                lote = lote,
                PVP = pvp,
                precio_unitario = precioUnitario,
                fecha_caducidad = fechaCaducidad,
                descuento = descuento,
                tipo = tipo,
            };

            // Agregar el nuevo producto al inventario
            inventario.AgregarProducto(newProducto);
            MessageBox.Show("Producto creado exitosamente");
            // Actualizar el origen de datos del DataGridView con el inventario
            dgvTablaInventario.DataSource = inventario.productos.ToList();
            ClearTextBoxes();
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            // Obtener el código del producto a actualizar
            int codigo = int.Parse(txtCodigoActualizar.Text);

            // Crear una instancia de Class_Producto con los datos actualizados
            Class_Producto productoActualizado = new Class_Producto
            {
                cantidad = int.Parse(txtCantidadActualizar.Text),
                nombre = txtNombreActualizar.Text,
                lote = txtLoteActualizar.Text,
                PVP = decimal.Parse(txtPVPActualizar.Text),
                precio_unitario = decimal.Parse(txtPrecioUnidadActualizar.Text),
                fecha_caducidad = DateTime.Parse(txtFechaCaducidadActualizar.Text),
                descuento = decimal.Parse(txtDescuentoActualizar.Text),
                tipo = txtTipoActualizar.Text
            };

            // Llamar al método ActualizarProducto del inventario
            inventario.ActualizarProducto(codigo, productoActualizado);
            MessageBox.Show("Producto actualizado exitosamente");
            // Actualizar el origen de datos del DataGridView con el inventario
            dgvTablaInventario.DataSource = inventario.productos.ToList();
            ClearTextBoxes();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el código del producto desde el TextBox
            int codigo = Convert.ToInt32(txtCodigoEliminar.Text);

            // Verificar si el código de producto existe en el inventario
            bool codigoExists = inventario.productos.Any(p => p.codigo == codigo);

            if (codigoExists)
            {
                // Mostrar el diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el producto?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Eliminar el producto del inventario
                    inventario.EliminarProducto(codigo);
                    MessageBox.Show("Producto eliminado exitosamente");

                    // Actualizar el DataGridView con la lista de productos del inventario
                    dgvTablaInventario.DataSource = inventario.productos.ToList();
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("No se encontró el producto");
                ClearTextBoxes();
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de búsqueda
            int codigo;
            int.TryParse(txtBuscar.Text, out codigo);

            string nombre = txtBuscar.Text.Trim();
            string tipo = txtBuscar.Text.Trim();
            string lote = txtBuscar.Text.Trim();
            decimal pvp;
            decimal.TryParse(txtBuscar.Text, out pvp);
            decimal precioUnitario;
            decimal.TryParse(txtBuscar.Text, out precioUnitario);
            DateTime fechaCaducidad;
            DateTime.TryParse(txtBuscar.Text, out fechaCaducidad);
            decimal descuento;
            decimal.TryParse(txtBuscar.Text, out descuento);


            IEnumerable<Class_Producto> productosEncontrados = inventario.BuscarProducto(codigo, nombre, tipo, lote, pvp, precioUnitario, fechaCaducidad, descuento);

            // Mostrar los productos filtrados en el DataGridView
            dgvTablaInventario.DataSource = productosEncontrados.ToList();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            dgvTablaInventario.DataSource = inventario.productos.ToList();
            ClearTextBoxes();
        }

        private DataGridView dataGridView1;

        private System.Windows.Forms.Button bttAnterior;
        private System.Windows.Forms.Button bttSiguiente;
        private System.Windows.Forms.Button bttInicio;
        private System.Windows.Forms.Button bttFinal;

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //375; 489
            TabPage selectedTab = tabControl2.SelectedTab;
            // Verificar si el nombre del tab seleccionado es igual a "NombreDeseado"
            if (tabControl2.SelectedTab.Name == "tabPageLeerIndividual")
            {
                this.dgvTablaInventario.Visible = false;
                this.label5.Visible = false;
                this.groupBox1.Visible = false;
                tabControl2.Width = 930;

                dataGridView1 = new DataGridView();
                dataGridView1.Width = 500; // Establecer el ancho deseado del DataGridView
                dataGridView1.Height = 300; // Establecer la altura deseada del DataGridView

                // Crear los botones
                bttAnterior = new System.Windows.Forms.Button();
                bttAnterior.Text = "ANTERIOR";

                bttSiguiente = new System.Windows.Forms.Button();
                bttSiguiente.Text = "SIGUIENTE";

                bttInicio = new System.Windows.Forms.Button();
                bttInicio.Text = "INICIO";

                bttFinal = new System.Windows.Forms.Button();
                bttFinal.Text = "FINAL";

                // Crear el contenedor (Panel)
                Panel panel = new Panel();
                panel.Width = 930; // Establecer el ancho deseado del Panel
                panel.Height = 489; // Establecer la altura deseada del Panel

                // Calcular la posición horizontal para centrar el Panel
                int panelX = (tabControl2.Width - panel.Width) / 2;
                // Calcular la posición vertical para centrar el Panel
                int panelY = (tabControl2.Height - panel.Height) / 2;
                // Establecer la posición del Panel
                panel.Location = new System.Drawing.Point(panelX, panelY);

                int x = (panel.Width - dataGridView1.Width) / 2;
                // Calcular la posición vertical para centrar el DataGridView
                int y = (panel.Height - dataGridView1.Height) / 2;
                // Establecer la posición del DataGridView
                dataGridView1.Location = new System.Drawing.Point(x, y);

               panel.Controls.Add(dataGridView1);


                bttAnterior.Width = 100;
                bttAnterior.Height = 60;
                bttSiguiente.Width = 100;
                bttSiguiente.Height = 60;
                // Establecer la posición y tamaño de los botones dentro del Panel
                bttAnterior.Location = new System.Drawing.Point(20, 200); // Ajustar la posición del botón izquierdo dentro del Panel
                bttSiguiente.Location = new System.Drawing.Point(panel.Width - bttSiguiente.Width - 20, 200); // Ajustar la posición del botón derecho dentro del Panel
                
                panel.Controls.Add(bttAnterior);
                panel.Controls.Add(bttSiguiente);

                bttInicio.Width = 80;
                bttInicio.Height = 30;
                bttFinal.Width = 80;
                bttFinal.Height = 30;
                // Establecer la posición y tamaño de los botones inferiores dentro del Panel
                bttInicio.Location = new System.Drawing.Point(350, dataGridView1.Location.Y + dataGridView1.Height + 10); // Ajustar la posición del primer botón inferior
                bttFinal.Location = new System.Drawing.Point(bttInicio.Location.X + bttInicio.Width + 50, dataGridView1.Location.Y + dataGridView1.Height + 10); // Ajustar la posición del segundo botón inferior
                
                
                panel.Controls.Add(bttInicio);
                panel.Controls.Add(bttFinal);

                // Agregar el Panel al TabControl
                tabControl2.TabPages[3].Controls.Add(panel);

            }
            else {
                this.dgvTablaInventario.Visible = true;
                this.dgvTablaInventario.Enabled = true;
                this.label5.Visible = true;
                this.groupBox1.Visible = true;
                tabControl2.Width = 375;
            }
        }
    }
}