using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.servicio_escolar
{
    public class EntidadServicioEscolar
    {
        public int IdServicioEscolar { get; set; }
        public int IdClaveProgramaEducativo { get; set; }
        public int IdAlumno { get; set; }
        public string Grado { get; set; }
        public string Grupo { get; set; }
        public string Status { get; set; }

    }
}
