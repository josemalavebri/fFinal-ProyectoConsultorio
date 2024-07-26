using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Vista.Paciente;
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
using View.Vista.Cita_Form;
using Vista.Utilidad;

namespace ConsultorioPrivado.Vista.Cita_Form
{
    public partial class Cita_form : Form
    {

        ControladorCita controladorCita;
        public Cita_form()
        {
            InitializeComponent();
            controladorCita = new ControladorCita();
        }

        private void nuevo_button_Click(object sender, EventArgs e)
        {
            Form formcita = new Form_CitaTipo();
            formcita.ShowDialog();
        }

        private void Cita_form_Load(object sender, EventArgs e)
        {
            citas_dgv.DataSource = controladorCita.ObtenerPorCita();
            DGVDisenio.Formato(citas_dgv);

        }
    }
}
