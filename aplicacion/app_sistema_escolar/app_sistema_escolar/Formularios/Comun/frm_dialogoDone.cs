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
    public partial class frm_dialogoDone : Form
    {
        public frm_dialogoDone(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        public static void ConfirmacionForm(string mensaje)
        {
            frm_dialogoDone done = new frm_dialogoDone(mensaje);
            done.ShowDialog();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
