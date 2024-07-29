﻿using ConsultorioPrivado.Controlador.Controlers;
using Controladores.Controlador.Controlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestProject
{
    [TestClass]
    public class TestObtenerEntidades
    {
        public TestObtenerEntidades() { 
        }

        [TestMethod]
        public void testObtenerMedico()
        {
            //Arrange
            ControladorMedico controladorMedico = new ControladorMedico();
            //Act
            DataTable actualDataTable = controladorMedico.ObtenerPorMedico();

            //Assert
            Assert.IsNotNull(actualDataTable);
        }

        [TestMethod]
        public void testObtenerPaciente()
        {
            //Arrange
            ControladorPaciente controladorPaciente = new ControladorPaciente();
            //Act
            DataTable actualDataTable = controladorPaciente.ObtenerPorPaciente();

            //Assert
            Assert.IsNotNull(actualDataTable);
        }

        [TestMethod]
        public void testObtenerCita()
        {
            //Arrange
            ControladorCita controladorCita = new ControladorCita();
            //Act
            DataTable actualDataTable = controladorCita.ObtenerPorCita();

            //Assert
            Assert.IsNotNull(actualDataTable);
        }

        [TestMethod]
        public void testObtenerTurno()
        {
            //Arrange
            ControladorTurno controladorTurno = new ControladorTurno();
            //Act
            DataTable actualDataTable = controladorTurno.ObtenerTurnos();

            //Assert
            Assert.IsNotNull(actualDataTable);
        }

    }
}