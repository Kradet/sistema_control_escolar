using comun.Entidades;
using comun.Entidades.alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos.tablas.servicio_escolar;
using comun.Entidades.servicio_escolar;

namespace dominio.tablas.servicio_escolar
{
    public class DominioServicioEscolar
    {
        DatosServicioEscolar servicioEscolar = new DatosServicioEscolar();

        public bool InsertarAlumnoProgramaEducativo(EntidadAlumno alumno, EntidadPlantelesNiveles plantelNivel)
        {
            servicioEscolar.InsertarAlumnoProgramaEducativo(alumno, plantelNivel);
            return true;
        }

        //public bool InsertarGradoGrupoEstatus(string grado, string grupo, string status, EntidadAlumno alumno)
        //{
        //    servicioEscolar.InsertarGradoGrupoEstatus(grado, grupo, status, alumno);
        //    return true;
        //}

        public EntidadVistaAlumnoServicio VistaAlumnoServicioPorId(int idAlumno)
        {
            EntidadVistaAlumnoServicio alumno =   servicioEscolar.VistaAlumnoServicioPorId(idAlumno);
            return alumno;
        }

        public void InsertarDatosServicioEscolar(EntidadVistaAlumnoServicio alumnoServicio)
        {
            servicioEscolar.InsertarDatosServicioEscolar(alumnoServicio);
        }

        public EntidadServicioEscolar ObtenerServicioEscolarIdAlumno(EntidadAlumno alumno)
        {
            return servicioEscolar.ObtenerServicioSocialIdAlumno(alumno);
        }
    }
}
