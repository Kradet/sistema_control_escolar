using comun.Entidades.alumnos;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace datos.tablas.planteles_niveles
{
    //Clase responsable de leer la tabla niveles_educativos y llenar el combo box de servicios escolares
    public class DatosNivelesEducativos : ConeccionSql
    {
        //Listar los niveles educativos,  retornamos un datatable por que vamos a llenar un combobox
        public DataTable ListarNivelesEducativos()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from niveles_educativos";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public DataTable ListarNivelesDePlantel(EntidadPlantelesNiveles plantelNivel)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = $"select * from planteles_niveles where plantel_id_plantel = {plantelNivel.IdPlantel}";

                    MySqlDataReader reader = comando.ExecuteReader();
                    List<EntidadPlantelesNiveles> listaPlantelesNiveles = new List<EntidadPlantelesNiveles>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listaPlantelesNiveles.Add(new EntidadPlantelesNiveles
                            {
                                ClaveProgramaEducativo = reader.GetInt32(0),
                                IdPlantel = reader.GetInt32(1),
                                IdNivel = reader.GetInt32(2)
                            });
                        }
                    }
                    reader.Close(); //Si no se cierra lanza una excepción y no sé por qué xD

                    DataTable tablaNivelesEducativos = new DataTable();

                    foreach (var nivel in listaPlantelesNiveles)
                    {
                        comando.CommandText = $"select * from niveles_educativos where id_nivel = {nivel.IdNivel}";
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                        dataAdapter.Fill(tablaNivelesEducativos);
                    }

                    return tablaNivelesEducativos;

                }
            }
        }
    }
}
