using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_sistema_escolar.Formularios.Comun
{
    public partial class frm_imprimir : Form
    {
        public frm_imprimir(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void btnCerra_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        public static void Mostrar(string mensaje)
        {
            frm_imprimir imprimir = new frm_imprimir(mensaje);
            imprimir.ShowDialog();
        }
    }
}
