using ProyectoPrototipo_1._0.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._1.CLASES.LISTADOBLEMENTEENLAZADA
{
    public class Nodo
    {
        public Class_Producto Valor { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }
    }
}
