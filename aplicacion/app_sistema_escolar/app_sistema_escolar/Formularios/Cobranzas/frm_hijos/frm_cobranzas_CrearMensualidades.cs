using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using comun.Entidades.ventas;
using comun.Entidades.alumnos;
using dominio.tablas.ventas;
using dominio.tablas;
using comun.Entidades;
using dominio.tablas.cobranzas;
using comun.Entidades.cobranzas;

namespace app_sistema_escolar.Formularios.Cobranzas
{
    public partial class frm_cobranzas_CrearMensualidades : Form
    {
        public frm_cobranzas_CrearMensualidades()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frm_cobranzas_CrearMensualidades_Load(object sender, EventArgs e)
        {

        }

        private void cmbMesPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            DominioAlumno dominioAlumno = new DominioAlumno();
            EntidadAlumno entidadAlumno = new EntidadAlumno();
            int.TryParse(txtNombreAlumno.Text, out id);
            
            entidadAlumno.IdAlumno = id;
            entidadAlumno.Curp = txtNombreAlumno.Text;
            entidadAlumno = dominioAlumno.EncontrarAlumnoIdCurp(entidadAlumno);

            DominioCobranza dominioCobranza = new DominioCobranza();

            dgvMensualidades.DataSource = dominioCobranza.ListarVistaCrearMensualidad(entidadAlumno);

        }
    }
}
