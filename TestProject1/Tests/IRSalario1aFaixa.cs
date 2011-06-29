using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1.Tests
{
    [TestClass]
    public class IRSalario1aFaixa : IRTest
    {
        public IRSalario1aFaixa()
        {
            SalarioAnual = 2000m;
            ValorEsperado = 37.57m;
        }
    }
}
