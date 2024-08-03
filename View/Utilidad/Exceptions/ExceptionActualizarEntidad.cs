using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Utilidad.Exceptions
{
    //EXEPCION QUE SE CONTROLA CUANDO SE ACTUALIZAN LOS  DATOS EN LA BASE DE DATOS
    internal class ExceptionActualizarEntidad : Exception
    {

        public ExceptionActualizarEntidad (string mensaje) : base(mensaje)
        {
            MessageBox.Show(mensaje);

        }
    }
}
