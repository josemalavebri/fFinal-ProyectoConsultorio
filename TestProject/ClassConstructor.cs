using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal static class ClassConstructor
    {
        private static Pacientes pacientes = new Pacientes();
        private static Medico medico = new Medico();


        public static Pacientes crearPacienteObj(int idPaciente)
        {
            pacientes.Id = idPaciente;
            pacientes.Edad = 0;
            pacientes.Cedula = 0;
            pacientes.Correo = "";
            pacientes.Nombre = "Prueba";
            pacientes.Apellido = "Prueba";
            return  pacientes;
        }


    }
}
