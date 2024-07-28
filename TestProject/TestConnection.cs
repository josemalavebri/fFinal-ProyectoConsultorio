using ConsultorioPrivado.Datos;
using Controller.Datos.DbOperaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TestConnection
    {
        public TestConnection() { }
        
        [TestMethod]
        public void TestConnectionOpen() { 
            TestingConexionDB db = new TestingConexionDB();

            Assert.IsTrue(db.returnConnectionOpen());

        }

        [TestMethod]
        public void TestConnectionClosed()
        {
            TestingConexionDB db = new TestingConexionDB();

            Assert.IsTrue(db.returnConnectionOpen());

        }
    }
}
