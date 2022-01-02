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
    public partial class frm_dialogoError : Form
    {
        public frm_dialogoError(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        public static void ErrorForm(string mensaje)
        {
            frm_dialogoError form = new frm_dialogoError(mensaje);
            form.ShowDialog();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
