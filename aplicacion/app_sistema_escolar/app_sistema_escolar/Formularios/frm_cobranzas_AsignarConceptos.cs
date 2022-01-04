using app_sistema_escolar.Formularios.Comun;
using comun.cache;
using System;
using System.Windows.Forms;
using comun.Entidades.servicio_escolar;
using comun.Entidades.cobranzas;
using dominio.tablas.servicio_escolar;
using dominio.tablas.cobranzas;

namespace app_sistema_escolar.Formularios.Cobranzas.frm_hijos
{
    public partial class frm_cobranzas_AsignarConceptos : Form
    {
        //Campos
        EntidadServicioEscolar servicioEscolar = new EntidadServicioEscolar();
        EntidadCobrosAlumno entidadCobrosAlumno = new EntidadCobrosAlumno();

        DominioServicioEscolar dominioServicioEscolar = new DominioServicioEscolar();
        DominioConceptoCobranzas dominioConceptoCobranzas = new DominioConceptoCobranzas();
        DominoCobrosAlumno dominoCobrosAlumno = new DominoCobrosAlumno();

        //Constructor
        public frm_cobranzas_AsignarConceptos()
        {
            InitializeComponent();
        }

        //Carga
        private void frm_cobranzas_AsignarConceptos_Load(object sender, EventArgs e)
        {
            CargarTabla();

            if (AlumnoSeleccionadoCache.AlumnoSelecionado == null)
            {
                frm_dialogoError.ErrorForm("Debe selecionar un alumno primero");
                btnAsignar.Enabled = false;
            }
            else
            {
                btnAsignar.Enabled = true;

                txtMatricula.Text = AlumnoSeleccionadoCache.AlumnoSelecionado.IdAlumno.ToString();
                txtNombre.Text = "" +
                    AlumnoSeleccionadoCache.AlumnoSelecionado.Nombre + " " +
                    AlumnoSeleccionadoCache.AlumnoSelecionado.ApellidoPaterno + " " +
                    AlumnoSeleccionadoCache.AlumnoSelecionado.ApellidoMaterno;

                servicioEscolar = dominioServicioEscolar.ObtenerServicioEscolarIdAlumno(AlumnoSeleccionadoCache.AlumnoSelecionado);

                txtEstatus.Text = servicioEscolar.Status;
            }


        }

        private void CargarTabla()
        {
            dgvConceptosDisponibles.DataSource = dominioConceptoCobranzas.ListarConceptoConbranzas();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if(dgvConceptosDisponibles.SelectedRows.Count > 0)
            {
                if(txtCicloEscolar.Text == "")
                {
                    frm_dialogoError.ErrorForm("Ingrese un ciclo escolar válido 😓");
                }
                else
                {
                    servicioEscolar= dominioServicioEscolar.ObtenerServicioEscolarIdAlumno(AlumnoSeleccionadoCache.AlumnoSelecionado);
                    entidadCobrosAlumno.IdServicioEscolar = servicioEscolar.IdServicioEscolar;

                    entidadCobrosAlumno.IdConceptoCobranza = int.Parse(dgvConceptosDisponibles.CurrentRow.Cells[0].Value.ToString());
                    entidadCobrosAlumno.CicloEscolar = txtCicloEscolar.Text;

                    dominoCobrosAlumno.InsertarCobrosAlumno(entidadCobrosAlumno);

                    frm_dialogoDone.ConfirmacionForm("Concepto asignado correctamente ♥✨");
                    CargarTabla();
                }
            }
            else
            {
                frm_dialogoError.ErrorForm("Selecione un concepto 😾");
            }
        }

    }
}
