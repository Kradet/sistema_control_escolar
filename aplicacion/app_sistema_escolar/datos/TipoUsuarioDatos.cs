using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using comun.cache;

namespace datos
{
    //Clase para cargar el tipo de usuario que se loggeo
    public class TipoUsuarioDatos : ConeccionSql
    {
        public void CargarTipoUsuario()
        {
            using(var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from tipo_usuario where id_tipo_usuario = @idtipousuario";
                    comando.Parameters.AddWithValue("@idtipousuario", UserCache.IdTipoUsuario);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.TipoUsuario = reader.GetString(1);
                        }
                    }
                }
            }
        }
    }
}
