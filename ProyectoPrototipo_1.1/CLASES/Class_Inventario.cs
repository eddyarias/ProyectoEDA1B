using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._1.CLASES.LISTADOBLEMENTEENLAZADA;
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
        public List<Class_Producto> productosDB;
        private Nodo cabeza;
        private Nodo cola;
        private Nodo actual;

        public Class_Inventario()
        {
            dbContext = new FarmaciaDbContext();
            productosDB = new List<Class_Producto>();
            cabeza = null;
            cola = null;
            actual = null;

            // Obtener los productos de la base de datos y construir la lista doblemente enlazada
            productosDB = dbContext.Producto.ToList();
            foreach (var producto in productosDB)
            {
                AgregarAlFinal(producto);
            }
        }

        public void AgregarAlInicio(Class_Producto valor)
        {
            var nuevoNodo = new Nodo { Valor = valor };

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
                actual = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = cabeza;
                cabeza.Anterior = nuevoNodo;
                cabeza = nuevoNodo;
            }

            // Agregar el producto al DbContext
            dbContext.Producto.Add(valor);
            dbContext.SaveChanges(); // Guardar cambios en la base de datos
        }

        public void AgregarAlFinal(Class_Producto valor)
        {
            var nuevoNodo = new Nodo { Valor = valor };

            if (cola == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
                actual = nuevoNodo;
            }
            else
            {
                nuevoNodo.Anterior = cola;
                cola.Siguiente = nuevoNodo;
                cola = nuevoNodo;
            }

            // Agregar el producto al DbContext
            dbContext.Producto.Add(valor);
            dbContext.SaveChanges();// Guardar cambios en la base de datos
        }


        public void Eliminar(Class_Producto valor)
        {
            Nodo actual = cabeza;

            while (actual != null)
            {
                if (actual.Valor == valor)
                {
                    if (actual.Anterior != null)
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                    }
                    else
                    {
                        cabeza = actual.Siguiente;
                    }

                    if (actual.Siguiente != null)
                    {
                        actual.Siguiente.Anterior = actual.Anterior;
                    }
                    else
                    {
                        cola = actual.Anterior;
                    }

                    // Eliminar el producto del DbContext
                    dbContext.Producto.Remove(valor);
                    dbContext.SaveChanges(); // Guardar cambios en la base de datos
                    productosDB = dbContext.Producto.ToList();

                    break;
                }

                actual = actual.Siguiente;
            }
        }

        public Nodo BuscarNodoPorAtributo<T>(Func<Class_Producto, T> atributo, T valor)
        {
            Nodo actual = cabeza;

            while (actual != null)
            {
                if (atributo(actual.Valor).Equals(valor))
                {
                    return actual;
                }

                actual = actual.Siguiente;
            }

            return null;
        }

        public Nodo ObtenerNodoAnterior(Nodo nodo)
        {
            return nodo.Anterior;
        }

        public Nodo ObtenerNodoSiguiente(Nodo nodo)
        {
            return nodo.Siguiente;
        }

        public Nodo ObtenerPrimerNodo()
        {
            return cabeza;
        }

        public Nodo ObtenerUltimoNodo()
        {
            return cola;
        }


        public void ActualizarProducto(int codigo, Class_Producto productoActualizado)
        {
            var productoExistenteBD = dbContext.Producto.FirstOrDefault(p => p.codigo == codigo);

            Nodo nodoExistente = cabeza;

            while (nodoExistente != null)
            {
                if (nodoExistente.Valor.codigo == codigo)
                {
                    // El nodo existe, actualiza las propiedades del producto existente con los valores del producto actualizado
                    nodoExistente.Valor.cantidad = productoActualizado.cantidad;
                    nodoExistente.Valor.nombre = productoActualizado.nombre;
                    nodoExistente.Valor.tipo = productoActualizado.tipo;
                    nodoExistente.Valor.lote = productoActualizado.lote;
                    nodoExistente.Valor.PVP = productoActualizado.PVP;
                    nodoExistente.Valor.precio_unitario = productoActualizado.precio_unitario;
                    nodoExistente.Valor.fecha_caducidad = productoActualizado.fecha_caducidad;
                    nodoExistente.Valor.descuento = productoActualizado.descuento;

                    // Actualiza los cambios en el DbContext
                    dbContext.Entry(productoExistenteBD).CurrentValues.SetValues(productoActualizado);
                    dbContext.SaveChanges();
                   // productosDB = dbContext.Producto.ToList();

                    return;
                }

                nodoExistente = nodoExistente.Siguiente;
            }
        }
    }
}
