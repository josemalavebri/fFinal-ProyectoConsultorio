using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Controlador.Enums;
using ConsultorioPrivado.Datos.Interface;
using ConsultorioPrivado.Utilidad.Forms;
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
using View.Utilidad.Validaciones;
using Vista.Utilidad;

namespace ConsultorioPrivado.Vista
{
    public partial class Medico_form : Form
    {
        private ControladorMedico controladorMedico;
        private Medico medico;
        private ErrorProvider errorProvider = new ErrorProvider();
        public Medico_form()
        {
            controladorMedico = new ControladorMedico();
            InitializeComponent();
            InicializarValidacion();
            if (medico == null)
            {
                medico = new Medico();
            }
        }

        private void InicializarValidacion()
        {
            cedula_text.KeyPress += new KeyPressEventHandler(Validaciones.VerificarTextBoxNumeros);
        }

        public void CargarDataGrid()
        {
            medicos_dgv.DataSource = controladorMedico.ObtenerPorMedico();
            int numero = medicos_dgv.ColumnCount;
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

        private void nuevo_button_Click_1(object sender, EventArgs e)
        {
            Form form = new Gestion_Medico_form();
            form.ShowDialog();
            CargarDataGrid();
        }

        private void resetear_button_Click_1(object sender, EventArgs e)
        {
            Text_ControlForms.EliminarTextos(cedula_text);
            cedula_text.Focus();
            CargarDataGrid();
        }

        private void medicos_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (medicos_dgv.Columns[e.ColumnIndex].Name == "Editar")
            {
                int idMedico = Convert.ToInt32(medicos_dgv.CurrentRow.
                     Cells["id"].Value.ToString());
                int especialidadMedico = Convert.ToInt32(medicos_dgv.CurrentRow.
                     Cells["idEspecialidadfk"].Value.ToString());
                Gestion_Medico_form editarMedico = new Gestion_Medico_form(true, idMedico, especialidadMedico);
                editarMedico.ShowDialog();
                CargarDataGrid();
            }

            if (medicos_dgv.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = Convert.ToInt32(medicos_dgv.CurrentRow.

                   Cells["Id"].Value.ToString()); ;

                medico.Id = id;
                DialogResult result = MostrarMensaje();
                if (result == DialogResult.OK)
                {
                    controladorMedico.EliminarMedico(medico);
                    CargarDataGrid();
                }
            }
        }

        private void Medico_form_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            InicializarValidacion();
            DGVDisenio.Formato(medicos_dgv, true);
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            medico.Cedula = Convert.ToInt32(cedula_text.Text.ToString());
            medicos_dgv.DataSource = controladorMedico.ObtenerPorCedula(medico);
        }
    }
}