using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Utilidad.Exceptions
{
    internal class ExceptionEliminarEntidad : Exception
    {

        public ExceptionEliminarEntidad(string mensaje) : base(mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
