using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Logica
{
    public class DatoLogica
    {
        private static DatoLogica _instancia = null;

        public DatoLogica()
        {

        }

        public static DatoLogica Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new DatoLogica();
                return _instancia;
            }
        }

        public Datos Obtener()
        {
            Datos obj = new Datos();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select IdDato, RazonSocial, RUC, Representante, Correo, Telefono, Ciudad from DATOS where IdDato = 1";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Datos()
                            {
                                IdDato = int.Parse(dr["IdDato"].ToString()),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                RUC = dr["RUC"].ToString(),
                                Representante = dr["Representante"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Ciudad = dr["Ciudad"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obj = new Datos();
            }
            return obj;
        }

        public int Guardar(Datos objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update DATOS set RazonSocial = @prazonsocial,");
                    query.AppendLine("RUC = @pruc,");
                    query.AppendLine("Representante = @prepresentante,");
                    query.AppendLine("Correo = @pcorreo,");
                    query.AppendLine("Telefono = @ptelefono,");
                    query.AppendLine("Ciudad = @pciudad");
                    query.AppendLine("where IdDato = 1;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@prazonsocial", objeto.RazonSocial));
                    cmd.Parameters.Add(new SQLiteParameter("@pruc", objeto.RUC));
                    cmd.Parameters.Add(new SQLiteParameter("@prepresentante", objeto.Representante));
                    cmd.Parameters.Add(new SQLiteParameter("@pcorreo", objeto.Correo));
                    cmd.Parameters.Add(new SQLiteParameter("@ptelefono", objeto.Telefono));
                    cmd.Parameters.Add(new SQLiteParameter("@pciudad", objeto.Ciudad));
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

        public int ActualizarLogo(byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update DATOS set Logo = @pimagen");
                    query.AppendLine("where IdDato = 1;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    SQLiteParameter parameter = new SQLiteParameter("@pimagen", System.Data.DbType.Binary);
                    parameter.Value = imagen;
                    cmd.Parameters.Add(parameter);
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo actualizar el logo";

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] obj = new byte[0];
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select Logo from DATOS where IdDato = 1";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = (byte[])dr["Logo"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                obj = new byte[0];
            }
            return obj;
        }





    }
}
