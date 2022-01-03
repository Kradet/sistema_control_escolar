using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

// La clase de conección será abstracta por que es unicamente la cadena de coneccion, en otras clases estaran las funcionalidades
namespace datos
{
    public abstract class ConeccionSql
    {
        private readonly string cadenaConeccion;

        public ConeccionSql()
        {
            cadenaConeccion = "server=localhost; database=sistema_escolar; uid=root; password=''";
        }

        // Un miembro protegido es accesible dentro de su clase y por parte de instancias de clase derivadas
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(cadenaConeccion);
        }
    }
}
