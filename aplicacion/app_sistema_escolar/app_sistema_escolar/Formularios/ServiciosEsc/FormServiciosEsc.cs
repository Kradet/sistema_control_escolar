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
using comun.cache;

namespace app_sistema_escolar.Formularios.ServiciosEsc
{
    public partial class FormServiciosEsc : Form
    {
        // Campos
        private Form childFormActual;
        private bool cerrarsesion;

        public FormServiciosEsc()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormServiciosEsc_Load(object sender, EventArgs e)
        {
            lblNombre.Text = UserCache.Nombre;
            lblUserName.Text = UserCache.UserName;
            lblTipoUsuario.Text = UserCache.TipoUsuario;
            this.WindowState = FormWindowState.Maximized;
        }

        //Metodo para abrir formularios hijos dentro del panel contenedor
        private void AbrirChildForm(Form childForm)
        {
            if (childFormActual != null)
                childFormActual.Close(); //Esto es para abrir solamente un form

            childFormActual = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new VerAlumno());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarsesion = true;
            Close();
        }

        private void FormServiciosEsc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrarsesion)
                Application.Exit();
        }
    }
}
