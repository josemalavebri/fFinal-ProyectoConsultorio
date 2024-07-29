using ConsultorioPrivado.Controlador.Controlers;
using ConsultorioPrivado.Controlador.Enums;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controlador.Controlers
{
    public class ControladorFactura
    {
        private ControladorCreator controlador;
        public ControladorFactura()
        {
            controlador = new ControladorCreator();
        }
        public DataTable Obtener_Cita_PorIDs<T>(T entidad)where T :IEntidad
        {
            List<string> lista = new List<string>()
            {
                "idPacienteFk", //IdPaciente
                "idMedicoEstadoFk" //IdMedicoTurno
            }; 
            return controlador.ObtenerPropiedadesEspecificas(lista, entidad,E_ROL._CITA_PACIENTE);
        }
        public bool CrearFactura <T> (T entidad)where T: IEntidad
        {
            return controlador.CrearEntidad(entidad, E_ROL._FACTURA);
        }
        public DataTable ObtenerTipoPago()
        {
            return controlador.ObtenerEntidad(E_ROL._TIPO_PAGO);
        }
        public DataTable ObtenerFacturas()
        {
            return controlador.ObtenerEntidad(E_ROL._FACTURA);
        }
    }
}
