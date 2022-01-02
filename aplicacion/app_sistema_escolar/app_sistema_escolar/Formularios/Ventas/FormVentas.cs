using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using comun.cache;
using Guna.UI.WinForms;
using app_sistema_escolar.Formularios.Ventas.frm_hijos;

namespace app_sistema_escolar.Formularios.Ventas
{
    public partial class FormVentas : Form
    {
        //Campos
        private GunaButton currentButton;
        private Form currentChildForm;

        //Constructor
        public FormVentas()
        {
            InitializeComponent();
        }

        //Carga
        private void FormVentas_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserCache.Nombre;
        }

        //metodo para activar y desactivar botones
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

        //abrir formularios hijos
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close(); //abrimos solamente un form

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnVerCajas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_ventas_VerCajas());
        }

        private void btnAperturarCajas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_ventas_AperturarCajas("Aperturar Cajas", "Abrir Caja"));
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_ventas_AperturarCajas("Cerrar Cajas", "Cerrar Caja"));
        }

        private void btnRealizarCobros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_ventas_RealizarCobros());
        }
    }
}
