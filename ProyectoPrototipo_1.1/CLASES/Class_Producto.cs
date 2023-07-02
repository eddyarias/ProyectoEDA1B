using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class Class_Producto
    {
        [Key]
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public int cantidad { get; set; }
        public string lote { get; set; }
        public decimal PVP { get; set; }
        public decimal precio_unitario { get; set; }
        public DateTime fecha_caducidad { get; set; }
        public decimal descuento { get; set; }
    }

}
