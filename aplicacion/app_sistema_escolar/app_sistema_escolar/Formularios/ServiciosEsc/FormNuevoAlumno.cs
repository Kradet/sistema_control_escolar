using app_sistema_escolar.Formularios.Comun;
using comun.Entidades;
using dominio.tablas;
using System;
using System.Windows.Forms;

namespace app_sistema_escolar.Formularios.ServiciosEsc
{
    public partial class FormNuevoAlumno : Form
    {
        EntidadAlumno alumno = new EntidadAlumno();
        EntidadContactoAlumno contactoAlumno = new EntidadContactoAlumno();

        DominioContactoAlumno dominioContacto = new DominioContactoAlumno();
        DominioAlumno dominioAlumno = new DominioAlumno();

        public FormNuevoAlumno()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNuevoAlumno_Load(object sender, EventArgs e)
        {
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

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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

            if (dominioAlumno.InsertarDatosAlumno(alumno) && dominioContacto.InsertarContactoAlumnoCurp(contactoAlumno, alumno))
            {
                new FormSucces("AÑADIDO", "Registro añadido correctamente").ShowDialog();
                Close();
            }
            else
            {
                new FormError("ERROR", "Ocurrió un error, por favor verifique sus datos").ShowDialog();
            }

            this.Close();
        }
    }

}
