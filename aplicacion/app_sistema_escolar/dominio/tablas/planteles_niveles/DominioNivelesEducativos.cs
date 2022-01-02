using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos.tablas.planteles_niveles;
using System.Data;
using comun.Entidades.alumnos;

namespace dominio.tablas.planteles_niveles
{
    public class DominioNivelesEducativos
    {
        DatosNivelesEducativos nivelesEducativos = new DatosNivelesEducativos();

        public DataTable ListarNivelesEducativos()
        {
            return nivelesEducativos.ListarNivelesEducativos();
        }

        public DataTable ListarNivelesDePlantel(EntidadPlantelesNiveles plantel)
        {
            return nivelesEducativos.ListarNivelesDePlantel(plantel);
        }
    }
}
