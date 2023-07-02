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

        public Nodo BuscarNodoPorCodigo(int codigo)
        {
            Nodo actual = cabeza;

            while (actual != null)
            {
                if (actual.Valor.codigo == codigo)
                {
                    return actual;
                }

                actual = actual.Siguiente;
            }

            return null;
        }

        public Nodo ObtenerNodoAnterior(Nodo nodo)
        {
            if (actual == cabeza) {
                return cola;
            }
            else
            {
                return nodo.Anterior;
            }
            
        }

        public Nodo ObtenerNodoSiguiente(Nodo nodo)
        {
            if(actual  == cola)
            {
                return cabeza;
            }
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
        public void ImprimirLista()
        {
            Nodo actual = cabeza;

            while (actual != null)
            {
                Console.WriteLine(actual.Valor); // Suponiendo que la clase Class_Producto tiene un método ToString() adecuado
                actual = actual.Siguiente;
            }
        }

    }
}
