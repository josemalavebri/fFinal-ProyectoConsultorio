using Controladores.Controlador.Controlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Utilidad;

namespace View.Vista.Turnos
{
    public partial class Form_Turno : Form
    {

        private ControladorTurno controladorTurno;
        public Form_Turno()
        {
            InitializeComponent();
            controladorTurno = new ControladorTurno();
        }

        private void Form_Turnos_Load(object sender, EventArgs e)
        {

            dgv_turnos.DataSource =  controladorTurno.ObtenerTurnos();
            DGVDisenio.Formato(dgv_turnos, false);
        }
    }
}
