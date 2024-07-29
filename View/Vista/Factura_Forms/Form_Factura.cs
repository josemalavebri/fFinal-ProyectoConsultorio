using Controller.Controlador.Controlers;
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
using Model;
using View.Utilidad.Forms;

namespace View.Vista.Factura_Forms
{
    public partial class Form_Factura : Form
    {
        private int id_paciente, medicoturno;
        private ControladorFactura controlfact;
        public Form_Factura(int id_paciente, int medicoturno)
        {
            InitializeComponent();
            this.id_paciente = id_paciente;
            this.medicoturno = medicoturno;
            controlfact = new ControladorFactura();
        }

        private void Form_Factura_Load(object sender, EventArgs e)
        {
            CitaMedica cita = cargarCita();
            controlfact.Obtener_Cita_PorIDs(cita);
            ControlComboBox.ver_Combo_Entidad_Sin_Parametros(combo_Metodo,controlfact.ObtenerTipoPago,
                                                            "tipoPago", "id");
        }
        private CitaMedica cargarCita()
        {
            CitaMedica cita = new CitaMedica();
            cita.IdPaciente = id_paciente;
            cita.IdMedicoTurno = medicoturno;

            return cita;
        }
        private Factura crearFactura()
        {
            Factura factura = new Factura();
            factura.IdMetodo_Pago = Convert.ToInt32(combo_Metodo.SelectedValue);
            factura.IdCita = Convert.ToInt32(id_cita_text.Text);
            factura.Monto = Convert.ToInt32(total_text.Text);
            return factura;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Factura factura = crearFactura();
            if (controlfact.CrearFactura<Factura>(factura))
            {
                MessageBox.Show("Factura guardada");
            }
            this.Close();
        }
    }
}
