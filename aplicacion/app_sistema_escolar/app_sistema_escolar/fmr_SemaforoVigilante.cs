using comun.Entidades;
using comun.Entidades.servicio_escolar;
using comun.Entidades.ventas;
using dominio.tablas;
using dominio.tablas.servicio_escolar;
using dominio.tablas.ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_sistema_escolar.Formularios.Comun;

namespace app_sistema_escolar
{
    public partial class fmr_SemaforoVigilante : Form
    {
        //Campos
        //Entidades
        EntidadAlumno alumno = new EntidadAlumno();
        EntidadContactoAlumno contactoAlumno = new EntidadContactoAlumno();
        EntidadVistaAlumnoServicio servicioEscolar = new EntidadVistaAlumnoServicio();

        //Logica
        DominioAlumno dominioAlumno = new DominioAlumno();
        DominioContactoAlumno dominioContactoAlumno = new DominioContactoAlumno();
        DominioServicioEscolar dominioServicioEscolar = new DominioServicioEscolar();
        DominioVentas dominioVentas = new DominioVentas();


        //Constructor
        public fmr_SemaforoVigilante()
        {
            InitializeComponent();
        }

        //Carga
        private void fmr_SemaforoVigilante_Load(object sender, EventArgs e)
        {

            labelAlumnoDebe.BackColor = Color.White;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtBucar.Text, out id))
            {
                CargarDatos(id);
            }
            else
            {
                frm_dialogoError.ErrorForm("Ingrese una matricula válida 😾💢");
            }

        }

        public void CargarDatos(int id)
        {
            bool debeUna = false;
            bool debeDos = false;

            alumno.IdAlumno = id;
            alumno = dominioAlumno.EncontrarAlumnoPorID(alumno.IdAlumno);
            contactoAlumno = dominioContactoAlumno.ObtenerContactoAlumno(alumno);
            servicioEscolar = dominioServicioEscolar.VistaAlumnoServicioPorId(alumno.IdAlumno);

            //Datos de alumno
            txtNombreAlumno.Text = alumno.Nombre;
            txtApellidoPaternoAlumno.Text = alumno.ApellidoPaterno;
            txtApellidoMaternoAlumno.Text = alumno.ApellidoMaterno;

            //Nivel educativo
            txtNivelEducativo.Text = servicioEscolar.NombreNivelEducativo;
            txtGrado.Text = servicioEscolar.Grado;
            txtMatricula.Text = alumno.IdAlumno.ToString();

            //información de contacto
            txtNombreTutor.Text = contactoAlumno.NombreTutor;
            txtTelefonoContacto.Text = contactoAlumno.Telefono;
            txtEmailContacto.Text = contactoAlumno.Email;

            List<EntidadVistaCobros> lista = dominioVentas.ObstenerVistaCobrosPorId(alumno.IdAlumno);
            if (lista.Count == 0)
            {
                panelSemaforo.BaseColor = Color.Black;
                labelAlumnoDebe.Text = "Alumno no registrado 🥶";
                return;
            }

            if (lista[lista.Count - 1].Estatus.ToUpper() == "POR PAGAR")
                debeUna = true;

            if (lista[lista.Count - 2].Estatus.ToUpper() == "POR PAGAR")
                debeDos = true;

            if (debeUna)
            {
                panelSemaforo.BaseColor = Color.FromArgb(244, 245, 144); //amarillo
                labelAlumnoDebe.Text = "Este alumno debe: 1 Mes 😘";
            }
            if (debeDos)
            {
                panelSemaforo.BaseColor = Color.FromArgb(247, 101, 95); //rojo
                labelAlumnoDebe.Text = "Este alumno debe: más de dos meses ¡No lo dejen entrar 😡💢🚨!";
            }
            if (!debeUna && !debeDos)
            {
                panelSemaforo.BaseColor = Color.FromArgb(115, 214, 115); //verde
                labelAlumnoDebe.Text = "Este alumno no debe nada!! 🤑💲♥♥♥";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
