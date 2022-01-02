using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.alumnos
{
    public class EntidadPlantelesNiveles
    {
        //niveles educativos
        public  int IdNivel { get; set; }
        public string NombreNivel { get; set; }

        //escuela_plante o planteles, el diseñador de db no se pone de acuerdo
        public int IdPlantel { get; set; }
        public string NombrePlantel { get; set; } // En la base de datos nada más está como "Nombre" .__.''

        //Union de tablas
        public int ClaveProgramaEducativo { get; set; }
    }   
}
