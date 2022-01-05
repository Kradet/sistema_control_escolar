using app_sistema_escolar.Formularios.Comun;
using comun.ClasesEstaticas;
using comun.Entidades;
using comun.Entidades.servicio_escolar;
using dominio.tablas;
using dominio.tablas.servicio_escolar;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using dominio.tablas.ventas;
using comun.Entidades.ventas;
using System.Collections.Generic;
using System.Drawing;

namespace app_sistema_escolar.Formularios.ServiciosEsc.frm_hijos
{
    public partial class frm_serviciosEscolares_verInformacionAlumno : Form
    {
        //Campos
        //Entidades
        EntidadAlumno alumno = new EntidadAlumno();
        EntidadContactoAlumno contactoAlumno = new EntidadContactoAlumno();
        EntidadVistaAlumnoServicio servicioEscolar = new EntidadVistaAlumnoServicio();
        EntidadVistaCobros entidadVistaCobros = new EntidadVistaCobros();

        //Logica
        DominioAlumno dominioAlumno = new DominioAlumno();
        DominioContactoAlumno dominioContactoAlumno = new DominioContactoAlumno();
        DominioServicioEscolar dominioServicioEscolar = new DominioServicioEscolar();
        DominioVentas dominioVentas = new DominioVentas();

        //Constructor
        public frm_serviciosEscolares_verInformacionAlumno(int idAlumno)
        {
            InitializeComponent();
            alumno.IdAlumno = idAlumno;
        }

        //Carga del formulario
        private void frm_serviciosEscolares_verInformacionAlumno_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        //Cargar cajas de texto y clases
        private void CargarDatos()
        {
            bool debeUna = false;
            bool debeDos = false;

            alumno = dominioAlumno.EncontrarAlumnoPorID(alumno.IdAlumno);
            contactoAlumno = dominioContactoAlumno.ObtenerContactoAlumno(alumno);
            servicioEscolar = dominioServicioEscolar.VistaAlumnoServicioPorId(alumno.IdAlumno);

            //Datos de alumno
            txtNombreAlumno.Text = alumno.Nombre;
            txtApellidoPaternoAlumno.Text = alumno.ApellidoPaterno;
            txtApellidoMaternoAlumno.Text = alumno.ApellidoMaterno;
            txtSexoAlumno.Text = alumno.Sexo.ToString();
            txtCurpAlumno.Text = alumno.Curp;
            dpFechaNacimiento.Value = alumno.FechaNacimiento;
            txtNacionalidadAlumno.Text = alumno.Nacionalidad;
            txtEmailAlumno.Text = alumno.Email;

            //Nivel educativo
            txtNivelEducativo.Text = servicioEscolar.NombreNivelEducativo;
            txtPlantel.Text = servicioEscolar.NombrePlantel;
            txtGrado.Text = servicioEscolar.Grado;
            txtMatricula.Text = alumno.IdAlumno.ToString();
            txtEstatus.Text = servicioEscolar.Status;

            //información de contacto
            txtNombreTutor.Text = contactoAlumno.NombreTutor;
            txtTelefonoContacto.Text = contactoAlumno.Telefono;
            txtEmailContacto.Text = contactoAlumno.Email;
            txtDireccionContacto.Text = contactoAlumno.Direccion;

            List<EntidadVistaCobros> lista = dominioVentas.ObstenerVistaCobrosPorId(alumno.IdAlumno);
            if (lista.Count == 0)
            {
                panelSemaforo.BaseColor = Color.Black;
                return;
            }

            //entidadVistaCobros = lista[lista.Count - 1];

            //if (entidadVistaCobros.Estatus.ToUpper() == "PAGADO")
            //    panelSemaforo.BaseColor = Color.FromArgb(115, 214, 115);
            //else if (entidadVistaCobros.Estatus.ToUpper() == "POR PAGAR")
            //    panelSemaforo.BaseColor = Color.FromArgb(247, 101, 95);
            //else
            //    panelSemaforo.BaseColor = Color.DarkGray;

            if (lista[lista.Count - 1].Estatus.ToUpper() == "POR PAGAR")
                debeUna = true;
            
            if (lista[lista.Count - 2].Estatus.ToUpper() == "POR PAGAR")
                debeDos = true;

            if (debeUna)
                panelSemaforo.BaseColor = Color.FromArgb(244, 245, 144); //amarillo
            if (debeDos)
                panelSemaforo.BaseColor = Color.FromArgb(247, 101, 95); //rojo
            if (!debeUna && !debeDos)
                panelSemaforo.BaseColor = Color.FromArgb(115, 214, 115); //verde
            
        }


