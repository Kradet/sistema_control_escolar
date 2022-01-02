using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_sistema_escolar.Formularios.Cobranzas.frm_hijos;
using comun.cache;
using Guna.UI.WinForms;

namespace app_sistema_escolar.Formularios.Cobranzas
{
    public partial class FormCobranzas : Form
    {
        //! Constructor / Campos
        private Form currentChildForm;
        private GunaButton currentButton;

        public FormCobranzas()
        {
            InitializeComponent();
        }

        //! Carga de formulario
        private void FormCobranzas_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserCache.Nombre;
        }

        //! Metodo para abrir formularios hijos
        private void OpenChildForm(Form formHijo)
        {
            if (currentChildForm != null)
                currentChildForm.Close(); //Abrimos un solo formulario hijo

            currentChildForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        //! metodo para activar y desactivar botones
        private void ActivateButton(object btnSender) //Personalizamos el resaltado del boton
        {
            if (btnSender != null)
            {
                DisableButton();
                currentButton = (GunaButton)btnSender;
                currentButton.BaseColor = Color.FromArgb(214, 234, 248);
            }
        }

        private void DisableButton() //Desactivamos el resaltado del boton
        {
            if (currentButton != null) //regresamos la configuración por defecto
            {
                currentButton.ForeColor = Color.FromArgb(90, 90, 90);
                currentButton.BaseColor = Color.White;
            }
        }

        private void btnInformacionAlumno_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_cobranzas_InformacionAlumno());
        }

        private void btnConceptosCobro_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_cobranzas_CrearConceptos());
        }

        private void btnAsignarConceptos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_cobranzas_AsignarConceptos());
        }
    }
}
