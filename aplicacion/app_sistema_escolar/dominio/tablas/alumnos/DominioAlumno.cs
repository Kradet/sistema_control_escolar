using comun.Entidades;
using datos.tablas;
using System;
using System.Collections.Generic;

namespace dominio.tablas
{
    public class DominioAlumno
    {
        DatosAlumno alumno = new DatosAlumno();

        public List<EntidadAlumno> ListarDatosAlumno(string buscar)
        {
            return alumno.ListarDatosAlumno(buscar);
        }

        public bool InsertarDatosAlumno(EntidadAlumno datosAlumno)
        {
            try
            {
                alumno.InsertarDatosAlumno(datosAlumno);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool EditarDatosAlumno(EntidadAlumno datosAlumno)
        {
            try
            {
                alumno.EditarDatosAlumno(datosAlumno);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public EntidadAlumno EncontrarAlumnoPorID(int Id)
        {
            return alumno.EncontarAlumnoPorId(Id);
        }

        public bool EliminarDatosAlumno(EntidadAlumno datosAlumno)
        {
            try
            {
                if (datosAlumno.IdAlumno == 0)
                {
                    return false;
                }
                else
                {
                    alumno.EliminarDatosAlumno(datosAlumno);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
