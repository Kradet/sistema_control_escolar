using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.servicio_escolar
{
    public class EntidadVistaAlumnoServicio
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        public int IdClaveProgramaEducativo { get; set; }
        public string Grado { get; set; }
        public string Grupo { get; set; }
        public string Status { get; set; }

        public int  IdPlantel { get; set; }
        public int  IdNivelEducativo { get; set; }
        public string NombrePlantel { get; set; }
        public string NombreNivelEducativo { get; set; }
    }
}
