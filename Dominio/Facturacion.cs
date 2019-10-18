using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Facturacion
    {
        public int Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Producto[] Productos { get; set; }
        public float Total { get; set; }
        public string Nota { get; set; }
        public MedioPago MedioPago { get; set; }
    }
}
