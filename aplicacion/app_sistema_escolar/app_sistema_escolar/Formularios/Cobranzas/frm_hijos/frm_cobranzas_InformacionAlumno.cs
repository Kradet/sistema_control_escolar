using app_sistema_escolar.Formularios.Comun;
using comun.Entidades;
using comun.Entidades.servicio_escolar;
using dominio.tablas;
using dominio.tablas.servicio_escolar;
using System;
using System.Windows.Forms;
using comun.cache;

namespace app_sistema_escolar.Formularios.Cobranzas.frm_hijos
{
    public partial class frm_cobranzas_InformacionAlumno : Form
    {
        // Campos
        //Entidades
        EntidadAlumno alumno;
        EntidadContactoAlumno contactoAlumno;
        EntidadVistaAlumnoServicio servicioEscolar;

        //Logica
        DominioAlumno dominioAlumno = new DominioAlumno();
        DominioContactoAlumno dominioContactoAlumno = new DominioContactoAlumno();
        DominioServicioEscolar dominioServicioEscolar = new DominioServicioEscolar();

        //Constructor
        public frm_cobranzas_InformacionAlumno()
        {
            InitializeComponent();
        }

        //Boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                alumno = dominioAlumno.EncontrarAlumnoPorID(int.Parse(txtBuscar.Text));
                contactoAlumno = dominioContactoAlumno.ObtenerContactoAlumno(alumno);
                servicioEscolar = dominioServicioEscolar.VistaAlumnoServicioPorId(alumno.IdAlumno);

                AlumnoSeleccionadoCache.AlumnoSelecionado = alumno;
                AlumnoSeleccionadoCache.ContactoAlumnoSeleccionado = contactoAlumno;

                CargarDatos();

            }
            else
            {
                frm_dialogoError.ErrorForm("Ingrese una matricula valida");
                return;
            }

        }

        //Cargamos los datos
        private void CargarDatos()
        {
            //Datos Alumno / Personal
            txtNombreAlumno.Text = alumno.Nombre;
            txtApellidoPaternoAlumno.Text = alumno.ApellidoPaterno;
            txtApellidoMaternoAlumno.Text = alumno.ApellidoMaterno;
            txtSexoAlumno.Text = alumno.Sexo.ToString();
            txtCurpAlumno.Text = alumno.Curp;
            dpFechaNacimiento.Value = alumno.FechaNacimiento;

            txtMatriculaSeleccionada.Text = alumno.IdAlumno.ToString();

            //Información Escolar
            txtProgramaEducativo.Text = servicioEscolar.NombreNivelEducativo;
            txtPlantel.Text = servicioEscolar.NombrePlantel;
            txtGrado.Text = servicioEscolar.Grado;
            txtMatricula.Text = alumno.IdAlumno.ToString();
            txtEstatus.Text = servicioEscolar.Status;

            //Información de contacto
            txtNombreTutor.Text = contactoAlumno.NombreTutor;
            txtTelefonoContacto.Text = contactoAlumno.Telefono;
            txtEmailContacto.Text = contactoAlumno.Email;
            txtDireccionContacto.Text = contactoAlumno.Direccion;
        }
    }
}
