using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comun.Entidades.cobranzas;
using comun.Entidades;
using MySql.Data.MySqlClient;

namespace datos.tablas.cobranzas
{
    public class DatosCobranza : ConeccionSql
    {
        public List<EntidadVistaCrearMensualidad> ListarVistaCrearMensualidad(EntidadAlumno Alumno)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "SELECT cobros_alumno.idcobros_alumno, datos_alumno.nombre, datos_alumno.apellido_paterno, datos_alumno.apellido_materno, " +
                        "conceptos_cobranza.Concepto, conceptos_cobranza.Precio " +
                        "FROM sistema_escolar.cobros_alumno " +
                        "INNER JOIN conceptos_cobranza ON cobros_alumno.conceptos_cobranza_id_Folio_cobranza = conceptos_cobranza.id_Folio_cobranza " +
                        "INNER JOIN servicio_escolar ON cobros_alumno.id_servicio_escolar = servicio_escolar.id_servicio_escolar " +
                        "INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno " +
                        "where datos_alumno.id_alumno = @IdAlumno or datos_alumno.curp = @CurpAlumno";

                    using (var reader = comando.ExecuteReader())
                    {
                        List<EntidadVistaCrearMensualidad> lista = new List<EntidadVistaCrearMensualidad>();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lista.Add( new EntidadVistaCrearMensualidad
                                {
                                    IdCobrosAlumno=reader.GetInt32(0),
                                    NombreAlumno=reader.GetString(1),
                                    ApellidoPaternoAlumno=reader.GetString(2),
                                    ApellidoMaternoAlumno =reader.GetString(3),
                                    Concepto=reader.GetString(4),
                                    Precio=reader.GetFloat(5)       
                                });
                            }
                        }
                        return lista;
                    }
                }
            }
        }
    }
}
