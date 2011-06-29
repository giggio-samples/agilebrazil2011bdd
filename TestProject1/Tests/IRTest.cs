using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Models;
using FluentAssertions;
using TestProject1.Tests.Support;
namespace TestProject1.Tests
{
    [TestClass]
    public abstract class IRTest : AAA
    {
        private CalculoIR ir;
        private decimal imposto;
        protected decimal SalarioAnual;
        protected decimal ValorEsperado;
        public override void Arrange()
        {
            ir = new CalculoIR(SalarioAnual);
        }
        public override void Act()
        {
            imposto = ir.Calcular();
        }
        [TestMethod]
        public void ValorEhOEsperado()
        {
            imposto.Should().Be(ValorEsperado);
        }
    }
}
