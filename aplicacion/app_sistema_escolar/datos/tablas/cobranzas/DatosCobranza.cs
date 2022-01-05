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
        public List<EntidadMensualidad> ListarMensualidad(EntidadAlumno Alumno)
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

                    comando.Parameters.AddWithValue("@IdAlumno", Alumno.IdAlumno);
                    comando.Parameters.AddWithValue("@CurpAlumno", Alumno.Curp);

                    using (var reader = comando.ExecuteReader())
                    {
                        List<EntidadMensualidad> lista = new List<EntidadMensualidad>();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lista.Add( new EntidadMensualidad
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

        public void InsertarCobroMensual(EntidadCobrosMensuales Cobro)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "insert into cobros_mensuales (id_cobros_alumno, Mes_Pago, Estatus) values (@IdCobroAlumno, @MesPago, @Estatus)";
                    comando.Parameters.AddWithValue("@IdCobroAlumno", Cobro.IdCobrosAlumno);
                    comando.Parameters.AddWithValue("@MesPago", Cobro.MesPago);
                    comando.Parameters.AddWithValue("@Estatus", Cobro.Estatus);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<EntidadVistaMensualidades> ListarVistaMensualidades(int IdAlumno)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "SELECT cobros_mensuales.Id_cobros_mensuales, conceptos_cobranza.Concepto, conceptos_cobranza.Precio, cobros_mensuales.Mes_Pago, cobros_mensuales.Estatus " +
                        "FROM sistema_escolar.cobros_mensuales " +
                        "INNER JOIN cobros_alumno ON cobros_mensuales.id_cobros_alumno = cobros_alumno.idcobros_alumno " +
                        "INNER join conceptos_cobranza ON cobros_alumno.conceptos_cobranza_id_Folio_cobranza = conceptos_cobranza.id_Folio_cobranza " +
                        "INNER JOIN servicio_escolar ON cobros_alumno.id_servicio_escolar = servicio_escolar.id_servicio_escolar " +
                        "INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno " +
                        "where datos_alumno.id_alumno = @Id";

                    comando.Parameters.AddWithValue("@Id", IdAlumno);

                    using (var reader = comando.ExecuteReader())
                    {
                        List<EntidadVistaMensualidades> lista = new List<EntidadVistaMensualidades>();
                        
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lista.Add(new EntidadVistaMensualidades
                                {
                                    Id = reader.GetInt32(0),
                                    Concepto = reader.GetString(1),
                                    Precio = reader.GetFloat(2),
                                    Mes_Pago = reader.GetString(3),
                                    Estatus = reader.GetString(4)
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
