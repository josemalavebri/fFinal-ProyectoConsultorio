using Controller.Controlador.Controlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Utilidad.Forms;
using Vista.Utilidad;

namespace View.Vista.Factura_Forms
{
    public partial class View_Facturas_Form : Form
    {
        private ControladorFactura control_fac;
        private ControlPanel controlPanel;
        public View_Facturas_Form(ControlPanel controlPanel)
        {
            InitializeComponent();
            control_fac = new ControladorFactura();
            this.controlPanel = controlPanel;
        }
        private void CargarDatosGrid()
        {
            Dgv_Factura.DataSource = control_fac.ObtenerFacturaCita();
            DGVDisenio.Formato(Dgv_Factura,false,false);
        }


        private void View_Facturas_Form_Load(object sender, EventArgs e)
        {
            CargarDatosGrid();
        }

    }
}
