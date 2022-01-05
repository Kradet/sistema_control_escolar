using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using comun.cache;
using System.IO;
using System.Drawing;

namespace datos
{
    // clase responsable  de las consultas a base de datos referentes al usuario
    public class UsuarioLoggin : ConeccionSql
    {
        //Loguear al usuario con la contraseña y el usuario de que ingreso en el formLoggin
        public bool Loggin(string usuario, string contrasenia)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using(var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from usuario where username = @usuario and contrasenia =@contrasenia";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contrasenia", contrasenia);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.IdUsuario = reader.GetInt32(0);
                            UserCache.IdTipoUsuario = reader.GetInt32(1);
                            UserCache.UserName = reader.GetString(2);
                            UserCache.Nombre = reader.GetString(3);

                            try
                            {
                                MemoryStream ms = new MemoryStream((byte[])reader["imagen"]);
                                Bitmap bm = new Bitmap(ms);
                                UserCache.Imagen = bm;
                            }
                            catch (Exception)
                            {
                                //significa que el usuario no tiene imagen de perfil
                            }

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        //Verificamos si el usuario existe para agregar seguridad 
        public bool ExisteUsuario(int id, string nombreLoggin, string pass)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from usuario where id_usuario = @id and username = @nombreLoggin and contrasenia = @pass";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombreLoggin", nombreLoggin);
                    comando.Parameters.AddWithValue("@pass", pass);

                    var reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
