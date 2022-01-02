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
    public partial class FormSucces : Form
    {
        public FormSucces(string titulo, string mensaje)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
        }

        private void FormSucces_Load(object sender, EventArgs e)
        {
        }

        public static void ConfirmacionForm(string titulo, string mensaje)
        {
            FormSucces form = new FormSucces(titulo, mensaje);
            form.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
