using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using datos;
namespace UnitTestSistemaU
{
    [TestClass]
    public class ListarAlumno
    {
        public void TestMostraralumno()
        {
            AlumnoDatos instance = new AlumnoDatos();
            int esperado = 10;
            int resultado = instance.Mostraralumno("moran").Count;
            Assert.AreEqual(esperado, resultado);

        
        }
    }
}
