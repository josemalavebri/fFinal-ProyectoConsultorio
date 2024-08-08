using ConsultorioPrivado.Controlador.Controlers;
using Controladores.Controlador.Controlers;
using Modelo;
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
            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable dt = controladorTurno.ObtenerTurnosEstado();
            contadorDisponible(dt);
            dgv_turnos.DataSource = EstadoTexto(dt);
            DGVDisenio.Formato(dgv_turnos, false, false);
        }

        private DataTable EstadoTexto(DataTable turnos)
        {
            foreach (DataRow row in turnos.Rows)
            {
                if (row["Estado"] != DBNull.Value)
                {

                    int numer = Convert.ToInt32(row["Estado"].ToString());  
                    if(numer == 1)
                    {
                        row["Estado"] = "Disponible";
                    }
                    else
                    {
                        row["Estado"] = "No Disponible";
                    }
                }
            }
            return turnos;
        }

        private void contadorDisponible(DataTable turnos)
        {
            int contadorDisponible = 0;
            int contadorNoDisponible = 0;

            foreach (DataRow row in turnos.Rows)
            {
                if (row["Estado"] != DBNull.Value)
                {

                    int numer = Convert.ToInt32(row["Estado"].ToString());
                    if (numer == 1)
                    {
                       contadorDisponible++;
                        lbl_completados.Text = contadorDisponible.ToString();
                    }
                    if (numer == 0)
                    {
                        contadorNoDisponible++;
                        lbl_pendientes.Text = contadorNoDisponible.ToString();
                    }
                }
            }
        }

        private void dgv_turnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_turnosHoy_Click(object sender, EventArgs e)
        {

        }

        private void btn_turnoIndi_Click(object sender, EventArgs e)
        {
            Form form = new Form_CrearTurnos();
            form.ShowDialog();
            CargarDatos();
        }
    }
}
