using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comun.Entidades.cobranzas;

namespace datos.tablas.cobranzas
{
    public class DatosConceptoCobranzas : ConeccionSql
    {
        //Listar la tabla conceptos_cobranzas
        public List<EntidadConceptoCobranzas> ListarConceptoCobranzas()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select id_Folio_cobranza as 'Folio', Concepto, Precio from conceptos_cobranza";

                    MySqlDataReader reader = comando.ExecuteReader();
                    List<EntidadConceptoCobranzas> lista = new List<EntidadConceptoCobranzas>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lista.Add(new EntidadConceptoCobranzas
                            {
                                Id = reader.GetInt32(0),
                                Concepto = reader.GetString(1),
                                Precio = reader.GetFloat(2)
                            });
                        }
                    }

                    return lista;
                }
            }
        }

        //insertar conceptos_cobranzas
        public void InsertarConceptoCobranza(EntidadConceptoCobranzas concepto)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "insert into conceptos_cobranza (concepto, precio) values (@Concepto, @Precio)";

                    comando.Parameters.AddWithValue("@Concepto", concepto.Concepto);
                    comando.Parameters.AddWithValue("@Precio", concepto.Precio);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
