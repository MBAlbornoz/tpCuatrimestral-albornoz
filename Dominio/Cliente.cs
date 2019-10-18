using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public Email Email { get; set; }
        public Telefono Telefono { get; set; }
        public Direccion Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