        //Botones
        //Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;

            //Habilitamos los texbox y el datetimepicker
            panelContenedor.Controles<Guna.UI.WinForms.GunaTextBox>().ForEach(texbox => texbox.Enabled = true);
            txtMatricula.Enabled = false;
            dpFechaNacimiento.Enabled = true;

            txtNivelEducativo.Enabled = false;
            txtPlantel.Enabled = false;
            txtGrado.Enabled = false;
            txtEstatus.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool puedeEditar = true;

            //Verificamos que no haya ningun texbox vacío y la validez de los datos
            panelContenedor.Controles<Guna.UI.WinForms.GunaTextBox>().ForEach(tex =>
            {
                if (tex.Text == "")
                {
                    frm_dialogoError.ErrorForm("No debe dejar campos vacios");
                    puedeEditar = false;
                    return;
                    //break;
                }
                if (tex.Name != "txtMatricula" && tex.Name != "txtSexoAlumno" && tex.Name != "txtGrado" && tex.Text.Length < 3)
                {
                    frm_dialogoError.ErrorForm($"Debe ingresar al menos 4 caracteres");
                    puedeEditar = false;
                    return;
                }
                if (tex.Name == "txtCurpAlumno" && tex.Text.Length != 18)
                {
                    frm_dialogoError.ErrorForm("La CURP debe tener 18 caracteres");
                    puedeEditar = false;
                    return;
                }
                if (tex.Name == "txtSexoAlumno" && (tex.Text != "F" && tex.Text != "f" && tex.Text != "M" && tex.Text != "m"))
                {
                    frm_dialogoError.ErrorForm("Debe ingresar un sexo valido (F/M)");
                    puedeEditar = false;
                }
                if ((tex.Name == "txtEmailAlumno" || tex.Name == "txtEmailContacto") && !new EmailAddressAttribute().IsValid(tex.Text))
                {
                    frm_dialogoError.ErrorForm("Verfique el email y vuelvalo a intentar");
                    puedeEditar = false;
                    return;
                }
                if (tex.Name == "txtTelefonoContacto" && tex.Text.Length != 10)
                {
                    frm_dialogoError.ErrorForm("El numero telefonico debe tener 10 digitos");
                    puedeEditar = false;
                    return;
                }
            });

                //Actualizamos los datos de la db
            if (puedeEditar)
            {
                //Alumno
                alumno.Nombre = txtNombreAlumno.Text;
                alumno.ApellidoPaterno = txtApellidoPaternoAlumno.Text;
                alumno.ApellidoMaterno = txtApellidoMaternoAlumno.Text;
                alumno.Sexo = Convert.ToChar(txtSexoAlumno.Text);
                alumno.Curp = txtCurpAlumno.Text;
                alumno.FechaNacimiento = dpFechaNacimiento.Value;
                alumno.Nacionalidad = txtNacionalidadAlumno.Text;
                alumno.Email = txtEmailAlumno.Text;

                dominioAlumno.EditarDatosAlumno(alumno);

                //Información de contacto
                contactoAlumno.IdAlumno = alumno.IdAlumno;
                contactoAlumno.NombreTutor = txtNombreTutor.Text;
                contactoAlumno.Telefono = txtTelefonoContacto.Text;
                contactoAlumno.Email = txtEmailContacto.Text;
                contactoAlumno.Direccion = txtDireccionContacto.Text;

                dominioContactoAlumno.EditarContactoAlumno(contactoAlumno);

                //Deshabilitamos los controles 
                btnEditar.Enabled = true;
                btnGuardar.Enabled = false;

                //Deshabilitamos los texbox y el datetimepicker
                panelContenedor.Controles<Guna.UI.WinForms.GunaTextBox>().ForEach(texbox => texbox.Enabled = false);
                dpFechaNacimiento.Enabled = false;

                frm_dialogoDone.ConfirmacionForm("Datos editados correctamente 😘");
            }
        }
    }
}
