using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos.tablas.cobranzas;
using comun.Entidades.cobranzas;

namespace dominio.tablas.cobranzas
{
    public class DominioConceptoCobranzas
    {
        DatosConceptoCobranzas conceptoCobrazas = new DatosConceptoCobranzas();

        public List<EntidadConceptoCobranzas> ListarConceptoConbranzas()
        {
            return conceptoCobrazas.ListarConceptoCobranzas();
        }

        public void InsertarConcepto(EntidadConceptoCobranzas concepto)
        {
            conceptoCobrazas.InsertarConceptoCobranza(concepto);
        }
    }
}
