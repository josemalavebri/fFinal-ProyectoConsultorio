using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Utilidad.Exceptions
{
    internal class ExceptionActualizarEntidad : Exception
    {

        public ExceptionActualizarEntidad (string mensaje) : base(mensaje)
        {
            MessageBox.Show(mensaje);

        }
    }
}
