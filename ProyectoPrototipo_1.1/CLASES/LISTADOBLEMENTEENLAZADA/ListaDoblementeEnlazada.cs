using ProyectoPrototipo_1._0.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._1.CLASES.LISTADOBLEMENTEENLAZADA
{
    public class ListaDoblementeEnlazada
    {
        private Nodo cabeza;
        private Nodo cola;
        private Nodo actual;

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

                    break;
                }

                actual = actual.Siguiente;
            }
        }

        public Nodo Presentar()
        {
            if (actual != null)
            {
                return actual;
            }
            else
            {
                return null;
            }
        }

        public Nodo PresentarSiguiente()
        {
            if (actual != null && actual.Siguiente != null)
            {
                actual = actual.Siguiente;
                return actual;
            }
            else
            {
                return null;
            }
        }

        public Nodo PresentarAnterior()
        {
            if (actual != null && actual.Anterior != null)
            {
                actual = actual.Anterior;
                return actual;
            }
            else
            {
                return null;
            }
        }

        public Nodo PresentarInicio()
        {
            if (cabeza != null)
            {
                actual = cabeza;
                return actual;
            }
            else
            {
                return null;
            }
        }

        public Nodo PresentarFinal()
        {
            if (cola != null)
            {
                actual = cola;
                return actual;
            }
            else
            {
                return null;
            }
        }
    }
}
