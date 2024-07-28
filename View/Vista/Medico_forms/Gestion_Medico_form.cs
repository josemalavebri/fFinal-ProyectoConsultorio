using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Utilidad.Forms;
using ConsultorioPrivado.Vista.Cita_Form;
using ConsultorioPrivado.Vista.Paciente;
using Microsoft.Identity.Client.NativeInterop;
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
using View.Utilidad.Exceptions;
using View.Utilidad.Validaciones;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace ConsultorioPrivado.Vista
{
    public partial class Gestion_Medico_form : Form
    {
        private ControladorMedico controladorMedico;
        private bool boolEdit;
        private bool boolCita;
        private int medicoId;
        private int medicoEspecialidad;
        private ErrorProvider errorProvider = new ErrorProvider();

        public Gestion_Medico_form()
        {
            InitializeComponent();
            InicializarValidacion();
            controladorMedico = new ControladorMedico();
            Button_ControlForms.DesabilitarBotones(resetear_button);
        }

        public Gestion_Medico_form(bool boolEdit, int medicoId, int medicoEspecialidad)
        {
            InitializeComponent();
            InicializarValidacion();
            controladorMedico = new ControladorMedico();
            this.boolEdit = boolEdit;
            this.medicoId = medicoId;
            this.medicoEspecialidad = medicoEspecialidad;

        }

        private void InicializarValidacion()
        {
            nombre_text.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxLetras);
            apellido_text.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxLetras);
            cedula_text.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxNumeros);
            telefono_text.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxNumeros);
        }

        private Medico crearMedicoEntidad()
        {
            Medico medico = new Medico();
            medico.Cedula = Convert.ToInt32(cedula_text.Text.ToString());
            medico.Nombre = nombre_text.Text.ToString();
            medico.Apellido = apellido_text.Text.ToString();
            medico.Correo = correoText.Text.ToString();
            medico.Telefono = Convert.ToInt32(telefono_text.Text);
            medico.Especialidad_id = especialidad_combo.SelectedIndex+1;
            return medico;
        }

        private void agregarDatosFormularios()
        {

            Medico medicos = new Medico();
            medicos.Id = medicoId;
            DataTable datosPaciente = controladorMedico.ObtenerMedicoPorId(medicos);
            if (datosPaciente.Rows.Count > 0)
            {
                DataRow row = datosPaciente.Rows[0];
                nombre_text.Text = row["nombre"].ToString();
                apellido_text.Text = row["apellido"].ToString();
                cedula_text.Text = row["cedula"].ToString();
                correoText.Text = row["correo"].ToString();
                telefono_text.Text = row["telefono"].ToString();
            }
            especialidad_combo.SelectedIndex = this.medicoEspecialidad -1;
            especialidad_combo.Enabled = false;
        }

        private void HabilitarEventoReset()
        {
            Reset_ControlForms.Evento_HabilitarReset(resetear_button, nombre_text, apellido_text, cedula_text, telefono_text);
        }

        private void add_Medico_form_Load(object sender, EventArgs e)
        {
            cedula_text.Focus();
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
            Medico medico = crearMedicoEntidad();
            if (boolEdit)
            {
                medico.Id = this.medicoId;
                medico.Especialidad_id = this.medicoEspecialidad;
                if (!controladorMedico.ActualizarMedico(medico))
                {
                    throw new ExceptionActualizarEntidad("Error al actualizar Medico");

                }
                this.Close();
            }

            else
            {
                if (!controladorMedico.CrearMedico(medico))
                {
                    throw new ExceptionCrearEntidad("Error al crear Medico");
                }
                this.Close();
            }
        }

        private void resetear_button_Click(object sender, EventArgs e)
        {
            vaciarTexts();
            resetear_button.Enabled = false;
        }

        private void vaciarTexts()
        {
            Text_ControlForms.EliminarTextos(nombre_text, apellido_text, cedula_text, telefono_text);
            cedula_text.Focus();
        }
    }
}
