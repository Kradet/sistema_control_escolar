using comun.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace datos
{
    //Clase responsable de CRUD de la tabla usuario
    public class DatosUsuarios : ConeccionSql
    {
        //Listar la tabla usuarios
        public List<EntidadVistaUsuarios> ListarUsuario(string buscar)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select id_usuario as id, tipo_usuario.tipo_usuario as tipo, username, nombre from usuario join tipo_usuario on usuario.id_tipo_usuario = tipo_usuario.id_tipo_usuario where username like concat(@Buscar, '%') or nombre like concat(@Buscar, '%')";
                    comando.Parameters.AddWithValue("@Buscar", buscar);

                    MySqlDataReader reader = comando.ExecuteReader();
                    List<EntidadVistaUsuarios> lista = new List<EntidadVistaUsuarios>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new EntidadVistaUsuarios
                            {
                                Id = reader.GetInt32(0),
                                Tipo = reader.GetString(1),
                                Username = reader.GetString(2),
                                Nombre = reader.GetString(3)
                            });
                        }
                    }

                    return lista;
                }
            }
        }
        /*
        public List<EntidadUsuarios> ListarUsuario(string buscar)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from usuario where username like concat(@nombre, '%') or nombre like concat(@nombre, '%')";
                    comando.Parameters.AddWithValue("@nombre", buscar);

                    MySqlDataReader reader = comando.ExecuteReader();
                    List<EntidadUsuarios> listar = new List<EntidadUsuarios>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listar.Add(new EntidadUsuarios
                            {
                                Id_usuario = reader.GetInt32(0),
                                Id_tipo_usuario = reader.GetInt32(1),
                                Username = reader.GetString(2),
                                Nombre = reader.GetString(3),
                                Contrasenia = reader.GetString(4)
                            });
                        }
                    }
                    return listar;
                }
            }
        }
        */

        //Insertar usuarios
        public void InsertarUsuario(EntidadUsuarios usuario)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "insert into usuario(id_tipo_usuario, username, nombre, contrasenia) values (@IdTipoUsuario, @Username, @Nombre, @Contrasenia)";
                    comando.Parameters.AddWithValue("@IdTipoUsuario", usuario.Id_tipo_usuario);
                    comando.Parameters.AddWithValue("@Username", usuario.Username);
                    comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);

                    comando.ExecuteNonQuery();
                }
            }
        }

        //Editar usuario
        public void EditarUsuario(EntidadUsuarios usuario)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "update usuario set id_tipo_usuario = @IdTipoUsuario, username = @Username, nombre = @Nombre where id_usuario = @Id";
                    comando.Parameters.AddWithValue("@IdTipoUsuario", usuario.Id_tipo_usuario);
                    comando.Parameters.AddWithValue("@Username", usuario.Username);
                    comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    //comando.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                    comando.Parameters.AddWithValue("@Id", usuario.Id_usuario);

                    comando.ExecuteNonQuery();
                }
            }
        }

        //Eliminar usuario
        public void EliminarUsuario(EntidadUsuarios usuario)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "delete from usuario where id_usuario = @Id";
                    comando.Parameters.AddWithValue("@Id", usuario.Id_usuario);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public EntidadUsuarios ObtenerUsuarioPorId(int idUsuario)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from usuario where id_usuario = @Id";
                    comando.Parameters.AddWithValue("@Id", idUsuario);

                    EntidadUsuarios usuario = new EntidadUsuarios();
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        usuario.Id_usuario = reader.GetInt32(0);
                        usuario.Id_tipo_usuario = reader.GetInt32(1);
                        usuario.Username = reader.GetString(2);
                        usuario.Nombre = reader.GetString(3);
                        usuario.Contrasenia = reader.GetString(4);
                    }

                    return usuario;
                }
            }
        }

        public void InsertarImagenDeUsuario(Byte[] ArrayDeBites, int IdUsuario)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;

                    comando.CommandText = "update usuario set imagen = @Imagen where id_usuario  =@Id";
                    comando.Parameters.AddWithValue("@Imagen", ArrayDeBites);
                    comando.Parameters.AddWithValue("@Id", IdUsuario);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
