using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Utilidad.Forms;
using Controladores.Controlador.Controlers;
using Modelo;

namespace ConsultorioPrivado.Vista.Cita_Form
{
    public partial class Agregar_Cita_Form : Form
    {
        //OBJETOS
        private Pacientes paciente;
        private CitaMedica citaMedica;
        private Medico medicoActual;
        private int idTurno;
        //private MedicoTurno medicoTurno;

        private bool nuevoPaciente;
        private List<Pacientes> listaPacientes;
        private List<Medico> listaMedico;


        //CONTROLADORES
        private ControladorCita controladorCita;
        private ControladorTurno controladorTurno;
        private ControladorMedico controladorMedico;



        public Agregar_Cita_Form(Pacientes paciente)
        {
            listaPacientes = new List<Pacientes>();
            listaPacientes.Clear();
            listaPacientes.Add(paciente);

            InitializeComponent();
            controladorTurno = new ControladorTurno();
            controladorCita = new ControladorCita();
            controladorMedico = new ControladorMedico();
            citaMedica = new CitaMedica();
            this.paciente = paciente;

            this.nuevoPaciente = nuevoPaciente;
        }

        private void Agregar_Cita_Form_Load(object sender, EventArgs e)
        {
            CargarGrid();
            HabilitarEventoReset();
            Button_ControlForms.DesabilitarBotones(resetear_button);
        }

        private void CargarGrid()
        {
            combo_Pacientes.DataSource = listaPacientes;
            listaMedico = new List<Medico>();
            DataTable dataTable = controladorMedico.ObtenerPorMedico();

            foreach (DataRow row in dataTable.Rows)
            {
                var medico = new Medico
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Especialidad_id = Convert.ToInt32(row["idEspecialidadFk"].ToString())
                };

                listaMedico.Add(medico);
            }
            combo_Medicos.DataSource = listaMedico;


        }

        private void HabilitarEventoReset()
        {
            Reset_ControlForms.Evento_HabilitarReset(resetear_button, description_text);
        }


        private void agregar_button_Click(object sender, EventArgs e)
        {
            try
            {
                citaMedica = CrearObjetoCitaMedica();
                if (controladorCita.CrearCita(citaMedica))
                    MessageBox.Show("Cita Creada Exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private CitaMedica CrearObjetoCitaMedica()
        {
            citaMedica.IdPaciente = paciente.Id;
            citaMedica.Descripcion = description_text.Text;
            citaMedica.IdMedicoTurno = idTurno;
            return citaMedica;
        }

        private void combo_Pacientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            paciente = (Pacientes)combo_Pacientes.SelectedItem;
        }
        private void combo_Medicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicoActual = (Medico)combo_Medicos.SelectedItem;
            turnos_dgv.DataSource = controladorTurno.ObtenerPorEspecialidad(medicoActual);
        }


        private void resetear_button_Click(object sender, EventArgs e)
        {
            combo_Pacientes.SelectedIndex = -1;
            combo_Medicos.SelectedIndex = -1;
            turnos_dgv.Rows.Clear();
            description_text.Text = string.Empty;

            Button_ControlForms.HabilitarBotones(agregar_button, cancelar_button);
            Button_ControlForms.DesabilitarBotones(cancelar_button);
            Text_ControlForms.EliminarTextos(description_text);
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBx_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GBx_Cita_Enter(object sender, EventArgs e)
        {

        }

    

        private void turnos_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = turnos_dgv.Rows[e.RowIndex];
                idTurno = Convert.ToInt32(row.Cells["id"].Value.ToString());
                txt_turnoFecha.Text =  row.Cells["fecha"].Value.ToString().Substring(0,10);
                txt_turnoHora.Text = row.Cells["Hora"].Value.ToString() + ":" +
                    row.Cells["minuto"].Value.ToString();
            }

        }
    }
}