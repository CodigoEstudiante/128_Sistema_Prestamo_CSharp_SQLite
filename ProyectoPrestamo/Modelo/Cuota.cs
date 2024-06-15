using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Modelo
{
    public class Cuota
    {
        public int IdCuota { get; set; }
        public Prestamo oPrestamo { get; set; }
        public int NumeroCuota { get; set; }
        public string FechaPagoCuota { get; set; }
        public decimal MontoCuota { get; set; }
        public string EstadoCuota { get; set; }
        public string FechaPago { get; set; }
        public int ProximoPago { get; set; }
    }
}
