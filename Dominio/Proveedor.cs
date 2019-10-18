using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public int Id { get; set; }
        public Email Email { get; set; }
        public Direccion Direccion { get; set; }
        public Telefono Telefono { get; set; }
        
    }
}
