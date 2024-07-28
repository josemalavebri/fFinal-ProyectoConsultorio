using ConsultorioPrivado.Controlador.Controlers;
using Modelo;
using ConsultorioPrivado.Utilidad.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioPrivado.Vista.Cita_Form;
using View.Utilidad.Validaciones;

namespace ConsultorioPrivado.Vista.Paciente
{
    public partial class Gestion_Paciente_form : Form
    {
        private ControladorPaciente controladorPaciente;
        private bool boolEdit;
        private bool boolCita;
        private int pacienteId;

        public Gestion_Paciente_form()
        {
            InitializeComponent();
            controladorPaciente = new ControladorPaciente();
            this.boolEdit = false;
        }

        public Gestion_Paciente_form(bool boolCita)
        {
            InitializeComponent();
            InicializarValidacion();
            controladorPaciente = new ControladorPaciente();
            this.boolCita = boolCita;
        }


        public Gestion_Paciente_form(bool boolEdit, int pacienteId)
        {
            InitializeComponent();
            InicializarValidacion();
            controladorPaciente = new ControladorPaciente();
            this.boolEdit = boolEdit;
            this.pacienteId = pacienteId;
        }

        private void InicializarValidacion()
        {
            cedula_textBox.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxNumeros);
            txt_edad.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxNumeros);
            nombre_textBox.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxLetras);
            apellido_textBox.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxLetras);
            telefono_textBox.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxNumeros);
        }

        private Pacientes crearPacienteEntidad()
        {
            Pacientes paciente = new Pacientes();
            paciente.Id = this.pacienteId;
            paciente.Cedula = Convert.ToInt32(cedula_textBox.Text.ToString());
            paciente.Edad = Convert.ToInt32(txt_edad.Text.ToString());
            paciente.Nombre = nombre_textBox.Text.ToString();
            paciente.Apellido = apellido_textBox.Text.ToString();
            paciente.Correo = correo_textBox.Text.ToString();
            paciente.Telefono = Convert.ToInt32(telefono_textBox.Text);
            return paciente;
        }

        private void agregarDatosFormularios()
        {

            Pacientes pacientes = new Pacientes();
            pacientes.Id = pacienteId;
            DataTable datosPaciente = controladorPaciente.ObtenerPacientePorId(pacientes);
            if (datosPaciente.Rows.Count > 0)
            {
                DataRow row = datosPaciente.Rows[0];
                nombre_textBox.Text = row["nombre"].ToString();
                txt_edad.Text = row["edad"].ToString();
                apellido_textBox.Text = row["apellido"].ToString();
                cedula_textBox.Text = row["cedula"].ToString();
                telefono_textBox.Text = row["telefono"].ToString();
                correo_textBox.Text = row["correo"].ToString();
            }


        }


        private void HabilitarEventoReset()
        {
            Reset_ControlForms.Evento_HabilitarReset(resetear_button, nombre_textBox, apellido_textBox, correo_textBox, telefono_textBox);
        }


        private void add_Paciente_form_Load(object sender, EventArgs e)
        {
            cedula_textBox.Focus();
            Button_ControlForms.DesabilitarBotones(resetear_button);
            HabilitarEventoReset();
            if (boolEdit)
            {
                agregarDatosFormularios();
            }

        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            Pacientes paciente = crearPacienteEntidad();
            if (boolEdit)
            {
                controladorPaciente.ActualizarPaciente(paciente);

                MessageBox.Show("Paciente Editado con exito");

            }
            else
            {
                if (controladorPaciente.CrearPaciente(paciente))
                {
                    MessageBox.Show("Paciente creado con exito");
                }
            }

            if (boolCita)
            {
                Form form = new Form_GestionCita(paciente);
                form.ShowDialog();

            }
            this.Close();

        }



        private void resetear_button_Click(object sender, EventArgs e)
        {
            vaciarText();
            resetear_button.Enabled = false;
        }

        private void vaciarText()
        {
            Text_ControlForms.EliminarTextos(cedula_textBox, txt_edad, nombre_textBox, apellido_textBox, correo_textBox, telefono_textBox);
            cedula_textBox.Focus();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
