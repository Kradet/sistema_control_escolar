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
        //Logica
        DominioVentas dominioVentas = new DominioVentas();
        DominioAlumno dominioAlumno = new DominioAlumno();

        //Entidades
        EntidadAlumno entidadAlumno = new EntidadAlumno();

        //Variables
        bool puedeIngresarTotal;
        bool recargoCorrecto;
        bool descuentoCorrecto;
        
        float totalPagar;
        float recargo;
        float descuento;
        float total;

        //CONSTRUCTOR
        public frm_ventas_RealizarCobros()
        {
            InitializeComponent();
        }

        //CARGAR   
        private void frm_ventas_RealizarCobros_Load(object sender, EventArgs e)
        {
            CargarTabla();

            puedeIngresarTotal = false;
            recargoCorrecto = false;
            descuentoCorrecto = false;
            txtTotal.Text = "0";
            txtRecargos.Text = "0";
            txtDescuentos.Text = "0";
            txtMetodoPago.Text = "Efectivo";

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
                puedeIngresarTotal = true;

                int id = 0;
                int.TryParse(txtBuscar.Text, out id);
                entidadAlumno.IdAlumno = id;
                entidadAlumno.Curp = txtBuscar.Text;

                entidadAlumno = dominioAlumno.EncontrarAlumnoIdCurp(entidadAlumno);

                txtNombreCompleto.Text = entidadAlumno.ApellidoPaterno + " " + entidadAlumno.ApellidoMaterno + " " + entidadAlumno.Nombre;

                //Actualizamos el dgv con la información
                dvgHistorialPago.DataSource = dominioVentas.ObstenerVistaCobrosPorId(entidadAlumno.IdAlumno);


                puedeIngresarTotal = true;
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            EntidadCobrosCaja cobrosCaja = new EntidadCobrosCaja();

            if (!descuentoCorrecto)
            {
                frm_dialogoError.ErrorForm("Ingrese un descuento valido");
                return;
            }
            
            if (!recargoCorrecto)
            {
                frm_dialogoError.ErrorForm("Ingrese un recargo valido");
                return;
            }

            if (descuentoCorrecto && recargoCorrecto)
            {
                cobrosCaja.Recargos = float.Parse(txtRecargos.Text);
                cobrosCaja.Descuentos= float.Parse(txtRecargos.Text);
                cobrosCaja.Total = float.Parse(txtTotal.Text);
                cobrosCaja.MetodoPago = txtMetodoPago.Text;
                
                dominioVentas.InsertarCobrosCaja(cobrosCaja);
                frm_dialogoDone.ConfirmacionForm("Pagado correctamente 🥰♥");
            }

        }

        private void txtRecargos_TextChanged(object sender, EventArgs e)
        {
            if (puedeIngresarTotal)
            {
                //txtTotal.Text = dvgHistorialPago.CurrentRow.Cells[2].Value.ToString();
                if (float.TryParse(txtRecargos.Text, out recargo))
                {
                    recargo = 0;
                    recargo = float.Parse(txtRecargos.Text);
                    recargoCorrecto = true;
                }

                if (float.TryParse(txtDescuentos.Text, out descuento))
                {
                    descuento = 0;
                    descuento = float.Parse(txtDescuentos.Text);
                    descuentoCorrecto = true;
                }

                if(descuentoCorrecto && recargoCorrecto)
                {
                    totalPagar = total + recargo - descuento;
                    txtTotal.Text = totalPagar.ToString();
                }
            }
        }

        private void dvgHistorialPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (puedeIngresarTotal)
            {
                txtTotal.Text = dvgHistorialPago.CurrentRow.Cells[2].Value.ToString();
                total = float.Parse(txtTotal.Text);

                txtRecargos_TextChanged(sender,e);
            }
        }

    }
}
