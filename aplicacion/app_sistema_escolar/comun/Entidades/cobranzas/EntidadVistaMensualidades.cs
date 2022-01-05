using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.Entidades.cobranzas
{
    public class EntidadVistaMensualidades
    {
        public int Id { get; set; }
        public string Concepto { get; set; }
        public float Precio { get; set; }
        public string Mes_Pago { get; set; }
        public string Estatus { get; set; }
    }
}
