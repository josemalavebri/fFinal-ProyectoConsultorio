using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Utilidad.Forms;
using ConsultorioPrivado.Vista.Cita_Form;
using ConsultorioPrivado.Vista.Paciente_forms;
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

namespace ConsultorioPrivado.Vista.Paciente
{
    public partial class Form_BuscarPaciente : Form
    {
        private Pacientes paciente;
        private ControladorPaciente controlador;

        public Form_BuscarPaciente()
        {
            controlador = new ControladorPaciente();
            InitializeComponent();
        }

        private void CargarDataGrid()
        {
            dgv_paciente.DataSource = controlador.ObtenerPorPaciente();
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
        }

        private void dgv_paciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_paciente.Rows[e.RowIndex];
                paciente.Id = Convert.ToInt32(row.Cells["Id"].Value);
                paciente.Nombre = row.Cells["Nombre"].Value.ToString();
                paciente.Edad = Convert.ToInt32(row.Cells["Edad"].Value);
                paciente.Correo = row.Cells["Correo"].Value.ToString();
                paciente.Telefono = Convert.ToInt32(row.Cells["Telefono"].Value);
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Form form = new Agregar_Cita_Form(paciente);
            form.ShowDialog();
            this.Close();
        }
    }
}
