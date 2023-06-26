using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class Class_Inventario
    {
        private FarmaciaDbContext dbContext;
        public List<Class_Producto> productos;

        public Class_Inventario()
        {
            dbContext = new FarmaciaDbContext();
            productos = new List<Class_Producto>();
            productos = dbContext.Producto.ToList();
        }

        public void AgregarProducto(Class_Producto producto)
        {
            productos.Add(producto);
            dbContext.Producto.Add(producto);
            dbContext.SaveChanges();
        }

        public List<Class_Producto> ObtenerProductos()
        {
            return productos;
        }

        public void ActualizarProducto(int codigo, Class_Producto productoActualizado)
        {
            Class_Producto? productoExistente = productos.FirstOrDefault(p => p.codigo == codigo);
            var productoExistenteBD = dbContext.Producto.FirstOrDefault(p => p.codigo == codigo);

            if (productoExistente != null && productoExistenteBD != null)
            {
                /*productoExistente.cantidad = productoActualizado.cantidad;
                productoExistente.descripcion = productoActualizado.descripcion;
                productoExistente.lote = productoActualizado.lote;
                productoExistente.PVP = productoActualizado.PVP;
                productoExistente.precio_unitario = productoActualizado.precio_unitario;
                productoExistente.fecha_cad = productoActualizado.fecha_cad;
                productoExistente.descuento = productoActualizado.descuento;
                productoExistente.iva = productoActualizado.iva;*/

                // Actualiza las propiedades del producto existente con los valores del producto actualizado
                productoExistenteBD.cantidad = productoActualizado.cantidad;
                productoExistenteBD.descripcion = productoActualizado.descripcion;
                productoExistenteBD.lote = productoActualizado.lote;
                productoExistenteBD.PVP = productoActualizado.PVP;
                productoExistenteBD.precio_unitario = productoActualizado.precio_unitario;
                productoExistenteBD.fecha_cad = productoActualizado.fecha_cad;
                productoExistenteBD.descuento = productoActualizado.descuento;
                productoExistenteBD.iva = productoActualizado.iva;

                // Guarda los cambios en la base de datos
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Class_Producto> BuscarProducto(int codigo, string descripcion, string lote, decimal pvp, decimal precioUnitario, DateTime fechaCaducidad, decimal descuento, decimal iva)
        {
            var filteredProductos = productos.AsQueryable();

            if (codigo != 0)
            {
                filteredProductos = filteredProductos.Where(p => p.codigo == codigo);
            }

            if (!string.IsNullOrEmpty(descripcion))
            {
                filteredProductos = filteredProductos.Where(p => p.descripcion.Contains(descripcion));
            }

            if (!string.IsNullOrEmpty(lote))
            {
                filteredProductos = filteredProductos.Where(p => p.lote.Contains(lote));
            }

            if (pvp != 0)
            {
                filteredProductos = filteredProductos.Where(p => p.PVP == pvp);
            }

            if (precioUnitario != 0)
            {
                filteredProductos = filteredProductos.Where(p => p.precio_unitario == precioUnitario);
            }

            if (fechaCaducidad != DateTime.MinValue)
            {
                filteredProductos = filteredProductos.Where(p => p.fecha_cad == fechaCaducidad);
            }

            if (descuento != 0)
            {
                filteredProductos = filteredProductos.Where(p => p.descuento == descuento);
            }

            if (iva != 0)
            {
                filteredProductos = filteredProductos.Where(p => p.iva == iva);
            }

            return filteredProductos;
        }

        public void EliminarProducto(int codigo)
        {
            Class_Producto? producto = productos.FirstOrDefault(p => p.codigo == codigo);

            if (producto != null)
            {
                //productos.Remove(producto);
                dbContext.Producto.Remove(producto);
                dbContext.SaveChanges();
                productos = dbContext.Producto.ToList();
            }
        }

    }
}
