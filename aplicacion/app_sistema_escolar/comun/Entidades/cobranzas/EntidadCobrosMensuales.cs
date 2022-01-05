using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.cobranzas
{
    public class EntidadCobrosMensuales
    {
        public int IdCobrosMensuales { get; set; }
        public int IdCobrosAlumno{ get; set; }
        public string MesPago { get; set; }
        public string Estatus { get; set; }
    }
}
