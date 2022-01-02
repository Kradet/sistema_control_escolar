using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using comun.Entidades;
using System.Data;

namespace datos.tablas
{
    // Clase responsable de leer la tabla tipo de usuario y llenar el comboBox del registro de nuevos usuarios
    public class DatosTipoUsuarios : ConeccionSql
    {
        //Listar los tipos de usuarios
        //En este caso uso DateTable por que los datos se van a usar en un combobox
        public DataTable ListarTipoUsuarios()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from tipo_usuario";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        /*
        public List<EntidadTipoUsuario> ListarTipoUsuarios()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "select * from tipo_usuario";

                    MySqlDataReader reader = comando.ExecuteReader();
                    List<EntidadTipoUsuario> tipoUsuarios = new List<EntidadTipoUsuario>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tipoUsuarios.Add(new EntidadTipoUsuario
                            {
                                IdTipoUsuario = reader.GetInt32(0),
                                TipoUsuario = reader.GetString(1)
                            });
                            
                        }
                    }
                    return tipoUsuarios;
                }
            }
        }
        */
    }
}
