using comun.Entidades;
using dominio.tablas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_sistema_escolar.Formularios.Comun;

namespace app_sistema_escolar.Formularios.ServiciosEsc.frm_hijos
{
    public partial class frm_serviciosEscolares_verAlumnos : Form
    {
        //Campos
        DominioAlumno dominioAlumno = new DominioAlumno();
        EntidadAlumno datosAlumno = new EntidadAlumno();

        public frm_serviciosEscolares_verAlumnos()
        {
            InitializeComponent();
        }
        
        private void frm_serviciosEscolares_verAlumnos_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabla("");
            dgvAlumnos.ClearSelection();
        }

        #region Barra de busqueda y datagrid view
        
        //Listamos 
        private void MostrarBuscarTabla(string buscar)
        {
            dgvAlumnos.DataSource = dominioAlumno.ListarDatosAlumno(buscar);
        }

        //Barra de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(txtBuscar.Text);
        }
        #endregion

        #region Botones CRUD
        //Eliminar alumno
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                datosAlumno.IdAlumno = int.Parse(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());

                if (dominioAlumno.EliminarDatosAlumno(datosAlumno))
                {
                    new frm_dialogoDone("Alumno eliminado correctamente").ShowDialog();
                    MostrarBuscarTabla("");
                }
                else
                {
                    new frm_dialogoError("Ha ocurrido un error intentelo nuevamente").ShowDialog();
                    MostrarBuscarTabla("");
                }
            }
            else
                new frm_dialogoError("Seleccione un alumno para eliminar e intentelo nuevamente").ShowDialog();
                
        }

        private void btnVerInformacionAlumno_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                new frm_serviciosEscolares_verInformacionAlumno(int.Parse(dgvAlumnos.CurrentRow.Cells[0].Value.ToString())).ShowDialog();
                MostrarBuscarTabla("");
            }
            else
                new frm_dialogoError("Seleccione un alumno e intentelo nuevamente").ShowDialog();
        }
        #endregion

    }
}
