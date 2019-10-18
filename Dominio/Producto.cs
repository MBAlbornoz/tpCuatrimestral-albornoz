using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string Imagen { get; set; }
        public int Cantidad { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
