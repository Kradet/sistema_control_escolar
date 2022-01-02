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
    public partial class FormError : Form
    {
        public FormError(string titulo, string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            lblTitulo.Text = titulo;
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {
        }

        public static void ConfirmacionForm(string titulo, string mensaje)
        {
            FormSucces form = new FormSucces(titulo, mensaje);
            form.ShowDialog();
        }

        private void FormError_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
