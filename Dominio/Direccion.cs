using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public int Id { get; set; }
        public string NombreDireccion { get; set; }
        public int numero { get; set; }
        public int CodigoPostal { get; set; }
        public Ciudad Ciudad { get; set; }
        public Provincia Provincia { get; set; }
        public Pais Pais { get; set; }
    }
}
