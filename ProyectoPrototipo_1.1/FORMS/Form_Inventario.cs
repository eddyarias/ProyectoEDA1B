using Microsoft.EntityFrameworkCore;
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
            textBox15.Clear();
            //tabPage4.Text = string.Empty;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el código del producto desde la fila seleccionada
                int codigo = Convert.ToInt32(dgvTablaInventario.Rows[e.RowIndex].Cells["Codigo"].Value);

                // Buscar el producto en la lista de productos del inventario
                Class_Producto? productoToUpdate = inventario.productos.FirstOrDefault(p => p.codigo == codigo);

                if (productoToUpdate != null)
                {
                    txtCodigoCrear.Text = productoToUpdate.codigo.ToString();
                    txtCantidadCrear.Text = productoToUpdate.cantidad.ToString();
                    txtNombreCrear.Text = productoToUpdate.descripcion;
                    txtLoteCrear.Text = productoToUpdate.lote;
                    txtPVPCrear.Text = productoToUpdate.PVP.ToString();
                    txtPrecioUnidadCrear.Text = productoToUpdate.precio_unitario.ToString();
                    txtFechaCaducidadCrear.Text = productoToUpdate.fecha_cad.ToString();
                    txtDescuentoCrear.Text = productoToUpdate.descuento.ToString();
                    textBox15.Text = productoToUpdate.iva.ToString();
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

            string descripcion = txtNombreCrear.Text.Trim();
            if (string.IsNullOrEmpty(descripcion))
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

            decimal iva;
            if (!decimal.TryParse(textBox15.Text, out iva))
            {
                MessageBox.Show("Ingrese un IVA válido.");
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
                descripcion = descripcion,
                lote = lote,
                PVP = pvp,
                precio_unitario = precioUnitario,
                fecha_cad = fechaCaducidad,
                descuento = descuento,
                iva = iva
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
            int codigo = int.Parse(txtCodigoCrear.Text);

            // Crear una instancia de Class_Producto con los datos actualizados
            Class_Producto productoActualizado = new Class_Producto
            {
                cantidad = int.Parse(txtCantidadCrear.Text),
                descripcion = txtNombreCrear.Text,
                lote = txtLoteCrear.Text,
                PVP = decimal.Parse(txtPVPCrear.Text),
                precio_unitario = decimal.Parse(txtPrecioUnidadCrear.Text),
                fecha_cad = DateTime.Parse(txtFechaCaducidadCrear.Text),
                descuento = decimal.Parse(txtDescuentoCrear.Text),
                iva = decimal.Parse(textBox15.Text)
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
            int codigo = Convert.ToInt32(txtCodigoCrear.Text);

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
            int.TryParse(txtCodigoCrear.Text, out codigo);

            string descripcion = txtCantidadCrear.Text.Trim();
            string lote = txtNombreCrear.Text.Trim();
            decimal pvp;
            decimal.TryParse(txtLoteCrear.Text, out pvp);
            decimal precioUnitario;
            decimal.TryParse(txtPVPCrear.Text, out precioUnitario);
            DateTime fechaCaducidad;
            DateTime.TryParse(txtPrecioUnidadCrear.Text, out fechaCaducidad);
            decimal descuento;
            decimal.TryParse(txtDescuentoCrear.Text, out descuento);
            decimal iva;
            decimal.TryParse(textBox15.Text, out iva);

            IEnumerable<Class_Producto> productosEncontrados = inventario.BuscarProducto(codigo, descripcion, lote, pvp, precioUnitario, fechaCaducidad, descuento, iva);

            // Mostrar los productos filtrados en el DataGridView
            dgvTablaInventario.DataSource = productosEncontrados.ToList();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            dgvTablaInventario.DataSource = inventario.productos.ToList();
            ClearTextBoxes();
        }
    }
}