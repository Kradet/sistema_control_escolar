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
using app_sistema_escolar.Formularios;
using app_sistema_escolar.Formularios.Admin;
using app_sistema_escolar.Formularios.Alumno;
using app_sistema_escolar.Formularios.ServiciosEsc;
using app_sistema_escolar.Formularios.Ventas;
using dominio;
using comun.cache;
using app_sistema_escolar.Formularios.Cobranzas;

namespace presentacion
{
    public partial class fmr_loggin : Form
    {
        

        public fmr_loggin()
        {
            InitializeComponent();
        }

        private void fmr_loggin_Load(object sender, EventArgs e)
        {
            txtUsuario.SetOnGotFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region arrastrar
        // Metodo para arrastrar el formulario desde el panel lateral y el panel principal
        //Importo los dlls necesarios para arrastrar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Arrastrar(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion      

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContrasenia.Text != "")
                {
                    DominioLoggin usuario = new DominioLoggin();
                    var LogginValido = usuario.LogginUser(txtUsuario.Text, txtContrasenia.Text);

                    if (LogginValido)
                    {
                        usuario.CargarTipoUsuario();

                        this.Hide();
                        frm_cargar bienvenida = new frm_cargar();
                        bienvenida.ShowDialog(); //Lo mostramos como cuadro de dialogo para que se haga una "pausa" mientras está abierto

                        //Segun el tipo de usuario abrimos un formulario
                        switch (UserCache.IdTipoUsuario - 1) //Es -1 por que en la base de datos empieza por 1, y en enum en 0
                        {
                            case (int)Posiciones.administrador:
                                //FormAdmin formAdmin = new FormAdmin();
                                //formAdmin.Show();
                                //formAdmin.FormClosed += Logout;
                                frm_admin formAdmin = new frm_admin();
                                formAdmin.Show();
                                formAdmin.FormClosed += Logout;
                                break;

                            case (int)Posiciones.cobranza:
                                //FormPrincipal formPrincipal = new FormPrincipal();
                                //formPrincipal.Show();
                                //formPrincipal.FormClosed += Logout;
                                FormCobranzas formCobranzas = new FormCobranzas();
                                formCobranzas.Show();
                                formCobranzas.FormClosed += Logout;
                                break;

                            case (int)Posiciones.cajero:
                                //FormPrincipal formPrincipal2 = new FormPrincipal();
                                //formPrincipal2.Show();
                                //formPrincipal2.FormClosed += Logout;
                                FormVentas formVentas = new FormVentas();
                                formVentas.Show();
                                formVentas.FormClosed += Logout;
                                break;

                            case (int)Posiciones.servicios_escolares:
                                //FormServiciosEsc formServicios = new FormServiciosEsc();
                                //formServicios.Show();
                                //formServicios.FormClosed += Logout;
                                Frm_ServiciosEscolares formServicios = new Frm_ServiciosEscolares();
                                formServicios.Show();
                                formServicios.FormClosed += Logout;
                                break;

                            case (int)Posiciones.alumno:
                                MessageBox.Show("Ingrese un tipo de usuario válido");
                                break;
                            default:
                                MessageBox.Show("Ha ocurrido un error, contacte a servicio tecnico");
                                Application.Exit();
                                break;
                        }
                    }
                    else
                        MensajeError("USUARIO O CONTRASEÑA INCORRECTA\n POR FAVOR INTENTELO DE NUEVO");
                }
                else
                    MensajeError("INGRESE UNA CONTRASEÑA");
            }
            else
                MensajeError("INGRESE UN NOMBRE DE USUARIO");
        }

        private void MensajeError(string mensaje)
        {
            lblEror.Text = "    " + mensaje;
            lblEror.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContrasenia.Text = "";
            txtUsuario.Text = "";
            lblEror.Visible = false;
            this.Show();
        }
    }
}
