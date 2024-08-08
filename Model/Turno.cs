using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Turno : IEntidad
    {
        private int id;
        private int idJornada;
        private string fecha;
        private string hora;
        private string minuto;

        public Turno()
        {
            id = 0;
            idJornada = 0;
            fecha = "";
        }
        public Turno(int id,
                     int idJornada, string fecha, string hora, string minuto)
        {
            this.id = id;
            this.idJornada = idJornada;
            this.fecha = fecha;
            this.Minuto = minuto;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Fecha { get { return fecha; } set { fecha = value; } }
        public int IdJornada { get => idJornada; set => idJornada = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Minuto { get => minuto; set => minuto = value; }
    }
}
