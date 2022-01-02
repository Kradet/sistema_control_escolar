using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.ventas
{
    public class EntidadSesionCaja
    {
        public int IdSesionCaja { get; set; }
        public int IdUsuario { get; set; }
        public int IdCaja { get; set; }
        public string Estatus { get; set; }
        public string HoraApertura { get; set; }
        public string HoraCierre { get; set; }
        public float CantidadInicial { get; set; }
    }
}
