using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos.tablas.cobranzas;
using comun.Entidades.cobranzas;

namespace dominio.tablas.cobranzas
{
    public class DominoCobrosAlumno
    {
        DatosCobrosAlumno cobrosAlumno = new DatosCobrosAlumno();

        public List<EntidadCobrosAlumno> ListarCobrosAlumno()
        {
            return cobrosAlumno.ListarCobrosAlumno();
        }

        public void InsertarCobrosAlumno(EntidadCobrosAlumno cobros)
        {
            cobrosAlumno.InsertarCobroAlumno(cobros);
        }
    }
}
