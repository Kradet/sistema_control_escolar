using comun.Entidades;
using comun.Entidades.alumnos;
using dominio.tablas.planteles_niveles;
using dominio.tablas.servicio_escolar;
using System;
using System.Windows.Forms;
using app_sistema_escolar.Formularios.Comun;

namespace app_sistema_escolar.Formularios.ServiciosEsc.frm_hijos
{
    public partial class frm_serviciosEscolares_programaEducativo : Form
    {
        //constructor
        public frm_serviciosEscolares_programaEducativo(EntidadAlumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        private void frm_serviciosEscolares_programaEducativo_Load(object sender, EventArgs e)
        {
            ListarPlanteles();
        }

        //campos
        DominioPlanteles planteles = new DominioPlanteles();
        DominioNivelesEducativos nivelesEducativos = new DominioNivelesEducativos();
        EntidadAlumno alumno;
        EntidadPlantelesNiveles plantelNivel = new EntidadPlantelesNiveles();

        public EntidadPlantelesNiveles entidadPlantelesNiveles = new EntidadPlantelesNiveles();




        //Cargamos los combobox
        private void ListarPlanteles()
        {
            cmbPlanteles.DataSource = planteles.ListarPlanteles();
            cmbPlanteles.DisplayMember = "Nombre";
            cmbPlanteles.ValueMember = "id_plantel";
        }
        private void ListarNivelesEducativos()
        {
            plantelNivel.IdPlantel = int.Parse(cmbPlanteles.SelectedIndex.ToString()) + 1; //No se puede usar el selectedvalue por que se carga varias veces antes de cargar el form y lanza una excepcion

            cmbNivelesEducativos.DataSource = nivelesEducativos.ListarNivelesDePlantel(plantelNivel);
            cmbNivelesEducativos.DisplayMember = "Nombre_nivel";
            cmbNivelesEducativos.ValueMember = "id_nivel";
        }

        private void cmbPlanteles_SelectedValues(object sender, EventArgs e) //cuando el valor seleccionado cambia
        {
            cmbNivelesEducativos.Enabled = true;

            //Limpiamos el combobox antes de rellenarlo
            cmbNivelesEducativos.DataSource = null;
            cmbNivelesEducativos.Items.Clear();

            //Llenamos el combobox
            ListarNivelesEducativos();

        }

        private bool GuardarPlantelNivel()
        {
            DominioServicioEscolar servicioEscolar = new DominioServicioEscolar();
            EntidadPlantelesNiveles datos = new EntidadPlantelesNiveles();

            datos.IdPlantel = int.Parse(cmbPlanteles.SelectedValue.ToString());
            datos.NombrePlantel = cmbPlanteles.Text;

            datos.IdNivel = int.Parse(cmbNivelesEducativos.SelectedValue.ToString());
            datos.NombreNivel = cmbNivelesEducativos.Text;

            return servicioEscolar.InsertarAlumnoProgramaEducativo(this.alumno, datos);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //No puedo hacer esto tan fácil por que la base de datos no me deja ingresar valores nulos justo aquí, en los demás campos sí, gracias ♥
            //if (GuardarPlantelNivel())
            //    frm_dialogoDone.ConfirmacionForm("Programa escolar asignado correctamente 👍");
            //else
            //    frm_dialogoError.ErrorForm("Ha ocurrido un error, por favor intentelo nuevamente 😔");
            //this.Close();


            entidadPlantelesNiveles.IdPlantel = int.Parse(cmbPlanteles.SelectedValue.ToString());
            entidadPlantelesNiveles.NombrePlantel = cmbPlanteles.Text;

            entidadPlantelesNiveles.IdNivel = int.Parse(cmbNivelesEducativos.SelectedValue.ToString());
            entidadPlantelesNiveles.NombreNivel = cmbNivelesEducativos.Text;

            this.Close();
        }

       
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"id alumno: {this.alumno.IdAlumno.ToString()} \n" +
               $"valor plantel {cmbPlanteles.SelectedValue.ToString()}\n" +
               $"valor nivel {cmbNivelesEducativos.SelectedValue.ToString()}");
        }
    }
}
