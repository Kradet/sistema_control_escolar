using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.ventas
{
    public class EntidadRecibo
    {
        public int IdTicket { get; set; }
        public int MatriculaAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoPaternoAlumno { get; set; }
        public string ApellidoMaternoAlumno { get; set; }
        public string NombreEscuela { get; set; }
        public string NiveEducativo { get; set; }
        public string Concepto { get; set; }
        public float Precio { get; set; }
        public DateTime Fecha { get; set; }
        public float Descuento { get; set; }
        public float Recargo { get; set; }
        public string MetodoPago { get; set; }
        public float Total { get; set; }
    }
}
