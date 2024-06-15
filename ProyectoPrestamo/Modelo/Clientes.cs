using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Modelo
{
    public class Clientes
    {
        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Correo { get; set; }
        public string NumeroTelefono { get; set; }
    }
}
