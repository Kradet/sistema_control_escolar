using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos.tablas;
using comun.Entidades;
using System.Data;

namespace dominio.tablas
{
    public class DominioTipoUsuario
    {
        DatosTipoUsuarios tipoUsuarios = new DatosTipoUsuarios();

        public DataTable ListarTipoUsuarios()
        {
            return tipoUsuarios.ListarTipoUsuarios();
        }
    }
}
