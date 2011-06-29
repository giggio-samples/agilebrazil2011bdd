using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Models;
using TestProject1.Tests.Support;
namespace TestProject1.Tests
{
    [TestClass]
    public class IRSalarioZero : AAA
    {
        private CalculoIR ir;
        private decimal imposto;
        public override void Arrange()
        {
            ir = new CalculoIR(0);
        }
        public override void Act()
        {
            imposto = ir.Calcular();
        }
        [TestMethod]
        public void ValorEhOEsperado()
        {
            imposto.Should().Be(0m);
        }
    }
}
