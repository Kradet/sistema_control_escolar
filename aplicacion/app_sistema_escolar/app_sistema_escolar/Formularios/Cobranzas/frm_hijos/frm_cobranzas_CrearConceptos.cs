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
using comun.Entidades.cobranzas;
using dominio.tablas.cobranzas;

namespace app_sistema_escolar.Formularios.Cobranzas.frm_hijos
{
    public partial class frm_cobranzas_CrearConceptos : Form
    {
        //Campos
        DominioConceptoCobranzas dominioConceptoCobranzas = new DominioConceptoCobranzas();
        EntidadConceptoCobranzas entidadConceptoCobranzas = new EntidadConceptoCobranzas();

        //Constructor
        public frm_cobranzas_CrearConceptos()
        {
            InitializeComponent();
        }

        //Carga de formulario
        private void frm_cobranzas_CrearConceptos_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        //Cargamos el datagridview
        private void CargarTabla()
        {
            dgvConceptosDisponibles.DataSource = dominioConceptoCobranzas.ListarConceptoConbranzas();
        }

        private void btnCrearConcepto_Click(object sender, EventArgs e)
        {
            //Verificamos que ninguno de los campos este vacío
            if (txtConcepto.Text=="" || txtPrecio.Text=="")
            {
                frm_dialogoError.ErrorForm("No debe de haber capos vacíos");
            }
            else
            {
                entidadConceptoCobranzas.Concepto = txtConcepto.Text;
                float precio;

                if (float.TryParse(txtPrecio.Text, out precio))
                {
                    entidadConceptoCobranzas.Precio = precio;
                    dominioConceptoCobranzas.InsertarConcepto(entidadConceptoCobranzas);

                    frm_dialogoDone.ConfirmacionForm("Concepto agregado correctamente ✨");
                    CargarTabla();
                }
                else
                    frm_dialogoError.ErrorForm("Ingrese un precio valido");
            }
        }
    }
}
