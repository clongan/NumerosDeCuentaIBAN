using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConFunciones;

namespace ConFunciones_Tests
{
    [TestClass]
    public class ConFunciones_NumeroDeCuentaIBAN_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void CalcularNumeroDeCuentaIBAN_VerificadorMayorADiez_NoPrecedeConCero()
        {
            elResultadoEsperado = "CR1010200009007408120";
            elResultadoObtenido = NumeroDeCuentaIBAN.CalcularNumeroDeCuentaIBAN("10200009007408120");
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
        [TestMethod]
        public void CalcularNumeroDeCuentaIBAN_VerificadorMenorADiez_PrecedeConCero()
        {
            elResultadoEsperado = "CR0910000073919007800";
            elResultadoObtenido = NumeroDeCuentaIBAN.CalcularNumeroDeCuentaIBAN("10000073919007800");
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
