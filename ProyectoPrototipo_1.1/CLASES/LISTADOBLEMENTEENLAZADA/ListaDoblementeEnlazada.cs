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
                cabeza.Anterior = cola;
                cola.Siguiente = cabeza;
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
                cola.Siguiente = cabeza;
                cabeza.Anterior = cola;
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
                        cabeza.Anterior = cola;
                        cola.Siguiente = cabeza;
                    }

                    if (actual.Siguiente != null)
                    {
                        actual.Siguiente.Anterior = actual.Anterior;
                    }
                    else
                    {
                        cola = actual.Anterior;
                        cola.Siguiente = cabeza;
                        cabeza.Anterior = cola;
                    }

                    break;
                }

                actual = actual.Siguiente;
            }
        }

        public Nodo ObtenerNodoAnterior(Nodo nodo)
        {
            //if (nodo.Anterior == null) {
            //    return cola;
            //}
            //else
            //{
                return nodo.Anterior;
            //}
            
        }

        public Nodo ObtenerNodoSiguiente(Nodo nodo)
        {
            //if (nodo.Siguiente == null) {
            //    return cabeza;
            //}else{
            return nodo.Siguiente;
            //}
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
