using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.cobranzas
{
    public class EntidadVistaCrearMensualidad
    {
        public int IdCobrosAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoPaternoAlumno { get; set; }
        public string ApellidoMaternoAlumno { get; set; }
        public string Concepto { get; set; }
        public float Precio { get; set; }
    }
}
