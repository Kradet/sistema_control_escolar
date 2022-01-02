using comun.Entidades;
using dominio.tablas;
using System;
using System.Windows.Forms;
using app_sistema_escolar.Formularios.Comun;

namespace app_sistema_escolar.Formularios.ServiciosEsc
{
    public partial class FormVerContactoAlumno : Form
    {
        EntidadAlumno alumno;
        EntidadContactoAlumno contactoAlumno;

        DominioContactoAlumno dominioContacto = new DominioContactoAlumno();
        DominioAlumno dominioAlumno = new DominioAlumno();

        public FormVerContactoAlumno(int IdAlumno)
        {
            InitializeComponent();
            alumno = new DominioAlumno().EncontrarAlumnoPorID(IdAlumno);
            contactoAlumno = new DominioContactoAlumno().ObtenerContactoAlumno(alumno);
        }

        private void FormVerContactoAlumno_Load(object sender, EventArgs e)
        {
            txtIdAlumno.Text = alumno.IdAlumno.ToString();
            txtNombreAlumno.Text = alumno.Nombre;
            txtApellidoPaternoAlumno.Text = alumno.ApellidoPaterno;
            txtApellidoMaternoAlumno.Text = alumno.ApellidoMaterno;
            txtSexoAlumno.Text = alumno.Sexo.ToString();
            txtCurpAlumno.Text = alumno.Curp;
            dpFechaNacimiento.Value = Convert.ToDateTime(alumno.FechaNacimiento);
            txtNacionalidadAlumno.Text = alumno.Nacionalidad;
            txtEmailAlumno.Text = alumno.Email;
            txtNombreTutor.Text = contactoAlumno.NombreTutor;
            txtTelefono.Text = contactoAlumno.Telefono;
            txtEmailContacto.Text = contactoAlumno.Email;
            txtDireccion.Text = contactoAlumno.Direccion;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActivarCuadrosTexto();
            btnGuardar.Enabled = true;
        }

        private void ActivarCuadrosTexto()
        {
            //txtIdAlumno.ReadOnly = false;
            txtNombreAlumno.ReadOnly = false;
            txtApellidoPaternoAlumno.ReadOnly = false;
            txtApellidoMaternoAlumno.ReadOnly = false;
            txtSexoAlumno.ReadOnly = false;
            txtCurpAlumno.ReadOnly = false;
            txtNacionalidadAlumno.ReadOnly = false;
            txtEmailAlumno.ReadOnly = false;
            txtNombreTutor.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtEmailContacto.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            dpFechaNacimiento.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            contactoAlumno.IdAlumno = int.Parse(txtIdAlumno.Text);

            alumno.Nombre = txtNombreAlumno.Text;
            alumno.ApellidoPaterno = txtApellidoPaternoAlumno.Text;
            alumno.ApellidoMaterno = txtApellidoMaternoAlumno.Text;
            alumno.Sexo = Convert.ToChar(txtSexoAlumno.Text);
            alumno.Curp = txtCurpAlumno.Text;
            alumno.Nacionalidad = txtNacionalidadAlumno.Text;
            alumno.Email = txtEmailAlumno.Text;
            contactoAlumno.NombreTutor = txtNombreAlumno.Text;
            contactoAlumno.Telefono = txtTelefono.Text;
            contactoAlumno.Email = txtEmailContacto.Text;
            contactoAlumno.Direccion = txtDireccion.Text;

            alumno.FechaNacimiento = dpFechaNacimiento.Value;

            if (dominioAlumno.EditarDatosAlumno(alumno) && dominioContacto.EditarContactoAlumno(contactoAlumno))
            {
                new FormSucces("EDITADO", "Registro editado correctamente").ShowDialog();
                this.Close();
            }
            else
            {
                new FormError("ERROR", "Ha ocurrido un error al editar el registro, verifique sus datos").ShowDialog();
            }
        }
    }
}
