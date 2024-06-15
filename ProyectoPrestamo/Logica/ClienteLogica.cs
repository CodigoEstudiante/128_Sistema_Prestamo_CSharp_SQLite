using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Logica
{
    public class ClienteLogica
    {
        private static ClienteLogica _instancia = null;

        public ClienteLogica()
        {

        }

        public static ClienteLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new ClienteLogica();
                return _instancia;
            }
        }

        public List<Clientes> Listar()
        {
            List<Clientes> oLista = new List<Clientes>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdCliente,NombreCompleto,TipoDocumento,NumeroDocumento,Direccion,Ciudad,Correo,NumeroTelefono from CLIENTES");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Clientes()
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"].ToString()),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Ciudad = dr["Ciudad"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                NumeroTelefono = dr["NumeroTelefono"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Clientes>();
            }
            return oLista;
        }


        public int Registrar(Clientes oCliente, out string mensaje)
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

                    query.AppendLine(string.Format("INSERT INTO CLIENTES(NombreCompleto,TipoDocumento,NumeroDocumento,Direccion,Ciudad,Correo,NumeroTelefono) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",
                        oCliente.NombreCompleto,
                        oCliente.TipoDocumento,
                        oCliente.NumeroDocumento,
                        oCliente.Direccion,
                        oCliente.Ciudad,
                        oCliente.Correo,
                        oCliente.NumeroTelefono));
                    query.AppendLine("select last_insert_rowid();");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Transaction = objTransaccion;
                    respuesta = Convert.ToInt32(cmd.ExecuteScalar());


                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo registrar el cliente";
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

        public int Editar(Clientes oCliente, out string mensaje)
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

                    query.AppendLine(string.Format("UPDATE CLIENTES SET NombreCompleto = '{0}',TipoDocumento = '{1}',NumeroDocumento = '{2}',Direccion = '{3}',Ciudad = '{4}',Correo = '{5}',NumeroTelefono = '{6}' WHERE IdCliente = {7};",
                        oCliente.NombreCompleto,
                        oCliente.TipoDocumento,
                        oCliente.NumeroDocumento,
                        oCliente.Direccion,
                        oCliente.Ciudad,
                        oCliente.Correo,
                        oCliente.NumeroTelefono,
                        oCliente.IdCliente
                        ));

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Transaction = objTransaccion;
                    respuesta = cmd.ExecuteNonQuery();


                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo editar";
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


        public int Eliminar(int id)
        {
            int respuesta = 0;
            
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    try
                    {
                        conexion.Open();
                        StringBuilder query = new StringBuilder();
                        query.AppendLine("delete from CLIENTES where IdCliente= @id;");
                        SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                        cmd.Parameters.Add(new SQLiteParameter("@id", id));
                        cmd.CommandType = System.Data.CommandType.Text;

                        respuesta = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        respuesta = 0;
                    }

                }
            

            return respuesta;
        }



    }
}
