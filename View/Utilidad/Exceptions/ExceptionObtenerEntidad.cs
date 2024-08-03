﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Utilidad.Exceptions
{
    //EXEPCION QUE SE CONTROLA CUANDO SE OBTIENEN LOS DATOS DE LA BASE DE DATOS

    internal class ExceptionObtenerEntidad : Exception
    {

        public ExceptionObtenerEntidad(string mensaje) : base(mensaje)
        {
            MessageBox.Show(mensaje);
        }


    }
}
