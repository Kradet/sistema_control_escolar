using comun.Entidades;
using datos.tablas;

namespace dominio.tablas
{
    public class DominioContactoAlumno
    {
        DatosContactoAlumno contactoAlumno = new DatosContactoAlumno();

        public EntidadContactoAlumno ObtenerContactoAlumno(EntidadAlumno alumno)
        {
            return contactoAlumno.ObtenerContactoAlumno(alumno);
        }

        public bool EditarContactoAlumno(EntidadContactoAlumno contacto)
        {
            if (contacto.IdAlumno == 0)
            {
                return false;
            }
            else
            {
                try
                {
                    contactoAlumno.EditarContactoAlumno(contacto);
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        public bool InsertarContactoAlumnoCurp(EntidadContactoAlumno contactoAlumno, EntidadAlumno alumno)
        {
            try
            {
                this.contactoAlumno.InsertarContactoAlumnoCurp(contactoAlumno, alumno);
                return true;

            }
            catch (System.Exception)
            {
                return false;
                throw;
            }
        }
    }

}
