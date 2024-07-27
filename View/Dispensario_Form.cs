using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultorioPrivado.Utilidad.Forms;
using ConsultorioPrivado.Vista.Cita_Form;
using ConsultorioPrivado.Vista.Paciente;
using View.Vista.Turnos;

namespace ConsultorioPrivado.Vista.Dispensario
{
    public partial class Dispensario_Form : Form
    {
        private Form formularioActivo;


        public Dispensario_Form()
        {
            InitializeComponent();
            //controlpanel = new ControlPanel(Panel_Principal);
        }

        /*private void Ptx_Menu_Click(object sender, EventArgs e)
        {
            if (Panel_Vertical.Width == 250)
            {
                Panel_Vertical.Width = 0;
                Panel_Principal.Width = 1300;
            }
            else
            {
                Panel_Vertical.Width = 250;
                Panel_Principal.Width = 1032;
            }
        }
        */

        private void Bnt_Citas_Click(object sender, EventArgs e)
        {
            Form cita = new Cita_form();
            AbrirFormularios(cita);
        }

        private void AbrirFormularios(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.Panel_Principal.Controls.Clear();
            this.Panel_Principal.Controls.Add(formulario);
            this.Panel_Principal.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }


        private void Dispensario_Form_Load(object sender, EventArgs e)
        {/*
            Form inicio_form = new Inicio_Form(controlpanel);
            controlpanel.AbriFormulario(inicio_form, activarFormulario);*/
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            /* Form inicio_form = new Inicio_Form(controlpanel);
             controlpanel.AbriFormulario(inicio_form, activarFormulario);*/
        }

        private void Btn_Medicos_Click(object sender, EventArgs e)
        {
            Form medico_form = new Medico_form();
            AbrirFormularios(medico_form);
        }

        private void Btn_Pacientes_Click(object sender, EventArgs e)
        {
            Form paciente_form = new Paciente_form();
            AbrirFormularios(paciente_form);
        }

        private void btn_turnos_Click(object sender, EventArgs e)
        {
            Form turno_form = new Form_Turno();
            AbrirFormularios(turno_form);
        }
    }
}
