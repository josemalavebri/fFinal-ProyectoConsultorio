using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Utilidad.Exceptions
{
    //EXEPCION QUE SE CONTROLA CUANDO SE ELIMINAN LOS DATOS EN LA BASE DE DATOS

    internal class ExceptionEliminarEntidad : Exception
    {

        public ExceptionEliminarEntidad(string mensaje) : base(mensaje)
        {
            MessageBox.Show(mensaje);
        }


    }
}
