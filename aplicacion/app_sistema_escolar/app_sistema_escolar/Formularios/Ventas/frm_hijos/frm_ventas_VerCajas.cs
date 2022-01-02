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
using comun.Entidades;
using dominio.tablas.ventas;
using dominio.tablas;
using app_sistema_escolar.Formularios.Comun;

namespace app_sistema_escolar.Formularios.Ventas.frm_hijos
{
    public partial class frm_ventas_VerCajas : Form
    {
        //Campos
        DominioUsuario dominioUsuario = new DominioUsuario();
        DominioVentas dominioVentas = new DominioVentas();

        EntidadUsuarios entidadUsuarios = new EntidadUsuarios();
        EntidadSesionCaja entidadSesionCaja = new EntidadSesionCaja();

        //Constructor
        public frm_ventas_VerCajas()
        {
            InitializeComponent();
        }

        //Cargar
        private void frm_ventas_VerCajas_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvVistaSesionCaja.DataSource = dominioVentas.ListarCajas();
        }

        private void btnVerInformacion_Click(object sender, EventArgs e)
        {
            if (dgvVistaSesionCaja.SelectedRows.Count > 0)
            {
                entidadSesionCaja = dominioVentas.ObtenerSesionCajaPorIdCaja(int.Parse(dgvVistaSesionCaja.CurrentRow.Cells[0].Value.ToString()));
                entidadUsuarios= dominioUsuario.ObtenerUsuarioPorId(entidadSesionCaja.IdUsuario);

                txtEstatus.Text = entidadSesionCaja.Estatus;
                txtUsuario.Text = entidadUsuarios.Nombre;
                txtFechaUso.Text = entidadSesionCaja.HoraApertura.ToString();
            }
            else
            {
                frm_dialogoError.ErrorForm("Seleccione una caja primero 😒");
            }
        }
    }
}
