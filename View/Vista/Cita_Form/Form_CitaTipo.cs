using ConsultorioPrivado.Vista.Paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Vista.Cita_Form
{
    public partial class Form_CitaTipo : Form
    {
        public Form_CitaTipo()
        {
            InitializeComponent();
        }

        private void btn_pacienteRecurrente_Click(object sender, EventArgs e)
        {
            Form form = new Form_BuscarPaciente();
            form.ShowDialog();
            this.Close();
        }

        private void btn_pacienteNuevo_Click(object sender, EventArgs e)
        {
            Form form = new add_Paciente_form(true);
            form.ShowDialog();
            this.Close();
        }
    }
}
