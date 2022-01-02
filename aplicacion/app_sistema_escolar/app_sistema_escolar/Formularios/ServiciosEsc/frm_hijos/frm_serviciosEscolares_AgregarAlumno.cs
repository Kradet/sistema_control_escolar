using app_sistema_escolar.Formularios.Comun;
using comun.Entidades;
using dominio.tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using comun.ClasesEstaticas;

namespace app_sistema_escolar.Formularios.ServiciosEsc.frm_hijos
{
    public partial class frm_serviciosEscolares_AgregarAlumno : Form
    {
        //campos
        EntidadAlumno alumno = new EntidadAlumno();
        EntidadContactoAlumno contactoAlumno = new EntidadContactoAlumno();

        DominioContactoAlumno dominioContacto = new DominioContactoAlumno();
        DominioAlumno dominioAlumno = new DominioAlumno();

        public frm_serviciosEscolares_AgregarAlumno()
        {
            InitializeComponent();
        }

        #region Botones
        //Cerrar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Guardar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (dominioAlumno.InsertarDatosAlumno(alumno) && dominioContacto.InsertarContactoAlumnoCurp(contactoAlumno, alumno))
                    new frm_dialogoDone("Alumno añadido correctamente").ShowDialog();
                else
                    new frm_dialogoError("Ha ocurrido un error, por favor intentelo nuevamente").ShowDialog();

                //Limpiamos los cudros de texto
                panel2.Controles<Guna.UI.WinForms.GunaTextBox>().ForEach(texbox => texbox.Text = string.Empty);
                txtTitulo.Text = "Registrar nuevo alumno";
            }
        }

        //Verificacion de datos
        private bool VerificarDatos()
        {
            bool datosCorrectos = false;

            //Verificamos el nombre
            if (txtNombreAlumno.Text != "" && txtNombreAlumno.Text.Length > 3)
            {
                datosCorrectos = true;
                alumno.Nombre = txtNombreAlumno.Text;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("Ingrese un nombre valido").ShowDialog();
                return datosCorrectos;
            }

            //Verificamos el apellido paterno
            if (txtApellidoPaternoAlumno.Text != "" && txtApellidoPaternoAlumno.Text.Length > 3)
            {
                datosCorrectos = true;
                alumno.ApellidoPaterno = txtApellidoPaternoAlumno.Text;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("Ingrese un apellido paterno valido").ShowDialog();
                return datosCorrectos;
            }

            //Verificamos el apellido materno
            if (txtApellidoMaternoAlumno.Text != "" && txtApellidoMaternoAlumno.Text.Length > 3)
            {
                datosCorrectos = true;
                alumno.ApellidoMaterno = txtApellidoMaternoAlumno.Text;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("Ingrese un apellido materno valido").ShowDialog();
                return datosCorrectos;
            }

            //Verificamos el sexo
            if (txtSexoAlumno.Text == "F" || txtSexoAlumno.Text == "f" || txtSexoAlumno.Text == "M" || txtSexoAlumno.Text == "m")
            {
                //alumno.Sexo = txtSexoAlumno.Text[0];
                alumno.Sexo = Convert.ToChar(txtSexoAlumno.Text);
                datosCorrectos = true;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("Ingrese un sexo valido").ShowDialog();
                return datosCorrectos;
            }

            //Verficamos la CRURP
            if (txtCurpAlumno.Text != "" && txtCurpAlumno.Text.Length == 18)
            {
                alumno.Curp = txtCurpAlumno.Text;
                datosCorrectos = true;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("La CURP no es valida").ShowDialog();
                return datosCorrectos;
            }

            //Verificamos la nacionalidad
            if (txtNacionalidadAlumno.Text != "" && txtNacionalidadAlumno.Text.Length > 3)
            {
                alumno.Nacionalidad = txtNacionalidadAlumno.Text;
                datosCorrectos = true;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("La nacionalidad no es valida").ShowDialog();
                return datosCorrectos;
            }

            // Verificamos el email
            if (new EmailAddressAttribute().IsValid(txtEmailAlumno.Text))
            {
                alumno.Email = txtEmailAlumno.Text;
                datosCorrectos = true;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("El email no es valido").ShowDialog();
                return datosCorrectos;
            }

            //Verificamos el nombre del tutor
            if (txtNombreTutor.Text != "" && txtNombreTutor.Text.Length > 9)
            {
                contactoAlumno.NombreTutor = txtNombreTutor.Text;
                datosCorrectos = true;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("EL nombre del tutor no es valido\nDebe contener al menos un nombre y un apellido").ShowDialog();
                return datosCorrectos;
            }

            //Verificamos el telefono de contacto
            if (txtTelefonoContacto.Text != "" && txtTelefonoContacto.Text.Length == 10)
            {
                contactoAlumno.Telefono = txtTelefonoContacto.Text;
                datosCorrectos = true;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("El telefono de contacto no es valido\nDebe ser de 10 digitos").ShowDialog();
                return datosCorrectos;
            }

            //Verificamos el email de contaco
            if (new EmailAddressAttribute().IsValid(txtEmailContacto.Text))
            {
                contactoAlumno.Email = txtEmailContacto.Text;
                datosCorrectos = true;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("El email de contacto no es valido").ShowDialog();
                return datosCorrectos;
            }

            //Verificamos la direccion
            if (txtDireccionContacto.Text != "" && txtDireccionContacto.Text.Length > 10)
            {
                contactoAlumno.Direccion = txtDireccionContacto.Text;
                datosCorrectos = true;
            }
            else
            {
                datosCorrectos = false;
                new frm_dialogoError("La dirección no es valida").ShowDialog();
                return datosCorrectos;
            }

            //Añadimos la fecha de nacimiento
            alumno.FechaNacimiento = dpFechaNacimiento.Value;

            return datosCorrectos;
        }
       
        #endregion
    }
}
