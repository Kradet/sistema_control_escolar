using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using comun.Entidades.cobranzas;

namespace datos.tablas.cobranzas
{
    public class DatosCobrosAlumno:ConeccionSql
    {
        //Lista la tabla cobros_alumno
        public List<EntidadCobrosAlumno> ListarCobrosAlumno()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from cobros_alumno";

                    MySqlDataReader reader = comando.ExecuteReader();
                    List<EntidadCobrosAlumno> lista = new List<EntidadCobrosAlumno>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new EntidadCobrosAlumno
                            {
                                IdCobrosAlumno = reader.GetInt32(0),
                                IdServicioEscolar = reader.GetInt32(1),
                                IdConceptoCobranza = reader.GetInt32(2),
                                CicloEscolar = reader.GetString(3)
                            });
                        }
                    }

                    return lista;
                }
            }
        }

        //Insertar en la tabla cobros_alumno
        public void InsertarCobroAlumno(EntidadCobrosAlumno cobrosAlumno)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "insert into cobros_alumno " +
                        "(id_servicio_escolar, conceptos_cobranza_id_Folio_cobranza, Ciclo_Escolar) " +
                        "values " +
                        "(@IdServicioEscolar, @IdFolio, @CicloEscolar)";
                    comando.Parameters.AddWithValue("@IdServicioEscolar", cobrosAlumno.IdServicioEscolar);
                    comando.Parameters.AddWithValue("@IdFolio", cobrosAlumno.IdConceptoCobranza);
                    comando.Parameters.AddWithValue("@CicloEscolar", cobrosAlumno.CicloEscolar);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
