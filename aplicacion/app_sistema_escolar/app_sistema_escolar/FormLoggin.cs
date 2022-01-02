using comun.cache;
using dominio;
using System;
using System.Drawing;
using System.Windows.Forms;
using app_sistema_escolar.Formularios;
using app_sistema_escolar.Formularios.Admin;
using app_sistema_escolar.Formularios.Alumno;
using app_sistema_escolar.Formularios.ServiciosEsc;
using app_sistema_escolar.Formularios.Ventas;


namespace presentacion
{
    public partial class FormLoggin : Form
    {
        public FormLoggin()
        {
            InitializeComponent();
        }

        #region Visuales de labels de usuario y contraseña

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";

                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        #endregion

        #region Botones de cerrar, y minimizar

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLoggin_Load(object sender, EventArgs e)
        {

        }

        #endregion


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    DominioLoggin usuario = new DominioLoggin();
                    var LogginValido = usuario.LogginUser(txtUser.Text, txtPass.Text);

                    if (LogginValido)
                    {
                        usuario.CargarTipoUsuario();
                        // MessageBox.Show($"Bienvenido {UserCache.Nombre}");

                        this.Hide();
                        FormBienvenida bienvenida = new FormBienvenida();
                        bienvenida.ShowDialog(); //Lo mostramos como cuadro de dialogo para que se haga una "pausa" mientras está abierto

                        //Segun el tipo de usuario abrimos un formulario
                        switch (UserCache.IdTipoUsuario-1) //Es -1 por que en la base de datos empieza por 1, y en enum en 0
                        {
                            case (int)Posiciones.administrador:
                                FormAdmin formAdmin = new FormAdmin();
                                formAdmin.Show();
                                formAdmin.FormClosed += Logout;
                                break;

                            case (int)Posiciones.cobranza:
                                FormPrincipal formPrincipal = new FormPrincipal();
                                formPrincipal.Show();
                                formPrincipal.FormClosed += Logout;
                                break;

                            case (int)Posiciones.cajero:
                                FormPrincipal formPrincipal2 = new FormPrincipal();
                                formPrincipal2.Show();
                                formPrincipal2.FormClosed += Logout;
                                break;

                            case (int)Posiciones.servicios_escolares:
                                FormServiciosEsc formServicios = new FormServiciosEsc();
                                formServicios.Show();
                                formServicios.FormClosed += Logout;
                                break;

                            case (int)Posiciones.alumno:
                                FormPrincipal formPrincipal222 = new FormPrincipal();
                                formPrincipal222.Show();
                                formPrincipal222.FormClosed += Logout;
                                break;
                            default:
                                MessageBox.Show("Ha ocurrido un error, contacte a servicio tecnico");
                                Application.Exit();
                                break;
                        }

                        //FormPrincipal menuPrincipal = new FormPrincipal();
                        //menuPrincipal.Show();
                        //menuPrincipal.FormClosed += Logout;
                    }
                    else
                        MensajeError("  USUARIO O CONTRASEÑA INCORRECTOS.\nPOR FAVOR INTENTELO DE NUEVO.");
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
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            txtUser.Text = "USUARIO";
            lblEror.Visible = false;
            this.Show();
        }

        //En caso de que alguien quiera ingresar al sistema modificando el código.
        //Indicamos que el código se ejecute siempre en cuando que un usuario haya iniciado sesión
        private void Seguridad()
        {
            var usuarioModelo = new DominioLoggin();
            if (usuarioModelo.LogginSeguro() == false)
            {
                MessageBox.Show("Error fatal, se detecto que esta intentando acceder al sistema sin credenciales, por favor inicie sesión e identifiquese");
                Application.Exit();
            }
        }
    }
}
