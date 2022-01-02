using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.tablas.planteles_niveles
{
    //Clase responsable de leer la tabla escuela_plantel y llenar el combo box de servicios escolares
    public class DatosPlanteles:ConeccionSql
    {
        //Listar los planteles, retornamos un datatable por que vamos a llenar un combobox
        public DataTable ListarPlanteles()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from escuela_plantel";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

    }
}
