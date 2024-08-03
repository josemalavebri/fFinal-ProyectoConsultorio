using ConsultorioPrivado.Controlador.Controlers;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    // TESTEA LA INSERCION DATOS EN LA BASE DE DATOS 
    [TestClass]
    public class TestInsertEntidad
    {
        private int idPaciente = 25;

        [TestMethod]
        public void insertEntidadPaciente()
        {
            Pacientes paciente = ClassConstructor.crearPacienteObj(idPaciente);
            ControladorPaciente controlador = new ControladorPaciente();
            var boolPaciente = controlador.CrearPaciente(paciente);
            Assert.IsTrue(boolPaciente);
        }

        [TestMethod]
        public void actualizarEntidadPaciente()
        {
            int idPaciente = 1;
            Pacientes paciente = ClassConstructor.crearPacienteObj(idPaciente);
            ControladorPaciente controlador = new ControladorPaciente();
            var boolPaciente = controlador.ActualizarPaciente(paciente);
            Assert.IsTrue(boolPaciente);
        }

        [TestMethod]
        public void eliminarEntidadPaciente()
        {
            int idPaciente = 1;
            Pacientes paciente = ClassConstructor.crearPacienteObj(idPaciente);
            ControladorPaciente controlador = new ControladorPaciente();
            var boolPaciente = controlador.EliminarPaciente(paciente);
            Assert.IsTrue(boolPaciente);
        }

    }
}
