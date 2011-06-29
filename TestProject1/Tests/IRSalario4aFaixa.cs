using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1.Tests
{
    [TestClass]
    public class IRSalario4aFaixa : IRTest
    {
        public IRSalario4aFaixa()
        {
            SalarioAnual = 4000m;
            ValorEsperado = 407.22m;
        }
    }
}
