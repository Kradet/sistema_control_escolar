using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comun.Entidades;
using comun.Entidades.cobranzas;
using datos.tablas.cobranzas;

namespace dominio.tablas.cobranzas
{
    public class DominioCobranza
    {
        DatosCobranza datosCobranza = new DatosCobranza();

        public List<EntidadMensualidad> ListarMensualidad(EntidadAlumno Alumno)
        {
            return datosCobranza.ListarMensualidad(Alumno);
        }

        public void InsertarCobroMensual(EntidadCobrosMensuales Cobro)
        {
            datosCobranza.InsertarCobroMensual(Cobro);
        }

        public List<EntidadVistaMensualidades> ListarVistaMensualidades(int IdAlumno)
        {
            return datosCobranza.ListarVistaMensualidades(IdAlumno);
        }
    }
}
