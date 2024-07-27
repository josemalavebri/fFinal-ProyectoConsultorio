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
        private CitaMedica citaMedica;
        private ControladorCita controladorCita;
        public Cita_form()
        {
            InitializeComponent();
            controladorCita = new ControladorCita();
            citaMedica = new CitaMedica();

        }

        private void nuevo_button_Click(object sender, EventArgs e)
        {
            Form formcita = new Form_CitaTipo();
            formcita.ShowDialog();
        }

        private void Cita_form_Load(object sender, EventArgs e)
        {
            CargarDataGrid();

            DGVDisenio.Formato(citas_dgv, false, true);
        }

        private void CargarDataGrid()
        {
            citas_dgv.DataSource = controladorCita.ObtenerPorCita();
        }

        private void citas_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (citas_dgv.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(citas_dgv.CurrentRow.Cells["Id"].Value.ToString()); ;
                citaMedica.Id = id;
                DialogResult result = MostrarMensaje();
                if (result == DialogResult.OK)
                {
                    controladorCita.EliminarCita(citaMedica);
                    CargarDataGrid();
                }
            }

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
    }

   
}
