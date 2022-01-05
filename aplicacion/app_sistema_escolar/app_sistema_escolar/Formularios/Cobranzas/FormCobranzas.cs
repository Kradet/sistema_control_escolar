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
            if (UserCache.Imagen != null)
            {
                imgUsuario.Image = UserCache.Imagen;
            }
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

        private void btnCrearMensualidades_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new frm_cobranzas_CrearMensualidades());
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

                app_sistema_escolar.Formularios.Comun.frm_dialogoDone.ConfirmacionForm("Imagen de usuario guardada correctamente 😎🔥✨");

            }
        }
    }
}
