using comun.Entidades;
using comun.Entidades.ventas;
using dominio.tablas;
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

namespace app_sistema_escolar.Formularios.Ventas.frm_hijos
{
    public partial class frm_ventas_AperturarCajas : Form
    {
        //Campos
        DominioUsuario dominioUsuario = new DominioUsuario();
        DominioVentas dominioVentas = new DominioVentas();

        EntidadUsuarios entidadUsuarios = new EntidadUsuarios();
        EntidadSesionCaja entidadSesionCaja = new EntidadSesionCaja();

        public frm_ventas_AperturarCajas(string label, string boton)
        {
            InitializeComponent();
            lblAbrirCerrarCaja.Text = label;
            btnAperturarCerrarCaja.Text = boton;
        }

        //Cargar
        private void frm_ventas_AperturarCajas_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvVistaSesionCaja.DataSource = dominioVentas.ListarCajas();
        }

        private void btnAperturarCerrarCaja_Click(object sender, EventArgs e)
        {
            if(btnAperturarCerrarCaja.Text == "Abrir Caja")
            {
                //Abrimos la caja
                entidadSesionCaja.Estatus = "Abierta";
                entidadSesionCaja.HoraApertura = DateTime.Now.ToString("HH:mm:ss");
                entidadSesionCaja.IdCaja = int.Parse(dgvVistaSesionCaja.CurrentRow.Cells[0].Value.ToString());

                dominioVentas.AbrirCerrarSesionCaja(entidadSesionCaja);

                frm_dialogoDone.ConfirmacionForm("Caja abierta correctamente ♥");
            }
            else
            {
                //Cerramos la caja
                entidadSesionCaja.Estatus = "Cerrada";
                entidadSesionCaja.HoraCierre = DateTime.Now.ToString("HH:mm:ss");
                entidadSesionCaja.IdCaja = int.Parse(dgvVistaSesionCaja.CurrentRow.Cells[0].Value.ToString());

                dominioVentas.AbrirCerrarSesionCaja(entidadSesionCaja);

                frm_dialogoDone.ConfirmacionForm("Caja cerrada correctamente 😎");
            }

            CargarTabla();
        }

        //Cuando se hace click en una celda se actualizan los datos
        private void dgvVistaSesionCaja_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvVistaSesionCaja.SelectedRows.Count > 0)
            {
                entidadSesionCaja = dominioVentas.ObtenerSesionCajaPorIdCaja(int.Parse(dgvVistaSesionCaja.CurrentRow.Cells[0].Value.ToString()));
                entidadUsuarios = dominioUsuario.ObtenerUsuarioPorId(entidadSesionCaja.IdUsuario);

                txtUsuario.Text = entidadUsuarios.Nombre;
                txtCantidadInicial.Text = entidadSesionCaja.CantidadInicial.ToString();
                
            }
        }
    }
}
