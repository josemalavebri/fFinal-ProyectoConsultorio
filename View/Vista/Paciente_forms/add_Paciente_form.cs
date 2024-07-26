﻿using ConsultorioPrivado.Controlador.Controlers;
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
    public partial class add_Paciente_form : Form
    {
        private ControladorPaciente controladorPaciente;
        private bool boolCita;

        public add_Paciente_form(bool boolCita)
        {
            InitializeComponent();
            controladorPaciente = new ControladorPaciente();
            this.boolCita = boolCita;
        }


        private Pacientes crearPacienteEntidad()
        {
            Modelo.Pacientes paciente = new Pacientes();
            paciente.Cedula = Convert.ToInt32(cedula_textBox.Text.ToString());
            paciente.Edad = Convert.ToInt32(txt_edad.Text.ToString());
            paciente.Nombre = nombre_textBox.Text.ToString();
            paciente.Apellido = apellido_textBox.Text.ToString();
            paciente.Correo = correo_textBox.Text.ToString();
            paciente.Telefono = Convert.ToInt32(telefono_textBox.Text);
            return paciente;
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
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar_button_Click(object sender, EventArgs e)
        {
            Pacientes paciente = crearPacienteEntidad();
            if (controladorPaciente.CrearPaciente(paciente))
            {
                MessageBox.Show("Paciente creado con exito");
                this.Close();
            }
            if (boolCita)
            {
                Form form = new Agregar_Cita_Form(paciente);
                form.ShowDialog();
                this.Close();

            }
        }

        private void resetear_button_Click(object sender, EventArgs e)
        {
            vaciarText();
            resetear_button.Enabled = false;
        }
        private void vaciarText()
        {
            Text_ControlForms.EliminarTextos(cedula_textBox,txt_edad, nombre_textBox, apellido_textBox, correo_textBox, telefono_textBox);
            cedula_textBox.Focus();
        }
    }
}
