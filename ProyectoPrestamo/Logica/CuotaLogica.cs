using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Logica
{
    public class CuotaLogica
    {
        private static CuotaLogica _instancia = null;

        public CuotaLogica()
        {

        }

        public static CuotaLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new CuotaLogica();
                return _instancia;
            }
        }

        public List<Cuota> Listar(int idprestamo)
        {
            List<Cuota> oLista = new List<Cuota>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdCuota, IdPrestamo, NumeroCuota, strftime('%d/%m/%Y', date(FechaPagoCuota))[FechaPagoCuota],");
                    query.AppendLine("MontoCuota,EstadoCuota,iif(FechaPago= '','', strftime('%d/%m/%Y', date(FechaPago)))[FechaPago],ProximoPago");
                    query.AppendLine("from CUOTA");
                    query.AppendLine("where IdPrestamo = @pid");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pid", idprestamo));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Cuota()
                            {
                                IdCuota = Convert.ToInt32(dr["IdCuota"].ToString()),
                                oPrestamo = new Prestamo() { IdPrestamo = Convert.ToInt32(dr["IdPrestamo"].ToString()) },
                                NumeroCuota = Convert.ToInt32(dr["NumeroCuota"].ToString()),
                                FechaPagoCuota = dr["FechaPagoCuota"].ToString(),
                                MontoCuota = Convert.ToDecimal(dr["MontoCuota"].ToString()),
                                EstadoCuota = dr["EstadoCuota"].ToString(),
                                FechaPago = dr["FechaPago"].ToString(),
                                ProximoPago = Convert.ToInt32(dr["ProximoPago"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Cuota>();
            }
            return oLista;
        }

    }
}
