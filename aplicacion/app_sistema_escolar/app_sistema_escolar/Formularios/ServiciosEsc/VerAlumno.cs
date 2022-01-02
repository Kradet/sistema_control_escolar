using comun.Entidades;
using dominio.tablas;
using System;
using System.Drawing;
using System.Windows.Forms;
using app_sistema_escolar.Formularios.Comun;

namespace app_sistema_escolar.Formularios.ServiciosEsc
{
    public partial class VerAlumno : Form
    {
        //Campos
        DominioAlumno dominioAlumo = new DominioAlumno();
        EntidadAlumno datosAlumno = new EntidadAlumno();
        //FormNuevoAlumno frmNuevoAlumno = new FormNuevoAlumno();
        //FormVerContactoAlumno frmVerContactoAlumno;


        public VerAlumno()
        {
            InitializeComponent();
        }

        private void VerAlumno_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabla("");
            dgvAlumnos.ClearSelection();
        }

        #region Barra de busqueda

        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(txtBuscar.Text);
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.ForeColor = Color.White;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        #endregion

        #region Datagridview

        //Listamos los alumnos en la tabla
        private void MostrarBuscarTabla(string buscar)
        {
            dgvAlumnos.DataSource = dominioAlumo.ListarDatosAlumno(buscar);
        }


        #endregion

        #region Botones CRUD

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //frmNuevoAlumno.ShowDialog();
            new FormNuevoAlumno().ShowDialog();
            MostrarBuscarTabla("");
        }

        #endregion

        private void btnVerContacto_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                new FormVerContactoAlumno(int.Parse(dgvAlumnos.CurrentRow.Cells[0].Value.ToString())).ShowDialog();
                MostrarBuscarTabla("");
               //frmVerContactoAlumno = new FormVerContactoAlumno(int.Parse(dgvAlumnos.CurrentRow.Cells[0].Value.ToString()));
               //frmVerContactoAlumno.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count >0)
            {
                datosAlumno.IdAlumno = int.Parse(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());
                if (dominioAlumo.EliminarDatosAlumno(datosAlumno))
                {
                    MostrarBuscarTabla("");
                    new FormSucces("ELIMINADO", "Se ha eliminado el registro correctamente").ShowDialog();
                }
                else
                {
                    new FormError("ERROR", "Ha ocurrido un error, por favor vuelvalo a intentar o contacte a servicio tecnico");
                }
            }
        }

        
    }
}
