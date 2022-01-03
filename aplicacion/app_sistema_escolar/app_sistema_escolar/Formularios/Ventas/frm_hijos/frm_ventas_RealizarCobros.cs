using app_sistema_escolar.Formularios.Comun;
using comun.Entidades;
using comun.Entidades.ventas;
using dominio.tablas;
using dominio.tablas.ventas;
using System;
using System.Windows.Forms;

namespace app_sistema_escolar.Formularios.Ventas.frm_hijos
{
    public partial class frm_ventas_RealizarCobros : Form
    {
        //CAMPOS
        DominioVentas dominioVentas = new DominioVentas();
        DominioAlumno dominioAlumno = new DominioAlumno();

        EntidadAlumno entidadAlumno = new EntidadAlumno();

        //CONSTRUCTOR
        public frm_ventas_RealizarCobros()
        {
            InitializeComponent();
        }

        //CARGAR   
        private void frm_ventas_RealizarCobros_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        public void CargarTabla()
        {
            //En el dgv se lista la tabla cobros_mensuales
            dvgHistorialPago.DataSource = dominioVentas.ListarCobrosMensuales();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                frm_dialogoError.ErrorForm("Ingrese una matricula o CURP validos 😡");
            }
            else
            {
                int id = 0;
                int.TryParse(txtBuscar.Text, out id);
                entidadAlumno.IdAlumno = id;
                entidadAlumno.Curp = txtBuscar.Text;

                entidadAlumno = dominioAlumno.EncontrarAlumnoIdCurp(entidadAlumno);

                txtNombreCompleto.Text = entidadAlumno.ApellidoPaterno + " " + entidadAlumno.ApellidoMaterno + " " + entidadAlumno.Nombre;

                //Actualizamos el dgv con la información
                dvgHistorialPago.DataSource = dominioVentas.ObstenerVistaCobrosPorId(entidadAlumno.IdAlumno);
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
           
            float flotante;
            EntidadCobrosCaja cobrosCaja = new EntidadCobrosCaja();

            if (!float.TryParse(txtDescuentos.Text, out flotante))
            {
                frm_dialogoError.ErrorForm("Ingrese un descuento valido");
                return;
            }
            else
                cobrosCaja.Descuentos = flotante;

            if (!float.TryParse(txtRecargos.Text, out flotante))
            {
                frm_dialogoError.ErrorForm("Ingrese un recargo valido");
                return;
            }
            else
                cobrosCaja.Recargos = flotante;

            cobrosCaja.MetodoPago = txtMetodoPago.Text;
            cobrosCaja.Total = float.Parse(txtTotal.Text);

            dominioVentas.InsertarCobrosCaja(cobrosCaja);
        }

        private void txtRecargos_TextChanged(object sender, EventArgs e)
        {
            float flotante = 0;
            float recargo;
            float descuento;

            if (float.TryParse(txtDescuentos.Text, out descuento))
                if (float.TryParse(txtRecargos.Text, out recargo))
                    flotante = recargo - descuento;

            txtTotal.Text = flotante.ToString();
        }

        private float CalcularTotalAPagar(float recargos, float descuentos)
        {
            return recargos - descuentos;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
