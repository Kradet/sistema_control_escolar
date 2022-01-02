using comun.cache;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using app_sistema_escolar.Formularios.Comun;

namespace app_sistema_escolar.Formularios.Admin
{
    public partial class FormAdmin : Form
    {
        //Campos
        private IconButton botonActual;
        private Panel bordeIzquierdoBoton;
        private Form childFormActual;
        private bool cerrarsesion;

        public FormAdmin()
        {
            InitializeComponent();

            //Añadimos las propiedades del borde izquierdo de los botones
            bordeIzquierdoBoton = new Panel();
            bordeIzquierdoBoton.Size = new Size(7, 60);
            panelMenu.Controls.Add(bordeIzquierdoBoton);
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {
            CargarDatos();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CargarDatos()
        {
            lblNombre.Text = UserCache.Nombre;
            lblTipoUsuario.Text = UserCache.TipoUsuario;
            lblUserName.Text = UserCache.UserName;
        }

        // Personalizamos el activado del boton
        private void ActivarBoton(object btnSender) //Resaltado del boton
        {
            if (btnSender != null)
            {
                DesactivarBoton(); //Desactivamos el boton anterior

                //Boton
                botonActual = (IconButton)btnSender;
                botonActual.BackColor = Color.FromArgb(37, 36, 81);
                botonActual.ForeColor = Color.FromArgb(24, 161, 251);
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = Color.FromArgb(24, 161, 251);
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;

                //Borde izquierdo boton
                bordeIzquierdoBoton.BackColor = Color.FromArgb(24, 161, 251);
                bordeIzquierdoBoton.Location = new Point(0, botonActual.Location.Y);
                bordeIzquierdoBoton.Visible = true;
                bordeIzquierdoBoton.BringToFront();
            }
        }

        private void DesactivarBoton() //Se desactiva el resaltado del boton
        {
            if (botonActual != null) //Regresamos a la configuracion por defecto
            {
                botonActual.BackColor = Color.FromArgb(31, 30, 68);
                botonActual.ForeColor = Color.Gainsboro;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.Gainsboro;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Metodo para abir forms hijos en el panel contenedor
        private void AbrirChildForm(Form childForm)
        {
            if (childFormActual != null)
                childFormActual.Close(); //Abrimos solamente un form

            childFormActual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirChildForm(new VerUsuario());
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            //AbrirChildForm(new AgregarUsuario());
        }

        private void btnAgregarPermisos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarsesion = true;
            this.Close(); //Llama a FormAdmin_FormClosing
            //Application.Exit();  //Sale directamente de la aplicacion


            //if (MessageBox.Show("¿Desea cerrar sesion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //Application.Exit();

        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrarsesion)
                Application.Exit();

            //if (new FormInformation("Advertencia", "¿Desea salir del programa?").ShowDialog() == DialogResult.OK)
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}

        }
    }
}
