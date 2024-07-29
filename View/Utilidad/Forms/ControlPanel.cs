using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Utilidad.Forms
{
    public class ControlPanel
    {
        private Panel panel;
        public ControlPanel(Panel panel_principal)
        {
            this.panel = panel_principal;
        }
        public void AbrirFormulario(Form ventana_form,Form activarFormulario)
        {
            if (activarFormulario != null)
            {
                activarFormulario.Close();
            }
            panel.Controls.Clear();
            activarFormulario = ventana_form;
            ventana_form.TopLevel = false;
            ventana_form.FormBorderStyle = FormBorderStyle.None;
            ventana_form.Dock = DockStyle.Fill;
            panel.Controls.Add(ventana_form);
            panel.Tag = ventana_form;
            ventana_form.BringToFront();
            ventana_form.Show();
        }
    }
}
