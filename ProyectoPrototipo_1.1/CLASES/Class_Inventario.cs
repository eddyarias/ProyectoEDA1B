using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._1.CLASES.LISTADOBLEMENTEENLAZADA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*HOliwis*/
/*seal*/
namespace ProyectoPrototipo_1._0.CLASES
{
    public class Class_Inventario
    {
        public FarmaciaDbContext dbContext;
        public List<Class_Producto> productos;

        public Class_Inventario()
        {
            dbContext = new FarmaciaDbContext();
            productos = dbContext.Producto.ToList();
        }

        public ListaDoblementeEnlazada ExtraerElementos(List<Class_Producto> productillos, ListaDoblementeEnlazada listaDobleEnlazada)
        {
            foreach (var producto in productillos)
            {
                listaDobleEnlazada.AgregarAlFinal(producto);
            }
            return listaDobleEnlazada;
        }


        public void AgregarProducto(Class_Producto producto) //ordenamiento por inserción. 
        {
            int n = productos.Count;
            int i;

            // Encontrar la posición de inserción del nuevo producto
            for (i = 0; i < n; i++)
            {
                if (productos[i].codigo > producto.codigo)
                {
                    break;
                }
            }

            // Desplazar los elementos mayores hacia la derecha
            productos.Add(null); // Agregar un espacio adicional al final de la lista

            for (int j = n; j > i; j--)
            {
                productos[j] = productos[j - 1];
            }

            // Insertar el nuevo producto en la posición correcta
            productos[i] = producto;

            //Reiniciar la tabla
            dbContext.Producto.RemoveRange(dbContext.Producto);
            dbContext.SaveChanges();
            dbContext.Producto.AddRange(productos);
            dbContext.SaveChanges();

            productos = dbContext.Producto.ToList();
        }

        public int numProductos() {
            int num = 0;
            foreach (var producto in productos)
            {
                num += producto.cantidad;
            }
            return num;
        }

        //Actualizar Productos
        public void ActualizarProducto(int codigo, Class_Producto productoActualizado)
        {
            Class_Producto? productoExistente = productos.FirstOrDefault(p => p.codigo == codigo);

            if (productoExistente != null)
            {
                productoExistente.cantidad = productoActualizado.cantidad;
                productoExistente.nombre = productoActualizado.nombre;
                productoExistente.tipo = productoActualizado.tipo;
                productoExistente.lote = productoActualizado.lote;
                productoExistente.PVP = productoActualizado.PVP;
                productoExistente.precio_unitario = productoActualizado.precio_unitario;
                productoExistente.fecha_caducidad = productoActualizado.fecha_caducidad;
                productoExistente.descuento = productoActualizado.descuento;

                dbContext.Producto.Attach(productoExistente);
                dbContext.SaveChanges();
                productos = dbContext.Producto.ToList();
            }
        }
        //Eliminar productos
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

        //Búsqueda secuencial
        public List<Class_Producto> BuscarProductoPorAtributo(string atributo, string valor) 
        {
            List<Class_Producto> productosEncontrados = new List<Class_Producto>();

            // Recorre la lista de productos
            foreach (var producto in productos)
            {
                // Comprueba si el atributo coincide con el valor especificado
                if (EsAtributoIgual(producto, atributo, valor))
                {
                    productosEncontrados.Add(producto);
                }
            }

            return productosEncontrados;
        }

        //método de validación para los productos
        private bool EsAtributoIgual(Class_Producto producto, string atributo, string valor)
        {
            switch (atributo)
            {
                case "Código":
                    return producto.codigo == Convert.ToInt32(valor);
                case "Nombre":
                    return producto.nombre.IndexOf(valor, StringComparison.OrdinalIgnoreCase) >= 0;
                case "Cantidad":
                    return producto.cantidad == Convert.ToInt32(valor);
                case "Tipo":
                    return producto.tipo.IndexOf(valor, StringComparison.OrdinalIgnoreCase) >= 0;
                case "Lote":
                    return producto.lote.IndexOf(valor, StringComparison.OrdinalIgnoreCase) >= 0;
                case "PVP":
                    return producto.PVP == Convert.ToDecimal(valor);
                case "Precio Unitario":
                    return producto.precio_unitario == Convert.ToDecimal(valor);
                case "Fecha de Caducidad":
                    DateTime fecha;
                    if (DateTime.TryParse(valor, out fecha))
                    {
                        return producto.fecha_caducidad.Date.Equals(fecha.Date);
                    }
                    else
                    {
                        return false; // La cadena no es una fecha válida
                    }
                case "Descuento":
                    return producto.descuento == Convert.ToDecimal(valor);
                default:
                    return false;
            }
        }


        //ORDENAR POR QUICKSORT
        public void OrdenarProductosPorAtributo(string atributo)
        {
            
            Quicksort(productos, 0, productos.Count - 1, atributo);
        }

        private void Quicksort(List<Class_Producto> lista, int izquierda, int derecha, string atributo)
        {
            if (izquierda < derecha)
            {
                int indiceParticion = Particionar(lista, izquierda, derecha, atributo);
                Quicksort(lista, izquierda, indiceParticion - 1, atributo);
                Quicksort(lista, indiceParticion + 1, derecha, atributo);
            }
        }

        private int Particionar(List<Class_Producto> lista, int izquierda, int derecha, string atributo)
        {
            Class_Producto pivote = lista[derecha];
            int indiceMenor = izquierda - 1;

            for (int i = izquierda; i < derecha; i++)
            {
                if (EsMenor(lista[i], pivote, atributo))
                {
                    indiceMenor++;
                    Intercambiar(lista, indiceMenor, i);
                }
            }

            Intercambiar(lista, indiceMenor + 1, derecha);
            return indiceMenor + 1;
        }

        private bool EsMenor(Class_Producto producto1, Class_Producto producto2, string atributo)
        {
            switch (atributo)
            {
                case "Código":
                    return producto1.codigo < producto2.codigo;
                case "Nombre":
                    return string.Compare(producto1.nombre, producto2.nombre, StringComparison.OrdinalIgnoreCase) < 0;
                case "Tipo":
                    return string.Compare(producto1.tipo, producto2.tipo, StringComparison.OrdinalIgnoreCase) < 0;
                case "Cantidad":
                    return producto1.cantidad < producto2.cantidad;
                case "Lote":
                    return string.Compare(producto1.lote, producto2.lote, StringComparison.OrdinalIgnoreCase) < 0;
                case "PVP":
                    return producto1.PVP < producto2.PVP;
                case "Precio Unitario":
                    return producto1.precio_unitario < producto2.precio_unitario;
                case "Fecha de Caducidad":
                    return producto1.fecha_caducidad < producto2.fecha_caducidad;
                case "Descuento":
                    return producto1.descuento < producto2.descuento;
                default:
                    return false;
            }
        }


        private void Intercambiar(List<Class_Producto> lista, int indice1, int indice2)
        {
            Class_Producto temp = lista[indice1];
            lista[indice1] = lista[indice2];
            lista[indice2] = temp;
        }


    }
}
