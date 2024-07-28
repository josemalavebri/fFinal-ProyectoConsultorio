using ConsultorioPrivado.Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Datos.DbOperaciones
{
    public class TestingConexionDB
    {
        private ConexionDB conn = new ConexionDB();


        public bool returnConnectionOpen()
        {
            SqlConnection connection = conn.AbrirConexion();
            return connection.State == ConnectionState.Open;
        }

        public bool returnConexionClosed()
        {
            SqlConnection connection = conn.CerrarConexion();
            return connection.State == ConnectionState.Closed;
        }
    }
}
