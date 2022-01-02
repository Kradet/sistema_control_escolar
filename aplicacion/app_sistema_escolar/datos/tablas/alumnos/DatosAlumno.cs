using comun.Entidades;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace datos.tablas
{
    //Clase responsable de CRUD tabla datos_alumno
    public class DatosAlumno : ConeccionSql
    {
        //Listar la tabla datos_alumno
        public List<EntidadAlumno> ListarDatosAlumno(string buscar)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from datos_alumno where nombre like concat(@Buscar, '%') or curp like concat(@Buscar, '%')";
                    comando.Parameters.AddWithValue("@Buscar", buscar);

                    MySqlDataReader reader = comando.ExecuteReader();
                    List<EntidadAlumno> lista = new List<EntidadAlumno>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new EntidadAlumno
                            {
                                IdAlumno = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                ApellidoPaterno = reader.GetString(2),
                                ApellidoMaterno = reader.GetString(3),
                                Sexo = reader.GetChar(4),
                                Curp = reader.GetString(5),
                                FechaNacimiento = reader.GetDateTime(6),
                                Nacionalidad = reader.GetString(7),
                                Email = reader.GetString(8)
                            });
                        }

                    }
                    return lista;
                }
            }
        }

        //Insertar en la tabla datos_alumno
        public void InsertarDatosAlumno(EntidadAlumno alumno)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "insert into datos_alumno" +
                        "(nombre, apellido_paterno, apellido_materno, sexo, curp, fecha_nacimiento, nacionalidad, email) " +
                        "values" +
                        "(@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Sexo, @Curp, @FechaNacimiento, @Nacionalidad, @Email)";

                    comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    comando.Parameters.AddWithValue("@ApellidoPaterno", alumno.ApellidoPaterno);
                    comando.Parameters.AddWithValue("@ApellidoMaterno", alumno.ApellidoMaterno);
                    comando.Parameters.AddWithValue("@Sexo", alumno.Sexo);
                    comando.Parameters.AddWithValue("@Curp", alumno.Curp);
                    comando.Parameters.AddWithValue("@FechaNacimiento", alumno.FechaNacimiento);
                    comando.Parameters.AddWithValue("@Nacionalidad", alumno.Nacionalidad);
                    comando.Parameters.AddWithValue("@Email", alumno.Email);

                    comando.ExecuteNonQuery();
                }
            }
        }

        //Modificar datos_alumno
        public void EditarDatosAlumno(EntidadAlumno alumno)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "update datos_alumno set " +
                        "nombre = @Nombre, " +
                        "apellido_paterno = @ApellidoPaterno, " +
                        "apellido_materno = @ApellidoMaterno, " +
                        "sexo = @Sexo, " +
                        "curp = @Curp, " +
                        "fecha_nacimiento = @FechaNacimiento, " +
                        "nacionalidad = @Nacionalidad, " +
                        "email = @Email " +
                        "where id_alumno = @Id";

                    comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    comando.Parameters.AddWithValue("@ApellidoPaterno", alumno.ApellidoPaterno);
                    comando.Parameters.AddWithValue("@ApellidoMaterno", alumno.ApellidoMaterno);
                    comando.Parameters.AddWithValue("@Sexo", alumno.Sexo);
                    comando.Parameters.AddWithValue("@Curp", alumno.Curp);
                    comando.Parameters.AddWithValue("@FechaNacimiento", alumno.FechaNacimiento);
                    comando.Parameters.AddWithValue("@Nacionalidad", alumno.Nacionalidad);
                    comando.Parameters.AddWithValue("@Email", alumno.Nacionalidad);
                    comando.Parameters.AddWithValue("@Id", alumno.IdAlumno);

                    comando.ExecuteNonQuery();
                }
            }
        }

        //Eliminar datos_alumno
        public void EliminarDatosAlumno(EntidadAlumno alumno)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "delete from datos_alumno " +
                        "where id_alumno = @Id";
                    comando.Parameters.AddWithValue("@Id", alumno.IdAlumno);

                    comando.ExecuteNonQuery();
                }
            }
        }

        //Extras
        public EntidadAlumno EncontarAlumnoPorId(int Id)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from datos_alumno where id_alumno = @Id";
                    comando.Parameters.AddWithValue("@Id", Id);

                    MySqlDataReader reader = comando.ExecuteReader();
                    EntidadAlumno alumno = new EntidadAlumno();

                    if (reader.Read())
                    {
                        alumno.IdAlumno = reader.GetInt32(0);
                        alumno.Nombre = reader.GetString(1);
                        alumno.ApellidoPaterno = reader.GetString(2);
                        alumno.ApellidoMaterno = reader.GetString(3);
                        alumno.Sexo = reader.GetChar(4);
                        alumno.Curp = reader.GetString(5);
                        alumno.FechaNacimiento = reader.GetDateTime(6);
                        alumno.Nacionalidad = reader.GetString(7);
                        alumno.Email = reader.GetString(8);
                    }

                    return alumno;
                }
            }
        }
    }
}
