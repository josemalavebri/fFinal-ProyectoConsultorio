using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad.Forms
{
    internal class Reset_ControlForms
    {
        private static bool textBoxesChanged = false;

        public static void HabilitarBotones(Button resetButton, params TextBox[] textBoxes)
        {
            Evento_HabilitarReset(resetButton, textBoxes);
            ActualizarEstadoBoton(resetButton);
        }

        public static void Evento_HabilitarReset(Button resetButton, params TextBox[] textBoxes)
        {
            CargarEventoReset(resetButton, textBoxes);
        }

        private static void CargarEventoReset(Button resetButton, params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox != null)
                {
                    textBox.TextChanged += (sender, e) => TextBox_TextChanged(sender, e, resetButton);
                }
            }
        }

        private static void TextBox_TextChanged(object sender, EventArgs e, Button resetButton)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBoxesChanged = true; 
                ActualizarEstadoBoton(resetButton);
            }
        }

        private static void ActualizarEstadoBoton(Button resetButton)
        {
            resetButton.Enabled = textBoxesChanged;
        }
    }
}
