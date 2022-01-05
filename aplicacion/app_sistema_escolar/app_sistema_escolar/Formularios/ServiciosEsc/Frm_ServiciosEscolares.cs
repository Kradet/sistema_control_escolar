using comun.cache;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_sistema_escolar.Formularios.ServiciosEsc
{
    public partial class Frm_ServiciosEscolares : Form
    {
        //campos
        private GunaButton currentButton;
        private Form currentChildForm;

        //constructor
        public Frm_ServiciosEscolares()
        {
            InitializeComponent();
        }

        private void Frm_ServiciosEscolares_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserCache.Nombre;
            if (UserCache.Imagen != null)
            {
                imgUsuario.Image = UserCache.Imagen;
            }
        }

        #region activar botones y abrir formularios hijos
        //Activar y desactivar botones
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
        #endregion

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_hijos.frm_serviciosEscolares_verAlumnos());
        }

        private void btnAñadirAlumnos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_hijos.frm_serviciosEscolares_AgregarAlumno());
        }

        private void btnVinculación_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_hijos.frm_serviciosEscolares_vinculacion());
        }

        private void btnElegirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Imagenes (jpg, png) | *jpg; *.png";
            openFile.Title = "Seleccionar imagen de usuario 😘";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                UserCache.Imagen = Image.FromFile(openFile.FileName);
                imgUsuario.Image = Image.FromFile(openFile.FileName);

                MemoryStream ms = new MemoryStream();
                UserCache.Imagen.Save(ms, ImageFormat.Png);
                Byte[] byteArray = ms.ToArray();

                new dominio.tablas.DominioUsuario().InsertarImagenDeUsuario(byteArray, UserCache.IdUsuario);

                Comun.frm_dialogoDone.ConfirmacionForm("Imagen de usuario guardada correctamente 😎🔥✨");
            }
        }
    }
}
