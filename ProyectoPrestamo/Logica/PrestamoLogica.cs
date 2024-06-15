using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Logica
{
    public class PrestamoLogica
    {

        private static PrestamoLogica _instancia = null;

        public PrestamoLogica()
        {

        }

        public static PrestamoLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new PrestamoLogica();
                return _instancia;
            }
        }

        public int ObtenerCorrelativo(out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from PRESTAMO");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }


        public int Registrar(Prestamo oPrestamo, List<Cuota> oListaCuota, out string mensaje)
        {

            mensaje = string.Empty;
            int respuesta = 0;
            SQLiteTransaction objTransaccion = null;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    objTransaccion = conexion.BeginTransaction();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("CREATE TEMP TABLE _TEMP(id INTEGER);");

                    query.AppendLine(string.Format("Insert into PRESTAMO(NumeroOperacion,FechaRegistro,IdTipoPago,IdTipoMoneda,FechaInicio,FechaFin,MontoPrestamo,Interes,NumeroCuotas,MontoCuota,TotalIntereses,MontoTotal,NombreCliente,TipoDocumento,NumeroDocumento,Direccion,Ciudad,Correo,NumeroTelefono,Estado,Clausula) values('{0}','{1}',{2},{3},'{4}','{5}','{6}',{7},{8},'{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}');",
                        oPrestamo.NumeroOperacion,
                        oPrestamo.FechaRegistro,
                        oPrestamo.oTipoPago.IdTipoPago,
                        oPrestamo.oTipoMoneda.IdTipoMoneda,
                        oPrestamo.FechaInicio,
                        oPrestamo.FechaFin,
                        oPrestamo.MontoPrestamo,
                        oPrestamo.Interes,
                        oPrestamo.NumeroCuotas,
                        oPrestamo.MontoCuota,
                        oPrestamo.TotalIntereses,
                        oPrestamo.MontoTotal,
                        oPrestamo.NombreCliente,
                        oPrestamo.TipoDocumento,
                        oPrestamo.NumeroDocumento,
                        oPrestamo.Direccion,
                        oPrestamo.Ciudad,
                        oPrestamo.Correo,
                        oPrestamo.NumeroTelefono,
                        oPrestamo.Estado,
                        oPrestamo.Clausula
                        ));
                    
                    query.AppendLine("INSERT INTO _TEMP (id) VALUES (last_insert_rowid());");

                    foreach (Cuota c in oListaCuota)
                    {
                        query.AppendLine(string.Format("insert into CUOTA(IdPrestamo,NumeroCuota,FechaPagoCuota,MontoCuota,EstadoCuota,ProximoPago) values({0},{1},'{2}','{3}','{4}',{5});",
                            "(select id from _TEMP)",
                            c.NumeroCuota,
                            c.FechaPagoCuota,
                            c.MontoCuota.ToString("0.00"),
                            c.EstadoCuota,
                            c.ProximoPago
                            ));
                    }

                    query.AppendLine(string.Format("INSERT INTO CLIENTES(NombreCompleto,TipoDocumento,NumeroDocumento,Direccion,Ciudad,Correo,NumeroTelefono) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",
                        oPrestamo.NombreCliente,
                        oPrestamo.TipoDocumento,
                        oPrestamo.NumeroDocumento,
                        oPrestamo.Direccion,
                        oPrestamo.Ciudad,
                        oPrestamo.Correo,
                        oPrestamo.NumeroTelefono));

                    query.AppendLine("DROP TABLE _TEMP;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Transaction = objTransaccion;
                    respuesta = cmd.ExecuteNonQuery();


                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo registrar el alquiler";
                    }

                    objTransaccion.Commit();

                }
                catch (Exception ex)
                {
                    objTransaccion.Rollback();
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }


            return respuesta;
        }


        public Prestamo Obtener(string numerooperacion, string numerodocumento)
        {
            Prestamo objeto = new Prestamo();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.IdPrestamo,p.NumeroOperacion,strftime('%d/%m/%Y', date(p.FechaRegistro))[FechaRegistro],");
                    query.AppendLine("tp.IdTipoPago,tp.Descripcion[DescripcionTP],tm.IdTipoMoneda,tm.Abreviatura,");
                    query.AppendLine("strftime('%d/%m/%Y', date(p.FechaInicio))[FechaInicio],strftime('%d/%m/%Y', date(p.FechaFin))[FechaFin],");
                    query.AppendLine("p.MontoPrestamo,p.Interes,p.NumeroCuotas,p.MontoCuota,p.TotalIntereses,p.MontoTotal,p.NombreCliente,");
                    query.AppendLine("p.TipoDocumento,p.NumeroDocumento,p.Direccion,p.Ciudad,p.Correo,p.NumeroTelefono,p.Estado,p.Clausula");
                    query.AppendLine("from PRESTAMO p");
                    query.AppendLine("INNER JOIN TIPO_PAGO tp on tp.IdTipoPago = p.IdTipoPago");
                    query.AppendLine("INNER JOIN TIPO_MONEDA tm on tm.IdTipoMoneda = p.IdTipoMoneda");
                    query.AppendLine("where p.NumeroOperacion = iif(upper(@pnumerooperacion) = '', p.NumeroOperacion, upper(@pnumerooperacion))");
                    query.AppendLine("and p.NumeroDocumento = iif(upper(@pnumerodocumento) = '', p.NumeroDocumento, upper(@pnumerodocumento))");
                    query.AppendLine("ORDER BY p.IdPrestamo DESC LIMIT 1;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnumerooperacion", numerooperacion));
                    cmd.Parameters.Add(new SQLiteParameter("@pnumerodocumento", numerodocumento));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objeto = new Prestamo()
                            {
                                IdPrestamo = Convert.ToInt32(dr["IdPrestamo"].ToString()),
                                NumeroOperacion = dr["NumeroOperacion"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                oTipoPago = new TipoPago() { IdTipoPago = Convert.ToInt32(dr["IdTipoPago"].ToString()),
                                    Descripcion = dr["DescripcionTP"].ToString(),
                                },
                                oTipoMoneda = new TipoMoneda() { IdTipoMoneda = Convert.ToInt32(dr["IdTipoMoneda"].ToString()),
                                    Abreviatura = dr["Abreviatura"].ToString(),
                                },
                                FechaInicio = dr["FechaInicio"].ToString(),
                                FechaFin = dr["FechaFin"].ToString(),
                                MontoPrestamo = dr["MontoPrestamo"].ToString(),
                                Interes = dr["Interes"].ToString(),
                                NumeroCuotas = Convert.ToInt32(dr["NumeroCuotas"].ToString()),
                                MontoCuota = dr["MontoCuota"].ToString(),
                                TotalIntereses = dr["TotalIntereses"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Ciudad = dr["Ciudad"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                NumeroTelefono = dr["NumeroTelefono"].ToString(),
                                Estado = dr["Estado"].ToString(),
                                Clausula = dr["Clausula"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objeto = new Prestamo();
            }
            return objeto;
        }


        public int Actualizar(Prestamo objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("UPDATE PRESTAMO set NombreCliente = @pnombre,");
                    query.AppendLine("TipoDocumento = @ptipodoc,");
                    query.AppendLine("NumeroDocumento = @pdoc,");
                    query.AppendLine("Direccion = @pdirec,");
                    query.AppendLine("Ciudad = @pciudad,");
                    query.AppendLine("Correo = @pcorreo,");
                    query.AppendLine("NumeroTelefono = @ptelefono,");
                    query.AppendLine("Clausula = @pclausula");
                    query.AppendLine("where IdPrestamo = @pid;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnombre", objeto.NombreCliente));
                    cmd.Parameters.Add(new SQLiteParameter("@ptipodoc", objeto.TipoDocumento));
                    cmd.Parameters.Add(new SQLiteParameter("@pdoc", objeto.NumeroDocumento));
                    cmd.Parameters.Add(new SQLiteParameter("@pdirec", objeto.Direccion));
                    cmd.Parameters.Add(new SQLiteParameter("@pciudad", objeto.Ciudad));
                    cmd.Parameters.Add(new SQLiteParameter("@pcorreo", objeto.Correo));
                    cmd.Parameters.Add(new SQLiteParameter("@ptelefono", objeto.NumeroTelefono));
                    cmd.Parameters.Add(new SQLiteParameter("@pclausula", objeto.Clausula));
                    cmd.Parameters.Add(new SQLiteParameter("@pid", objeto.IdPrestamo));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo actualizar los datos";

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }


        public int Cancelar(int IdPrestamo, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            SQLiteTransaction objTransaccion = null;
            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    objTransaccion = conexion.BeginTransaction();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine(string.Format("UPDATE PRESTAMO SET Estado = '{0}' WHERE IdPrestamo = {1};", "CANCELADO", IdPrestamo));
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Transaction = objTransaccion;
                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo cancelar el prestamo";
                    }
                    objTransaccion.Commit();
                }
                catch (Exception ex)
                {
                    objTransaccion.Rollback();
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }
            return respuesta;
        }


        public int Pagar(Cuota oCuota, int IdPrestamo,int TotalCuotas, out string mensaje)
        {

            mensaje = string.Empty;
            int respuesta = 0;
            SQLiteTransaction objTransaccion = null;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {

                try
                {
                    conexion.Open();
                    objTransaccion = conexion.BeginTransaction();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine(string.Format("UPDATE CUOTA set EstadoCuota = 'CANCELADO' , FechaPago = '{0}', ProximoPago = 0 WHERE IdCuota = {1} and IdPrestamo = {2} and NumeroCuota = {3};", oCuota.FechaPago, oCuota.IdCuota, IdPrestamo, oCuota.NumeroCuota));

                    //VALIDAMOS SI ES EL ULTIMO PERIODO A PAGAR
                    if (TotalCuotas > oCuota.NumeroCuota)
                    {
                        oCuota.NumeroCuota += 1;
                        query.AppendLine(string.Format("UPDATE CUOTA set ProximoPago = 1 where IdPrestamo = {0} and NumeroCuota = {1};", IdPrestamo, oCuota.NumeroCuota));
                    }
                    else
                    {
                        query.AppendLine(string.Format("UPDATE PRESTAMO SET Estado = 'CERRADO' WHERE IdPrestamo = {0};",IdPrestamo));
                    }

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Transaction = objTransaccion;
                    respuesta = cmd.ExecuteNonQuery();


                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo registrar el pago";
                    }

                    objTransaccion.Commit();

                }
                catch (Exception ex)
                {
                    objTransaccion.Rollback();
                    respuesta = 0;
                    mensaje = ex.Message;
                }

            }
            return respuesta;
        }


        public List<VistaReporte> Resumen(string fechainicio = "", string fechafin = "")
        {
            List<VistaReporte> oLista = new List<VistaReporte>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.NumeroOperacion,strftime('%d/%m/%Y', date(p.FechaRegistro))[FechaRegistro],tp.Descripcion[DescripcionTP], tm.Abreviatura,");
                    query.AppendLine("strftime('%d/%m/%Y', date(p.FechaInicio))[FechaInicio],p.MontoPrestamo,p.Interes,p.NumeroCuotas,p.MontoCuota,");
                    query.AppendLine("p.TotalIntereses,p.MontoTotal,p.NombreCliente,p.TipoDocumento,p.NumeroDocumento,p.Direccion,p.Ciudad,p.Correo,p.NumeroTelefono,p.Estado");
                    query.AppendLine("from PRESTAMO p");
                    query.AppendLine("inner join TIPO_PAGO tp on tp.IdTipoPago = p.IdTipoPago");
                    query.AppendLine("inner join TIPO_MONEDA tm on tm.IdTipoMoneda = p.IdTipoMoneda");
                    query.AppendLine("where DATE(p.FechaRegistro) BETWEEN DATE(@pfechainicio) AND DATE(@pfechafin)");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pfechainicio", fechainicio));
                    cmd.Parameters.Add(new SQLiteParameter("@pfechafin", fechafin));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new VistaReporte()
                            {
                                NroOperacion = dr["NumeroOperacion"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                FormaPago = dr["DescripcionTP"].ToString(),
                                TipoMoneda = dr["Abreviatura"].ToString(),
                                FechaInicio = dr["FechaInicio"].ToString(),
                                MontoPrestamo = dr["MontoPrestamo"].ToString(),
                                Interes = dr["Interes"].ToString(),
                                NroCuotas = dr["NumeroCuotas"].ToString(),
                                MontoporCuota = dr["MontoCuota"].ToString(),
                                TotalInteres = dr["TotalIntereses"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NroDocumento = dr["NumeroDocumento"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Ciudad = dr["Ciudad"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                NroTelefonoCelular = dr["NumeroTelefono"].ToString(),
                                Estado = dr["Estado"].ToString(),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<VistaReporte>();
            }
            return oLista;
        }


    }
}
