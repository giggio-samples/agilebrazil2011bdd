using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1.Tests
{
    [TestClass]
    public class IRSalario2aFaixa : IRTest
    {
        public IRSalario2aFaixa()
        {
            SalarioAnual = 2500m;
            ValorEsperado = 94.06m;
        }
    }
}
