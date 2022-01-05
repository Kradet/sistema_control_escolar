using app_sistema_escolar.Formularios.Comun;
using comun.cache;
using comun.Entidades.cobranzas;
using dominio.tablas.cobranzas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace app_sistema_escolar.Formularios.Cobranzas
{
    public partial class frm_cobranzas_CrearMensualidades : Form
    {
        //Constructor
        public frm_cobranzas_CrearMensualidades()
        {
            InitializeComponent();
        }

        //Carga
        private void frm_cobranzas_CrearMensualidades_Load(object sender, EventArgs e)
        {
            //Verificamos que haya un alumno cargado en caché
            if (AlumnoSeleccionadoCache.AlumnoSelecionado == null)
            {
                frm_dialogoError.ErrorForm("Debe selecionar un alumno primero");
                btnCrearMensualidad.Enabled = false;
            }
            else
            {
                //Cagamos los txt
                btnCrearMensualidad.Enabled = true;
                txtNombreAlumno.Text = $"{AlumnoSeleccionadoCache.AlumnoSelecionado.ApellidoPaterno} {AlumnoSeleccionadoCache.AlumnoSelecionado.ApellidoMaterno} {AlumnoSeleccionadoCache.AlumnoSelecionado.Nombre}";
                txtMatriculaAlumno.Text = AlumnoSeleccionadoCache.AlumnoSelecionado.IdAlumno.ToString();

                EntidadMensualidad entidadVistaCrearMensualidad = new DominioCobranza().ListarMensualidad(AlumnoSeleccionadoCache.AlumnoSelecionado)[0];

                txtConcepto.Text = entidadVistaCrearMensualidad.Concepto;
                txtPrecio.Text = entidadVistaCrearMensualidad.Precio.ToString();

                CargarComboBox();
            }


            //Cargamos el dgv
            if (AlumnoSeleccionadoCache.AlumnoSelecionado == null)
                return;
            else
                dgvMensualidades.DataSource = new DominioCobranza().ListarVistaMensualidades(AlumnoSeleccionadoCache.AlumnoSelecionado.IdAlumno);
        }

        private void CargarComboBox()
        {
            var datasource = new List<MesesAnio>();

            string[] meses = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            string anio = DateTime.Today.ToString("yyyy");
            foreach (var mes in meses)
                datasource.Add(new MesesAnio { Mes = mes, Anio = anio });

            cmbMesPago.DataSource = datasource;
            cmbMesPago.DisplayMember = "Unidos";
            cmbMesPago.ValueMember = "Unidos";
        }

        private void btnCrearMensualidad_Click(object sender, EventArgs e)
        {
            EntidadMensualidad entidadVistaCrearMensualidad = new DominioCobranza().ListarMensualidad(AlumnoSeleccionadoCache.AlumnoSelecionado)[0];
            EntidadCobrosMensuales entidadCobrosMensuales = new EntidadCobrosMensuales();
            entidadCobrosMensuales.IdCobrosAlumno = entidadVistaCrearMensualidad.IdCobrosAlumno;
            entidadCobrosMensuales.MesPago = cmbMesPago.SelectedValue.ToString();
            entidadCobrosMensuales.Estatus = txtEstatus.Text;

            new DominioCobranza().InsertarCobroMensual(entidadCobrosMensuales);

            frm_dialogoDone.ConfirmacionForm("Mensualidad añadida correctamente 🥰");
        }
    }

    public class MesesAnio
    {
        public string Mes { get; set; }
        public string Anio { get; set; }

        public string Unidos { get { return Mes + "/" + Anio; } }
    }
}
