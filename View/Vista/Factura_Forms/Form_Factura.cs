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
using System.Windows.Navigation;

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
            cargarCita();
            ControlComboBox.ver_Combo_Entidad_Sin_Parametros(combo_Metodo,controlfact.ObtenerTipoPago,
                                                            "tipoPago", "id");
        }
        private void cargarCita()
        {
            CitaMedica cita = new CitaMedica();
            cita.IdPaciente = id_paciente;
            cita.IdMedicoTurno = medicoturno;
            DataTable datos_cita =controlfact.Obtener_Cita_PorIDs<CitaMedica>(cita);
            if(datos_cita.Rows.Count > 0 )
            {
                DataRow fila = datos_cita.Rows[0];
                id_cita_text.Text = fila["id"].ToString();
                id_turno_text.Text = fila["Turno"].ToString();
                paciente_text.Text = fila["Paciente"].ToString();
                medico_text.Text=fila["Medico"].ToString();
                fecha_text.Text = fila["Fecha"].ToString();
                hora_text.Text = fila["Hora"].ToString();
                especialidad_text.Text = fila["Especialidad"].ToString();
                precio_text.Text = fila["Precio"].ToString();      
            }
            float precio = Convert.ToSingle(precio_text.Text);
            float subtotal = calcularSub(precio);
            sub_text.Text = Convert.ToString(subtotal);
            float total = calcularTotal(subtotal,precio);
            total_text.Text = Convert.ToString(total);
        }
        private float calcularSub(float precio)
        {
            Factura factura = new Factura();
            return precio * factura.IVA;
        }
        private float calcularTotal(float subtotal, float precio)
        {
            return subtotal * precio;
        }
        private Factura crearFactura()
        {
            Factura factura = new Factura();
            factura.IdMetodo_Pago = Convert.ToInt32(combo_Metodo.SelectedValue);
            factura.IdCita = Convert.ToInt32(id_cita_text.Text);
            factura.Subtotal = Convert.ToSingle(sub_text.Text); 
            factura.Monto = Convert.ToInt32(total_text.Text);
            return factura;
        }
        private float Total()
        {

            return 0; 
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
