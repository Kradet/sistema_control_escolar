using comun.Entidades;
using dominio.tablas;
using System;
using System.Drawing;
using System.Windows.Forms;
using app_sistema_escolar.Formularios.Comun;

namespace app_sistema_escolar.Formularios.Admin
{
    public partial class frm_adminUsuarios : Form
    {
        //campos
        private bool editar = false;
        DominioUsuario UsuarioDominio = new DominioUsuario();
        DominioTipoUsuario tipoUsuarioDominio = new DominioTipoUsuario();
        EntidadUsuarios entidadUsuario = new EntidadUsuarios();
        int id_seleccionado;

        public frm_adminUsuarios()
        {
            InitializeComponent();
        }

        private void frm_adminUsuarios_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabla("");
            ListarTipoUsuarios();

            dgvUsuarios.ClearSelection();
        }

        #region DataGridView y ComboBox
        //Listamos o cargamos las tablas
        private void MostrarBuscarTabla(string buscar)
        {
            dgvUsuarios.DataSource = UsuarioDominio.ListarUsuarios(buscar);
        }

        //Cargamos el combobox
        public void ListarTipoUsuarios()
        {
            cmbTipoUsuario.DataSource = tipoUsuarioDominio.ListarTipoUsuarios();
            cmbTipoUsuario.DisplayMember = "tipo_usuario";
            cmbTipoUsuario.ValueMember = "id_tipo_usuario";
        }
        #endregion

        #region Barra de busqueda y campos de datos

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(txtBuscar.Text);
        }

        private void LimpiarTextos()
        {
            txtBuscar.Text = "";
            txtUsername.Text = "";
            txtNombre.Text = "";
            txtContrasenia.Text = "";
            txtConfirmarContrasenia.Text = "";

            editar = false;

            txtConfirmarContrasenia.Enabled = false;
            txtContrasenia.Enabled = false;
            btnGuardar.Enabled = false;
        }

        #endregion

        #region Botones CRUD

        //Nuevo usuario
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarTextos();
            txtContrasenia.Enabled = true;
            txtConfirmarContrasenia.Enabled = true;
            btnGuardar.Enabled = true;
            cmbTipoUsuario.Focus();
        }


        //Editar usuario
        private void btnEditarusuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                editar = true;
                id_seleccionado = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                txtUsername.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();

                txtContrasenia.Text = "";
                txtConfirmarContrasenia.Text = "";
                txtContrasenia.Enabled = false;
                txtConfirmarContrasenia.Enabled = false;

                btnGuardar.Enabled = true;
            }
            else
            {
                frm_dialogoWarning.WarningForm("Por favor seleccione una fila para editar");
            }
        }


        //Eliminar usuario
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if(dgvUsuarios.SelectedRows.Count > 0)
            {
                entidadUsuario.Id_usuario = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                UsuarioDominio.EliminarUsuario(entidadUsuario);

                frm_dialogoDone.ConfirmacionForm("Se ha eliminado el registro correctamente");

                MostrarBuscarTabla("");
                LimpiarTextos();
            }
            else
            {
                frm_dialogoWarning.WarningForm("Seleccione un usuario para eliminar");
            }
        }

        //Guardar usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!editar) //Si se desea añadir un nuevo registro
            {
                try
                {
                    if (txtContrasenia.Text == txtConfirmarContrasenia.Text)
                    {
                        if (txtNombre.Text != "" && txtNombre.Text.Length > 5)
                        {
                            if (txtUsername.Text != null && txtUsername.Text.Length > 5)
                            {
                                entidadUsuario.Id_tipo_usuario = int.Parse(cmbTipoUsuario.SelectedValue.ToString());
                                entidadUsuario.Username = txtUsername.Text;
                                entidadUsuario.Nombre = txtNombre.Text;
                                entidadUsuario.Contrasenia = txtContrasenia.Text;

                                if (UsuarioDominio.InsertarUsuario(entidadUsuario))
                                    frm_dialogoDone.ConfirmacionForm("Usuario agregado correctamente");
                                else
                                    frm_dialogoError.ErrorForm("Ha ocurrido un error, por favor intentelo nuevamente");

                                MostrarBuscarTabla("");
                                LimpiarTextos();
                            }
                            else
                            {
                                frm_dialogoError.ErrorForm("Ingrese un username valido");
                                MostrarBuscarTabla("");
                                LimpiarTextos();
                            }
                        }
                        else
                        {
                            frm_dialogoError.ErrorForm("Ingrese un nombre valido");
                            MostrarBuscarTabla("");
                            LimpiarTextos();
                        }
                    }
                    else
                    {
                        frm_dialogoError.ErrorForm("Las contraseñas con coinciden, intentelo nuevamente");
                        MostrarBuscarTabla("");
                        LimpiarTextos();
                    }
                }
                catch (Exception exception)
                {
                    frm_dialogoError.ErrorForm("Ha ocurrido un error:  "+exception.Message);
                    MostrarBuscarTabla("");
                    LimpiarTextos();
                    throw;
                }
            }
            if (editar) //si se desea editar un registro
            {
                try
                {
                    if (txtNombre.Text != "" && txtNombre.Text.Length > 5)
                    {
                        if (txtUsername.Text != null && txtUsername.Text.Length > 5)
                        {
                            entidadUsuario.Id_usuario = id_seleccionado;
                            entidadUsuario.Id_tipo_usuario = int.Parse(cmbTipoUsuario.SelectedValue.ToString());
                            entidadUsuario.Username = txtUsername.Text;
                            entidadUsuario.Nombre = txtNombre.Text;

                            if (UsuarioDominio.EditarUsuario(entidadUsuario))
                                frm_dialogoDone.ConfirmacionForm("Registro editado correctamente");
                            else
                                frm_dialogoError.ErrorForm("No se pudo editar el registro :(");

                            LimpiarTextos();
                            MostrarBuscarTabla("");

                            editar = false;
                        }
                        else
                        {
                            frm_dialogoError.ErrorForm("Ingrese un username valido");
                            MostrarBuscarTabla("");
                            LimpiarTextos();
                        }
                    }
                    else
                    {
                        frm_dialogoError.ErrorForm("Ingrese un nombre valido");
                        MostrarBuscarTabla("");
                        LimpiarTextos();
                    }
                }
                catch (Exception exception)
                {
                    frm_dialogoError.ErrorForm("Ha ocurrido un error: " + exception.Message);
                    MostrarBuscarTabla("");
                    LimpiarTextos();
                    throw;
                }
            }
        }
        #endregion

    }
}
