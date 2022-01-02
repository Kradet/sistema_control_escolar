using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comun.ClasesEstaticas
{
    #region Clase para obtener controles especificos de un contenedor
    /*
     * Creamos un metodo extensor de la clase control
     * devolvemos una coleccion de los controles de un tipo determinado
     * posteriormente usamos esa coleccion para realizar alguna accion sobre cada uno de los elementos devueltos
     * es recursiva por el diseño en paneles
     */
    public static class ObtenerControles
    {
        public static List<T> Controles<T>(this Control container) where T : Control
        {
            List<T> controls = new List<T>();

            foreach (Control c in container.Controls)
            {
                if (c is T)
                    controls.Add((T)c);

                controls.AddRange(Controles<T>(c));
            }

            return controls;
        }
    }
    #endregion
}
