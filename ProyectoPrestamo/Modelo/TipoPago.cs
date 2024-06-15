using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Modelo
{
    public class TipoPago
    {
        public int IdTipoPago { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public int AplicaDias { get; set; }
    }
}
