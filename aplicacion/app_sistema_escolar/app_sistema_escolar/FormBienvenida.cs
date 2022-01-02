using System;
using System.Windows.Forms;
using comun.cache;

namespace presentacion
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        //Hacemos que el formulario aparezca
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) 
                this.Opacity += 0.05;

            bunifuCircleProgressbar1.Value += 1;

            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        //Hacemos que el formualario desaparezca
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;

            if (this.Opacity ==0 )
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value = 0;
            lblUserName.Text = UserCache.Nombre;
            lblTipoUsuario.Text = UserCache.TipoUsuario;
            this.Opacity = 0;
            timer1.Start();
        }
    }
}
