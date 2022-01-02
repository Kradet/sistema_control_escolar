using app_sistema_escolar.Formularios.Comun;
using comun.Entidades;
using comun.Entidades.alumnos;
using comun.Entidades.servicio_escolar;
using dominio.tablas.servicio_escolar;
using System;
using System.Windows.Forms;



namespace app_sistema_escolar.Formularios.ServiciosEsc.frm_hijos
{
    public partial class frm_serviciosEscolares_vinculacion : Form
    {
        //Constructor
        public frm_serviciosEscolares_vinculacion()
        {
            InitializeComponent();
        }

        //Campos
        EntidadVistaAlumnoServicio alumnoServicio = new EntidadVistaAlumnoServicio();
        DominioServicioEscolar servicioEscolar = new DominioServicioEscolar();
        EntidadPlantelesNiveles plantelNivel = new EntidadPlantelesNiveles();

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtMatriculaAlumno.Text, out id))
            {
                CargarCuadroTextos(id);
                btnEditar.Enabled = true;
            }
            else
                frm_dialogoError.ErrorForm("Ingrese una matricula valida 😡");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtMatriculaAlumno.Enabled = false;
            btnVerificarMatricula.Enabled = false;
            btnEditar.Enabled = false;

            ActivarDesactivarCuadroTextos(true);
        }

        private void btnProgrmaEducativo_Click(object sender, EventArgs e)
        {
            frm_serviciosEscolares_programaEducativo programaEducativo = new frm_serviciosEscolares_programaEducativo(new EntidadAlumno
            {
                IdAlumno = int.Parse(txtMatriculaAlumno.Text)
            });
            
            programaEducativo.ShowDialog();

            plantelNivel = programaEducativo.entidadPlantelesNiveles;
            frm_dialogoDone.ConfirmacionForm("Programa educativo seleccionado correctamente 👍");
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtGrupoAlumno.Text != "" && txtGrupoAlumno.Text.Length == 1 &&
                txtGradoAlumno.Text != "" && txtGradoAlumno.Text.Length == 1 &&
                txtEstatus.Text != "" && txtEstatus.Text.Length > 3)
            {
                EntidadVistaAlumnoServicio alumnoServicio = new EntidadVistaAlumnoServicio();
                
                //Asignamos valores
                alumnoServicio.Grado = txtGradoAlumno.Text;
                alumnoServicio.Grupo = txtGrupoAlumno.Text;
                alumnoServicio.Status = txtEstatus.Text;
                alumnoServicio.IdAlumno = int.Parse(txtMatriculaAlumno.Text);

                alumnoServicio.IdNivelEducativo = plantelNivel.IdNivel;
                alumnoServicio.IdPlantel = plantelNivel.IdPlantel;




                //Insertamos en db
                servicioEscolar.InsertarDatosServicioEscolar(alumnoServicio);

                //Visuales del formulario
                frm_dialogoDone.ConfirmacionForm("Alumno vinculado correctamente 👍");
                ActivarDesactivarCuadroTextos(false);
                btnVerificarMatricula.Enabled = true;
                txtMatriculaAlumno.Enabled = true;

                btnVerificar_Click(sender, e);
            }
            else
                frm_dialogoError.ErrorForm("Ingrese valores validos y vuelvalo a intentar 😠");
        }

        private void ActivarDesactivarCuadroTextos(bool activar)
        {
            if (activar)
            {
                txtGradoAlumno.Enabled = true;
                txtGrupoAlumno.Enabled = true;
                txtEstatus.Enabled = true;

                btnProgrmaEducativo.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                txtGradoAlumno.Enabled = false;
                txtGrupoAlumno.Enabled = false;
                txtEstatus.Enabled = false;

                btnProgrmaEducativo.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void CargarCuadroTextos(int id)
        {
            //alumnoServicio = servicioEscolar.VistaAlumnoServicioPorId(id);
            EntidadVistaAlumnoServicio entidadalumno= servicioEscolar.VistaAlumnoServicioPorId(id);

            txtGradoAlumno.Text = entidadalumno.Grado;
            txtGrupoAlumno.Text = entidadalumno.Grupo;

            txtNombreAlumno.Text = entidadalumno.Nombre;
            txtApellidoPaternoAlumno.Text = entidadalumno.ApellidoPaterno;
            txtApellidoMaternoAlumno.Text = entidadalumno.ApellidoMaterno;
            txtPlantel.Text = entidadalumno.NombrePlantel;
            txtNivelEducativo.Text = entidadalumno.NombreNivelEducativo;
            txtEstatus.Text = entidadalumno.Status;
        }

    }
}
