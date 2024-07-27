using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Utilidad.Forms;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Utilidad;

namespace ConsultorioPrivado.Vista.Paciente
{
    public partial class Paciente_form : Form
    {
        private ControladorPaciente controladorPaciente;
        private Pacientes paciente;
        public Paciente_form()
        {
            controladorPaciente = new ControladorPaciente();
            InitializeComponent();
            if (paciente == null)
            {
                paciente = new Pacientes();
            }
        }


        private void CargarDataGrid()
        {

            paciente_dgv.DataSource = controladorPaciente.ObtenerPorPaciente();

            int numero = paciente_dgv.ColumnCount;



        }

        private DialogResult MostrarMensaje()
        {
            DialogResult result = MessageBox.Show(
                "Desea eliminar?\nSe eliminará de forma permanente",
                   "Confirmación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
            return result;
        }
        private void nuevo_button_Click(object sender, EventArgs e)
        {
            Form form = new Gestion_Paciente_form(false);
            form.ShowDialog();
            CargarDataGrid();
        }

        private void resetear_button_Click(object sender, EventArgs e)
        {
            Text_ControlForms.EliminarTextos(cedula_text);
            cedula_text.Focus();
            CargarDataGrid();
        }

        private void paciente_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (paciente_dgv.Columns[e.ColumnIndex].Name == "Editar")
            {
                int idPaciente = Convert.ToInt32(paciente_dgv.CurrentRow.
                     Cells["id"].Value.ToString());
                Gestion_Paciente_form editarPaciente = new Gestion_Paciente_form(true,idPaciente);
                editarPaciente.ShowDialog();
                CargarDataGrid();
            }

            if (paciente_dgv.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(paciente_dgv.CurrentRow.

                   Cells["Id"].Value.ToString()); ;
                
                paciente.Id = id;
                DialogResult result = MostrarMensaje();
                if (result == DialogResult.OK)
                {
                    controladorPaciente.EliminarPaciente(paciente);
                    CargarDataGrid();
                }
            }
        }

        private void paciente_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Paciente_form_Load(object sender, EventArgs e)
        {
            CargarDataGrid();

            DGVDisenio.Formato(paciente_dgv,true);
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            paciente.Cedula = Convert.ToInt32(cedula_text.Text.ToString());
            paciente_dgv.DataSource = controladorPaciente.ObtenerPorCedula(paciente);

        }
    }
}
