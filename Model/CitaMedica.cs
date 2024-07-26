using ConsultorioPrivado.Vista.Cita_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CitaMedica : IEntidad
    {
        private int id;
        private string descripcion;
        private int idPaciente;
        private int idMedicoTurno;

        public CitaMedica()
        {
            id = 0;
            Descripcion = string.Empty;
            IdPaciente = 0;
            IdMedicoTurno = 0;

        }

        public CitaMedica(int id, string descripcion, int idPaciente, int idMedicoTurno)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.idPaciente = idPaciente;
            this.idMedicoTurno = idMedicoTurno;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdMedicoTurno { get => idMedicoTurno; set => idMedicoTurno = value; }
    }

}
