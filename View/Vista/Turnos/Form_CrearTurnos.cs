using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Vista.Cita_Form;
using Controladores.Controlador.Controlers;
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

namespace View.Vista.Turnos
{

    public partial class Form_CrearTurnos : Form
    {
        private List<Medico> listaMedico;

        private ControladorTurno controladorTurno;
        private ControladorMedico controladorMedico;
        private ControladorMedicoTurno controladorMedicoTurno;

        private Turno turno;
        private MedicoTurno medicoTurno;

        public Form_CrearTurnos()
        {
            InitializeComponent();
            controladorTurno = new ControladorTurno();
            listaMedico = new List<Medico>();
            controladorMedico = new ControladorMedico();
            turno = new Turno();
            medicoTurno = new MedicoTurno();
            controladorMedicoTurno = new ControladorMedicoTurno();
        }


        private void obtenerMedicos()
        {
            listaMedico = new List<Medico>();
            DataTable dataTableMedico = controladorMedico.ObtenerPorMedico();

            foreach (DataRow row in dataTableMedico.Rows)
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
            cmb_medico.DataSource = listaMedico;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            turno = crearEntidadturno();


            if (controladorTurno.CrearTurno(turno))
            {
                turno = BuscarUltimoId(turno);
                medicoTurno = CrearMedicoTurno(turno);

                if (controladorMedicoTurno.CrearTurno(medicoTurno))
                {
                    MessageBox.Show("Turno guardado con exito");

                }
            }
            else
            {
                MessageBox.Show("Turno no guardado");

            }


            this.Close();


        }

        private MedicoTurno CrearMedicoTurno(Turno turno)
        {
            Medico medico = (Medico)cmb_medico.SelectedItem;
            medicoTurno.IdMedico = medico.Id;
            medicoTurno.IdTurno = turno.Id;
            medicoTurno.Estado = false;
            return medicoTurno;
        }

        private Turno BuscarUltimoId(Turno turno)
        {
            DataTable datos = controladorTurno.ObtenerTurnos();

            int totalIDs = datos.Rows.Count;

            foreach (DataRow row in datos.Rows)
                if (Convert.ToInt32(row["Id"].ToString()) == totalIDs)
                {
                    turno.Id = Convert.ToInt32(row["Id"].ToString());
            }
            return turno;
        } 

        private Turno crearEntidadturno()
        {
            turno = new Turno();
            turno.IdJornada = cmb_jornada.SelectedIndex + 1;

            DateTime selectedDate = date_fecha.Value.Date;
            turno.Fecha = selectedDate.ToString("yyyy-MM-dd");

            turno.Hora = txt_hora.Text.ToString();
            turno.Minuto = txt_minuto.Text.ToString();
            return turno;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_CrearTurnos_Load(object sender, EventArgs e)
        {
            obtenerMedicos();
        }
    }
}
