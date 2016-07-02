﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComoUnProcedimiento;

namespace ComoUnProcedimiento_Tests
{
    [TestClass]
    public class NumeroDeCuentaIBAN_Tests
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
    }
}