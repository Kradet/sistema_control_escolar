using comun.Entidades;
using dominio.tablas;
using System;
using System.Drawing;
using System.Windows.Forms;
using app_sistema_escolar.Formularios.Comun;

namespace app_sistema_escolar.Formularios.Admin
{
    public partial class VerUsuario : Form
    {
        //campos
        private bool editar = false;
        DominioUsuario UsuarioDominio = new DominioUsuario();
        DominioTipoUsuario tipoUsuarioDominio = new DominioTipoUsuario();
        EntidadUsuarios entidadUsuario = new EntidadUsuarios();
        int id_seleccionado;

        public VerUsuario()
        {
            InitializeComponent();
        }

        private void VerUsuario_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabla("");
            ListarTipoUsuarios();

            dgvUsuarios.ClearSelection();
        }

        #region Barra de busqueda y campos de datos

        private void txtBusc_Enter(object sender, EventArgs e)
        {
            txtBusc.Text = "";
        }
        private void txtBusc_MouseClick(object sender, MouseEventArgs e)
        {
            txtBusc.Text = "";
            txtBusc.ForeColor = Color.White;
        }

        private void txtBusc_OnValueChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(txtBusc.Text);
        }

        private void LimpiarTextos()
        {
            txtBusc.Text = "";
            txtUsername.Text = "";
            txtNombre.Text = "";
            txtContrasenia.Text = "";
            txtConfirmarContrasenia.Text = "";
            //txtUsername.Focus();
            editar = false;

            txtConfirmarContrasenia.Enabled = false;
            txtContrasenia.Enabled = false;
            btnGuardar.Enabled = false;
        }

        #endregion
        #region DataGridView y combobox

        //Listamos o cargamos la tabla
        private void MostrarBuscarTabla(string buscar)
        {
            dgvUsuarios.DataSource = UsuarioDominio.ListarUsuarios(buscar);
        }

        //Cargar el combobox
        private void ListarTipoUsuarios()
        {
            cbTipoUsuarios.DataSource = tipoUsuarioDominio.ListarTipoUsuarios();
            cbTipoUsuarios.ValueMember = "id_tipo_usuario";
            cbTipoUsuarios.DisplayMember = "tipo_usuario";
        }

        private void cbTipoUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // MessageBox.Show(cbTipoUsuarios.SelectedValue.ToString()); //Valor de la lista combo box, empieza por 1
        }

        #endregion
        #region Botones CRUD

        //Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarTextos();
            txtContrasenia.Enabled = true;
            txtConfirmarContrasenia.Enabled = true;
            btnGuardar.Enabled = true;
            cbTipoUsuarios.Focus();
        }

        //Editar
        private void btnEditar_Click(object sender, EventArgs e)
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
                FormError.ConfirmacionForm("Error", "Selecciones una fila para editar");
                //MessageBox.Show("Seleccione una fila");
            }
        }

        //Doble click en una fila
        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Doble click");
        }

        //Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!editar) //Si de desea añadir un nuevo registro
            {
                try
                {
                    if (txtConfirmarContrasenia.Text == txtContrasenia.Text)
                    {
                        entidadUsuario.Id_tipo_usuario = int.Parse(cbTipoUsuarios.SelectedValue.ToString());
                        entidadUsuario.Username = txtUsername.Text.ToLower();
                        entidadUsuario.Nombre = txtNombre.Text;
                        entidadUsuario.Contrasenia = txtContrasenia.Text;

                        UsuarioDominio.InsertarUsuario(entidadUsuario);
                        FormSucces.ConfirmacionForm("Guardado", "Registro guardado correctamente");
                        //MessageBox.Show("Usuario agregado correctamente");

                        MostrarBuscarTabla("");
                        LimpiarTextos();
                    }
                    else
                    {
                        FormError.ConfirmacionForm("Error", "Las contraseñas no coinciden");
                        //MessageBox.Show("Las contraseñas no coinciden");
                        MostrarBuscarTabla("");
                        LimpiarTextos();
                    }
                }
                catch (Exception exception)
                {
                    FormError.ConfirmacionForm("Error", "Ha ocurrido un error: " + exception.Message);
                    //MessageBox.Show("Ha ocurrido un error: " + exception.Message);
                    throw;
                }

            }
            if (editar) //Si se desea editar un registro
            {
                try
                {
                    entidadUsuario.Id_usuario = id_seleccionado;
                    entidadUsuario.Id_tipo_usuario = int.Parse(cbTipoUsuarios.SelectedValue.ToString());
                    entidadUsuario.Username = txtUsername.Text.ToLower();
                    entidadUsuario.Nombre = txtNombre.Text.ToLowerInvariant();

                    UsuarioDominio.EditarUsuario(entidadUsuario);

                    FormSucces.ConfirmacionForm("Editado", "Registro editado correctamente");
                    //MessageBox.Show("Registro editado correctamente");
                    LimpiarTextos();
                    editar = false;
                    MostrarBuscarTabla("");
                }
                catch (Exception exception)
                {
                    FormError.ConfirmacionForm("Error", "Ha ocurrido un error: " + exception.Message);
                    //MessageBox.Show("Ha ocurrido un error: " + exception.Message);
                    MostrarBuscarTabla("");
                    LimpiarTextos();
                    editar = false;
                    throw;
                }
            }
        }

        //Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                entidadUsuario.Id_usuario = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                UsuarioDominio.EliminarUsuario(entidadUsuario);

                FormSucces.ConfirmacionForm("Eliminado", "Se ha eliminado el registro correctamente");
                //MessageBox.Show("Se ha eliminado el registro correctamente");
                MostrarBuscarTabla("");
                LimpiarTextos();
            }
            else
            {
                FormError.ConfirmacionForm("Error", "Seleccione el registro que desee eliminar");
                //MessageBox.Show("Seleccione el registro que desee eliminar");
            }

            #endregion
        }

        
    }
}
