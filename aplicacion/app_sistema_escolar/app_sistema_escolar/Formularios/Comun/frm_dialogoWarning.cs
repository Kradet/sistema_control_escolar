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
    public partial class frm_dialogoWarning : Form
    {
        public frm_dialogoWarning(string mensaje)
        {
            InitializeComponent();

            lblMensaje.Text = mensaje;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        public static void WarningForm(string mensaje)
        {
            frm_dialogoWarning warning = new frm_dialogoWarning(mensaje);
            warning.ShowDialog();
        }
    }
}
