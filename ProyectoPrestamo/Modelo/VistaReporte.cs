using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Modelo
{
    public class VistaReporte
    {
        [DisplayName("Nro. Operación")]
        public string NroOperacion { get; set; }
        [DisplayName("Fecha Registro")]
        public string FechaRegistro { get; set; }
        [DisplayName("Forma de Pago")]
        public string FormaPago { get; set; }
        [DisplayName("Tipo de Moneda")]
        public string TipoMoneda { get; set; }
        [DisplayName("Fecha de Inicio")]
        public string FechaInicio { get; set; }
        [DisplayName("Monto de Préstamo")]
        public string MontoPrestamo { get; set; }
        [DisplayName("% Interes")]
        public string Interes { get; set; }
        [DisplayName("Nro. Cuotas")]
        public string NroCuotas { get; set; }
        [DisplayName("Monto x Cuota")]
        public string MontoporCuota { get; set; }
        [DisplayName("Total Interes")]
        public string TotalInteres { get; set; }
        [DisplayName("Monto Total")]
        public string MontoTotal { get; set; }
        [DisplayName("Nombre Cliente")]
        public string NombreCliente { get; set; }
        [DisplayName("Tipo Documento")]
        public string TipoDocumento { get; set; }
        [DisplayName("Nro. Documento")]
        public string NroDocumento { get; set; }
        [DisplayName("Dirección")]
        public string Direccion { get; set; }
        [DisplayName("Ciudad")]
        public string Ciudad { get; set; }
        [DisplayName("Correo")]
        public string Correo { get; set; }
        [DisplayName("Nro. Telefono / Celular")]
        public string NroTelefonoCelular { get; set; }
        public string Estado { get; set; }
    }
}
