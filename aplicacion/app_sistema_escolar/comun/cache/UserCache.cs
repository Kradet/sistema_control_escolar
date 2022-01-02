using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun.cache
{
    public static class UserCache
    {
        public static int IdUsuario { get; set; }
        public static int IdTipoUsuario { get; set; }
        public static string TipoUsuario { get; set; }
        public static string UserName { get; set; }
        public static string Nombre { get; set; }
    }

    public enum Posiciones
    {
        administrador,
        cobranza,
        cajero,
        servicios_escolares,
        alumno
    }
}
