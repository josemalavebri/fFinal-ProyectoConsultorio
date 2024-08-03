using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Utilidad.Forms
{
    //EJECUTA LAS ACCIONES DE CONTROL SOBRE LOS COMBOBOX

    public class ControlComboBox
    {
        public delegate DataTable Operacion_Sin_Parametros();

        //Metodo de tipo lista para que nos retorne como lista
        // parametros: metodo de tipo metodo, string columna, string valor
        //que este metodo sea privado y haya un metodo que me permita acceder a este
        private static void obtener_Combo(ComboBox combo,
                                          Operacion_Sin_Parametros operacion,
                                          string columna,
                                          string valor)
        {
            combo.DataSource = operacion();
            combo.DisplayMember = columna;
            combo.ValueMember = valor;
            combo.SelectedIndex = -1;
        }
        public static void ver_Combo_Entidad_Sin_Parametros(ComboBox combo,
                                             Operacion_Sin_Parametros operacion,
                                             string columna,
                                             string valor)
        {
            obtener_Combo(combo, operacion, columna, valor);
        }
    }
}
