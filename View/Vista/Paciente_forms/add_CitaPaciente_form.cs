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

namespace ConsultorioPrivado.Vista.Paciente
{
    public partial class add_CitaPaciente_form : Form
    {
        private ControladorPaciente controlador;
        private Pacientes paciente;
        public add_CitaPaciente_form()
        {
            InitializeComponent();
            paciente = new Pacientes();
        }
       
        /*private void resetearButtonEstado(bool estado)
        {
            Button_ControlForms.desabilitarHabilitarBotones(estado, resetear_button);

        }
        */



        private Pacientes crearPacienteEntidad()
        { 
            paciente.Cedula = Convert.ToInt32(cedula_textBox.Text.ToString());
            paciente.Nombre = nombre_textBox.Text.ToString();
            paciente.Apellido = apellido_textBox.Text.ToString();
            paciente.Correo = correo_textBox.Text.ToString();
            paciente.Telefono = Convert.ToInt32(telefono_textBox.Text);
            return paciente;
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                Button_ControlForms.HabilitarBotones(resetear_button);
            }
        }
        private void vaciarText()
        {
            Text_ControlForms.EliminarTextos(cedula_textBox, nombre_textBox, apellido_textBox, correo_textBox, telefono_textBox);
        }

        private void add_Paciente_form_Load(object sender, EventArgs e)
        {

        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            crearPacienteEntidad();
            Form form = new Agregar_Cita_Form(paciente);
            form.ShowDialog();
            this.Close();
        }
    }
}
