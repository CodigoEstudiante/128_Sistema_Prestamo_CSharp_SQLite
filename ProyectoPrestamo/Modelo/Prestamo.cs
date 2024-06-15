using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Modelo
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public string NumeroOperacion { get; set; }
        public string FechaRegistro { get; set; }
        public TipoPago oTipoPago { get; set; }
        public TipoMoneda oTipoMoneda { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string MontoPrestamo { get; set; }
        public string Interes { get; set; }
        public int NumeroCuotas { get; set; }
        public string MontoCuota { get; set; }
        public string TotalIntereses { get; set; }
        public string MontoTotal { get; set; }
        public string NombreCliente { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Correo { get; set; }
        public string NumeroTelefono { get; set; }
        public string Estado { get; set; }
        public string Clausula { get; set; }
    }
}
