using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.ventas
{
    public class EntidadVistaCobros
    {
        public int Id_Cobros_Mensuales { get; set; }
        public string Concepto { get; set; }
        public float Precio { get; set; }
        public string Mes_Pago { get; set; }
        public string Estatus { get; set; }
    }
}
