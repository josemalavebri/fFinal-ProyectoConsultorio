﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPrivado.Utilidad.Forms
{
    //EJECUTA LAS ACCIONES DE CONTROL SOBRE LOS TEXTBOX DE LOS FORMULARIOS

    public class Text_ControlForms
    {
        private static void QuitarTextos(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = string.Empty;
            }
        }
       
        public static void EliminarTextos(params TextBox[] textBoxes)
        {
            QuitarTextos(textBoxes);
        }
    }
}
