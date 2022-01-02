using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades
{
    public class EntidadContactoAlumno
    {
        public int IdContactoAlumno { get; set; }
        public int IdAlumno { get; set; }
        public string NombreTutor { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
}
