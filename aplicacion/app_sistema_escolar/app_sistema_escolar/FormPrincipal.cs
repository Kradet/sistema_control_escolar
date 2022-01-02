using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using comun.cache;

namespace presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region metodos para abrir formularios en el panel contenedor

        //Metodo para abrir formularios dentro del panel ; Metodo generico
        private void AbrirFormulario<MiForm>() where MiForm:Form, new() //Donde MiForm herede de Form y tenga un constructor vacio
        {
            Form formulario;
            formulario = panelFormulario.Controls.OfType<MiForm>().FirstOrDefault(); //Busca los formularios en la coleccion

            //Si el formulario o instancia no existe
            if(formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelFormulario.Controls.Add(formulario);
                panelFormulario.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();

                //Le quitamos el borde al formulario y ponemos el dock a fill para acoplarlo al panel
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
            }
            else //Si el formulario o instancia ya existe (es decir ya esta abierto)
            {
                formulario.BringToFront(); //Con esto nos evitamos abrir una nueva instancia del formulario y evitamos sobrecargar la memoria ram
            }
        }

        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form1>();
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            lblNombre.Text = UserCache.Nombre;
            lblUserName.Text = UserCache.UserName;
            lblTipoUsuario.Text = UserCache.TipoUsuario;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
