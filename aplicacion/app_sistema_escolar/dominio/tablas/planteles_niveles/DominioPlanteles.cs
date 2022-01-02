using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos.tablas.planteles_niveles;
using System.Data;

namespace dominio.tablas.planteles_niveles
{
    public class DominioPlanteles
    {
        DatosPlanteles nivelesEducativos = new DatosPlanteles();

        public DataTable ListarPlanteles()
        {
            return nivelesEducativos.ListarPlanteles();
        }
    }
}
