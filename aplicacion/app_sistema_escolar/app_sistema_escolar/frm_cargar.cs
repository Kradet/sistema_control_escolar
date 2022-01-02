using comun.cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frm_cargar : Form
    {
        int valor = 0;
        //Constructor
        public frm_cargar()
        {
            InitializeComponent();
        }
        private void frm_cargar_Load(object sender, EventArgs e)
        {
            
            lblUserName.Text = UserCache.Nombre;
            lblTipoUsuario.Text = UserCache.TipoUsuario;
            this.Opacity = 0;
            timer1.Start();
        }

        //Hacemos que el formulario aparezca
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            valor += 1;

            if (valor== 100)
            {
                timer1.Stop();
                timer2.Start();
            }

        }

        //Hacemos que el formualario desaparezca
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            this.Opacity -= 1;

            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        #region Arrastrar el formulario
        //Importo los dlls necesarios para arrastrar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Hacemos que se pueda minimizar desde la barra de tareas
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }
        //metodo para arrastrar
        private void Arrastrar(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

       
    }
}
