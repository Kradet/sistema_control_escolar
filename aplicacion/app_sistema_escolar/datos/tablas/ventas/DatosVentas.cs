using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using comun.Entidades.ventas;

namespace datos.tablas.ventas
{
    public class DatosVentas : ConeccionSql
    {
        public List<EntidadCaja> ListarCajas()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from caja";

                    MySqlDataReader reader = comando.ExecuteReader();
                    List<EntidadCaja> lista = new List<EntidadCaja>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new EntidadCaja
                            {
                                Id = reader.GetInt32(0),
                                Numero = reader.GetString(1)
                            });
                        }
                    }

                    return lista;
                }
            }
        }

        public EntidadSesionCaja ObtenerSesionCajaPorIdCaja(int idCaja)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from sesion_caja where caja_idcaja = @IdCaja";
                    comando.Parameters.AddWithValue("@IdCaja", idCaja);

                    MySqlDataReader reader = comando.ExecuteReader();
                    EntidadSesionCaja sesionCaja = new EntidadSesionCaja();

                    if (reader.Read())
                    {
                        sesionCaja.IdSesionCaja = reader.GetInt32(0);
                        sesionCaja.IdUsuario = reader.GetInt32(1);
                        sesionCaja.IdCaja = reader.GetInt32(2);
                        sesionCaja.Estatus = reader.GetString(3);
                        sesionCaja.HoraApertura = reader.GetString(4);
                        sesionCaja.HoraCierre = reader.GetString(5);
                        sesionCaja.CantidadInicial  = reader.GetFloat(6);
                    }

                    return sesionCaja;
                }
            }
        }

        public void AbrirCerrarSesionCaja(EntidadSesionCaja sesionCaja)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "update sesion_caja set Estatus = @Estatus where caja_idcaja = @Id";
                    comando.Parameters.AddWithValue("@Estatus", sesionCaja.Estatus);
                    comando.Parameters.AddWithValue("@Id", sesionCaja.IdCaja);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<EntidadCobrosMensuales> ListarCobrosMensuales()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from cobros_mensuales";

                    List<EntidadCobrosMensuales> lista = new List<EntidadCobrosMensuales>();

                    MySqlDataReader reader = comando.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new EntidadCobrosMensuales
                            {
                                Id = reader.GetInt32(0),
                                IdCobrosAlumno = reader.GetInt32(1),
                                MesPago = reader.GetString(2),
                                Estatus = reader.GetString(3)
                            });
                        }
                    }

                    return lista;
                }
            }
        }

        public void InsertarCobrosCaja(EntidadCobrosCaja CobrosCaja)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "insert into cobros_caja " +
                        "(id_cobros_mensuales, Fecha, Descuentos, Recargos, Metodo_Pago, Total) " +
                        "values " +
                        "(@IdCobrosMensuales, @Fecha, @Descuentos, @Recargos, @MetodoPago, @Total)";

                    comando.Parameters.AddWithValue("@IdCobrosMensuales", CobrosCaja.IdCobrosMensuales);
                    comando.Parameters.AddWithValue("@Fecha", CobrosCaja.Fecha);
                    comando.Parameters.AddWithValue("@Descuentos", CobrosCaja.Descuentos);
                    comando.Parameters.AddWithValue("@Recargos", CobrosCaja.Recargos);
                    comando.Parameters.AddWithValue("@MetodoPago", CobrosCaja.MetodoPago);
                    comando.Parameters.AddWithValue("@Total", CobrosCaja.Total);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<EntidadVistaCobros> ListaVistaCobros()
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
                        "INNER JOIN datos_alumno ON servicio_escolar.id_alumno = datos_alumno.id_alumno";

                    MySqlDataReader reader = comando.ExecuteReader();
                    List<EntidadVistaCobros> lista = new List<EntidadVistaCobros>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new EntidadVistaCobros
                            {
                                Id_Cobros_Mensuales = reader.GetInt32(0),
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
