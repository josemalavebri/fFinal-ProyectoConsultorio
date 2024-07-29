using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Factura:IEntidad
    {
        private int id_cita;
        private float monto;
        private int id_metodo_pago;
        public Factura() 
        { 
            id_cita = 0;
            monto = 0;
            id_metodo_pago = 0;
        }
        public Factura(int id_cita, float monto, int id_metodo_pago)
        {
            this.id_cita = id_cita;
            this.monto = monto;
            this.id_metodo_pago = id_metodo_pago;
        }
        public int IdCita { get => id_cita; set => id_cita = value; }
        public float Monto { get => monto; set => monto = value; }
        public int IdMetodo_Pago {  get => id_metodo_pago;set=>id_metodo_pago=value; }
    }
}
