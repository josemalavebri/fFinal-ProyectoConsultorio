using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Utilidad.Forms;
using ConsultorioPrivado.Vista.Cita_Form;
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
using View.Utilidad.Validaciones;

namespace ConsultorioPrivado.Vista.Paciente
{
    public partial class Form_BuscarPaciente : Form
    {
        private Pacientes paciente;
        private ControladorPaciente controladorPaciente;

        public Form_BuscarPaciente()
        {
            controladorPaciente = new ControladorPaciente();
            InitializeComponent();
            InicializarValidacion();
            paciente = new Pacientes();
        }

        private void InicializarValidacion()
        {
            cedula_text.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxNumeros);
        }

        private void CargarDataGrid()
        {
            dgv_paciente.DataSource = controladorPaciente.ObtenerPorPaciente();
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

        private void resetear_button_Click(object sender, EventArgs e)
        {
            Text_ControlForms.EliminarTextos(cedula_text);
            btn_guardar.Enabled = false;
            txt_pacienteSelec.Text = string.Empty;
            CargarDataGrid();
        }


        private void dgv_paciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_paciente.Rows[e.RowIndex];
                paciente.Id = Convert.ToInt32(row.Cells["id"].Value);
                paciente.Nombre = row.Cells["Nombre"].Value.ToString();
                paciente.Apellido = row.Cells["Apellido"].Value.ToString();

                // paciente.Edad = Convert.ToInt32(row.Cells["Edad"].Value);
                paciente.Correo = row.Cells["Correo"].Value.ToString();
                paciente.Telefono = Convert.ToInt32(row.Cells["Telefono"].Value);
            }
            txt_pacienteSelec.Text = paciente.ToString();
            btn_guardar.Enabled = true;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Form form = new Form_GestionCita(paciente);
            form.ShowDialog();
            this.Close();
        }

        private void Form_BuscarPaciente_Load(object sender, EventArgs e)
        {
            Button_ControlForms.DesabilitarBotones(btn_guardar);
            CargarDataGrid();
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            paciente.Cedula = Convert.ToInt32(cedula_text.Text.ToString());
            dgv_paciente.DataSource = controladorPaciente.ObtenerPorCedula(paciente);

        }
    }
}
