using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos.tablas.ventas;
using comun.Entidades.ventas;

namespace dominio.tablas.ventas
{
    public class DominioVentas
    {
        DatosVentas datosVentas = new DatosVentas();

        public List<EntidadCaja> ListarCajas()
        {
            return datosVentas.ListarCajas();
        }

        public EntidadSesionCaja ObtenerSesionCajaPorIdCaja(int id)
        {
            return datosVentas.ObtenerSesionCajaPorIdCaja(id);
        }

        public void AbrirCerrarSesionCaja(EntidadSesionCaja sesionCaja)
        {
            datosVentas.AbrirCerrarSesionCaja(sesionCaja);
        }
    }
}
