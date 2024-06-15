using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Logica
{
    public class TipoPagoLogica
    {
        private static TipoPagoLogica _instancia = null;

        public TipoPagoLogica()
        {

        }

        public static TipoPagoLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new TipoPagoLogica();
                return _instancia;
            }
        }


        public List<TipoPago> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<TipoPago> oLista = new List<TipoPago>();

            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select IdTipoPago,Descripcion,Valor,AplicaDias from TIPO_PAGO;";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new TipoPago()
                            {
                                IdTipoPago = int.Parse(dr["IdTipoPago"].ToString()),
                                Descripcion = dr["Descripcion"].ToString(),
                                Valor = int.Parse(dr["Valor"].ToString()),
                                AplicaDias = int.Parse(dr["AplicaDias"].ToString())
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<TipoPago>();
                mensaje = ex.Message;
            }


            return oLista;
        }
    }
}
