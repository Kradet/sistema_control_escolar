using comun.Entidades;
using comun.Entidades.alumnos;
using comun.Entidades.servicio_escolar;
using MySql.Data.MySqlClient;

namespace datos.tablas.servicio_escolar
{
    public class DatosServicioEscolar : ConeccionSql
    {
        public void InsertarAlumnoProgramaEducativo(EntidadAlumno alumno, EntidadPlantelesNiveles plantelNivel)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    //justamente aquí no deja ingresar valores nulos, en las demás sí, me lanza error por que no ingreso el puto grado ._."
                    comando.Connection = coneccion;
                    comando.CommandText = $"insert into servicio_escolar " +
                        $"(id_clave_programa_educativo, id_alumno)" +
                        $"values" +
                        $"(@IdProgramaEducativo, @IdAlumno)";

                    comando.Parameters.AddWithValue("@IdProgramaEducativo", SeleccionarClaveProgramaEducativo(plantelNivel));
                    comando.Parameters.AddWithValue("@IdAlumno", alumno.IdAlumno);
                }
            }
        }


        private int SeleccionarClaveProgramaEducativo(EntidadPlantelesNiveles plantelNivel)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select clave_programa_educativo from planteles_niveles where plantel_id_plantel = @IdPlantel and niveles_educativos_id_nivel = @IdNivel";

                    comando.Parameters.AddWithValue("@IdPlantel", plantelNivel.IdPlantel);
                    comando.Parameters.AddWithValue("@IdNivel", plantelNivel.IdNivel);

                    MySqlDataReader reader = comando.ExecuteReader();
                    int idProgramaEducativo = 0;
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            idProgramaEducativo = reader.GetInt32(0);
                        }
                    }

                    return idProgramaEducativo;
                }
            }
        }

        public EntidadVistaAlumnoServicio VistaAlumnoServicioPorId(int idAlumno)
        {
            using (var coneccion = GetConnection())
            {
                EntidadVistaAlumnoServicio alumno = new EntidadVistaAlumnoServicio();
                alumno.IdAlumno = idAlumno;
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;

                    //Obtenemos Nombre y Apellidos
                    comando.CommandText = $"select * from datos_alumno where id_alumno = @IdAlumno";
                    comando.Parameters.AddWithValue("@IdAlumno", alumno.IdAlumno);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                alumno.IdAlumno = reader.GetInt32(0);
                                alumno.Nombre = reader.GetString(1);
                                alumno.ApellidoPaterno = reader.GetString(2);
                                alumno.ApellidoMaterno = reader.GetString(3);
                            }
                        }
                    }

                    //Obtenemos el grado y grupo y estatus
                    comando.CommandText = $"select * from servicio_escolar where id_alumno = @IdAlumno";
                    //comando.Parameters.AddWithValue("@IdAlumno", alumno.IdAlumno); excepción, id alumno ya se definió arriba

                    using (MySqlDataReader reader1 = comando.ExecuteReader())
                    {
                        if (reader1.HasRows)
                        {
                            while (reader1.Read())
                            {
                                alumno.IdClaveProgramaEducativo = reader1.GetInt32(1);
                                alumno.Grado = reader1.GetString(3);
                                alumno.Grupo = reader1.GetString(4);
                                alumno.Status = reader1.GetString(5);

                            }
                        }
                    }

                    //Obtenemos el plantel y el nivel educativo
                    comando.CommandText = $"select * from planteles_niveles where clave_programa_educativo = @IdProgramaEducativo";
                    comando.Parameters.AddWithValue("@IdProgramaEducativo", alumno.IdClaveProgramaEducativo);

                    using (MySqlDataReader reader2 = comando.ExecuteReader())
                    {
                        if (reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                alumno.IdPlantel = reader2.GetInt32(1);
                                alumno.IdNivelEducativo = reader2.GetInt32(2);
                            }
                        }
                    }

                    comando.CommandText = $"select * from escuela_plantel where id_plantel = @IdPlantel";
                    comando.Parameters.AddWithValue("@IdPlantel", alumno.IdPlantel);

                    using (MySqlDataReader reader3 = comando.ExecuteReader())
                    {
                        if (reader3.HasRows)
                        {
                            while (reader3.Read())
                            {
                                alumno.NombrePlantel = reader3.GetString(1);
                            }
                        }
                    }

                    comando.CommandText = $"select * from niveles_educativos where id_nivel = @IdNivel";
                    comando.Parameters.AddWithValue("@IdNivel", alumno.IdNivelEducativo);

                    using (MySqlDataReader reader3 = comando.ExecuteReader())
                    {
                        if (reader3.HasRows)
                        {
                            while (reader3.Read())
                            {
                                alumno.NombreNivelEducativo= reader3.GetString(1);
                            }
                        }
                    }

                }

                return alumno;
            }

        }

        public void InsertarDatosServicioEscolar(EntidadVistaAlumnoServicio alumnoServicio)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = $"insert into servicio_escolar " +
                        $"(id_clave_programa_educativo, id_alumno, grado, grupo, estatus)" +
                        $"values " +
                        $"(@IdProgramaEducativo, @IdAlumno, @Grado, @Grupo, @Estatus)";

                    comando.Parameters.AddWithValue("@IdProgramaEducativo", SeleccionarClaveProgramaEducativo(new EntidadPlantelesNiveles { 
                        IdNivel=alumnoServicio.IdNivelEducativo,
                        IdPlantel=alumnoServicio.IdPlantel
                    }));
                    comando.Parameters.AddWithValue("@IdAlumno", alumnoServicio.IdAlumno);
                    comando.Parameters.AddWithValue("@Grado", alumnoServicio.Grado);
                    comando.Parameters.AddWithValue("@Grupo", alumnoServicio.Grado);
                    comando.Parameters.AddWithValue("Estatus", alumnoServicio.Status);

                    comando.ExecuteNonQuery();
                    
                }
            }
        }

        public EntidadServicioEscolar ObtenerServicioSocialIdAlumno(EntidadAlumno alumno)
        {
            using ( var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from servicio_escolar" +
                        " where id_alumno = @IdAlumno";
                    comando.Parameters.AddWithValue("@IdAlumno", alumno.IdAlumno);

                    MySqlDataReader reader = comando.ExecuteReader();
                    EntidadServicioEscolar servicioEscolar = new EntidadServicioEscolar();

                    if (reader.Read())
                    {
                        servicioEscolar.IdServicioEscolar = reader.GetInt32(0);
                        servicioEscolar.IdClaveProgramaEducativo = reader.GetInt32(1);
                        servicioEscolar.IdAlumno = reader.GetInt32(2);
                        servicioEscolar.Grado = reader.GetString(3);
                        servicioEscolar.Grupo = reader.GetString(4);
                        servicioEscolar.Status = reader.GetString(5);
                    }

                    return servicioEscolar;
                }
            }
        }
    }
}
