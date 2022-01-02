using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.ventas
{
    public class EntidadCobrosCaja
    {
        public int Id { get; set; }
        public int IdCobrosMensuales { get; set; }
        public DateTime Fecha { get; set; }
        public float Descuentos { get; set; }
        public float Recargos { get; set; }
        public string MetodoPago { get; set; }
        public float Total { get; set; }
    }
}
