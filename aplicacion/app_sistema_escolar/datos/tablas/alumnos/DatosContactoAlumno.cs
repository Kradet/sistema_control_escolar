using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using comun.Entidades;

namespace datos.tablas
{
    //Clase responsable de CRUD contacto_alumno
    public class DatosContactoAlumno : ConeccionSql
    {
        public EntidadContactoAlumno ObtenerContactoAlumno(EntidadAlumno entidadDatosAlumno)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from contacto_alumno where @Id = id_alumno";
                    comando.Parameters.AddWithValue("@Id", entidadDatosAlumno.IdAlumno);

                    MySqlDataReader reader = comando.ExecuteReader();
                    EntidadContactoAlumno contactoAlumno = new EntidadContactoAlumno();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            contactoAlumno.IdContactoAlumno = reader.GetInt32(0);
                            contactoAlumno.IdAlumno = reader.GetInt32(1);
                            contactoAlumno.NombreTutor = reader.GetString(2);
                            contactoAlumno.Telefono = reader.GetString(3);
                            contactoAlumno.Email = reader.GetString(4);
                            contactoAlumno.Direccion = reader.GetString(5);

                        }
                    }
                    return contactoAlumno;
                }
            }
        }

        //Insertar contacto_alumno;
        public void InsertarContactoAlumnoIdAlumno(EntidadContactoAlumno contactoAlumno)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "insert into contacto_alumno " +
                        "(id_alumno, nombre_tutor, telefono, email, direccion) " +
                        "values " +
                        "(@IdAlumno, @NombreTutor, @Telefono, @Email, @Direccion)";

                    comando.Parameters.AddWithValue("@IdAlumno", contactoAlumno.IdAlumno);
                    comando.Parameters.AddWithValue("@NombreTutor", contactoAlumno.NombreTutor);
                    comando.Parameters.AddWithValue("@Telefono", contactoAlumno.Telefono);
                    comando.Parameters.AddWithValue("@Email", contactoAlumno.Email);
                    comando.Parameters.AddWithValue("@Direccion", contactoAlumno.Direccion);

                    comando.ExecuteNonQuery();
                }
            }
        }

        //Insertar contacto_alumno por curp
        public void InsertarContactoAlumnoCurp(EntidadContactoAlumno contactoAlumno, EntidadAlumno alumno)
        {
            //Obtenemos la curp
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from datos_alumno where curp = @Curp";
                    comando.Parameters.AddWithValue("@Curp", alumno.Curp);

                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        contactoAlumno.IdAlumno = reader.GetInt32(0);
                    }
                }
            }

            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "insert into contacto_alumno " +
                        "(id_alumno, nombre_tutor, telefono, email, direccion) " +
                        "values " +
                        "(@IdAlumno, @NombreTutor, @Telefono, @Email, @Direccion)";

                    comando.Parameters.AddWithValue("@IdAlumno", contactoAlumno.IdAlumno);
                    comando.Parameters.AddWithValue("@NombreTutor", contactoAlumno.NombreTutor);
                    comando.Parameters.AddWithValue("@Telefono", contactoAlumno.Telefono);
                    comando.Parameters.AddWithValue("@Email", contactoAlumno.Email);
                    comando.Parameters.AddWithValue("@Direccion", contactoAlumno.Direccion);

                    comando.ExecuteNonQuery();
                }
            }
        }

        //Actualizar contacto alumno
        public void EditarContactoAlumno(EntidadContactoAlumno contactoAlumno)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "update contacto_alumno set " +
                        "nombre_tutor = @NombreTutor, " +
                        "telefono = @Telefono, " +
                        "email = @Email, " +
                        "direccion = @Direccion " +
                        "where id_alumno = @IdAlumno";

                    comando.Parameters.AddWithValue("@NombreTutor", contactoAlumno.NombreTutor);
                    comando.Parameters.AddWithValue("@Telefono", contactoAlumno.Telefono);
                    comando.Parameters.AddWithValue("@Email", contactoAlumno.Email);
                    comando.Parameters.AddWithValue("@Direccion", contactoAlumno.Direccion);
                    comando.Parameters.AddWithValue("@IdAlumno", contactoAlumno.IdAlumno);
                }

                //No hace falta un metodo de eliminar los datos de contacto por que se eliminan al eliminar a un alumno
            }
        }

    }
}
