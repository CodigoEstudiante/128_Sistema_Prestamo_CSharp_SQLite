using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Logica
{
    public class UsuarioLogica
    {
        private static UsuarioLogica _instancia = null;
        public UsuarioLogica()
        {

        }
        public static UsuarioLogica Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new UsuarioLogica();
                return _instancia;
            }
        }

        public Usuario Obtener()
        {
            Usuario obj = new Usuario();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select IdUsuario,NombreUsuario,Clave from USUARIO where IdUsuario = 1";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Usuario()
                            {
                                IdUsuario = int.Parse(dr["IdUsuario"].ToString()),
                                NombreUsuario = dr["NombreUsuario"].ToString(),
                                Clave = dr["Clave"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obj = new Usuario();
            }
            return obj;
        }

        public int Guardar(Usuario objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update USUARIO set NombreUsuario = @pnombre where IdUsuario = 1");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnombre", objeto.NombreUsuario));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo actualizar el nombre de usuario";

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public int cambiarClave(string nuevaclave, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update USUARIO set Clave = @pclave where IdUsuario = 1;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pclave", nuevaclave));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo cambiar la contraseña";
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public int resetear()
        {
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update USUARIO set NombreUsuario = 'Admin', Clave = '123' where IdUsuario = 1;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
            }

            return respuesta;
        }

    }
}
