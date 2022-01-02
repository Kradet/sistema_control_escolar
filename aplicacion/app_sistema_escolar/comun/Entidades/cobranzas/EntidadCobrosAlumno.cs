using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.cobranzas
{
    public class EntidadCobrosAlumno
    {
        public int IdCobrosAlumno { get; set; }
        public int IdServicioEscolar { get; set; }
        public int IdConceptoCobranza { get; set; }
        public string CicloEscolar { get; set; }
    }
}
