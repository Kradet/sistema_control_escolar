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
    public partial class FormInformation : Form
    {
        public FormInformation(string titulo, string mensaje)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
        }

        private void FormInformation_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public static void AdvertenciaForm(string mensaje)
        {
            frm_dialogoDone form = new frm_dialogoDone(mensaje);
            form.ShowDialog();
        }
    }
}
