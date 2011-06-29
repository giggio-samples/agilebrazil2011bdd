using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1.Tests
{
    [TestClass]
    public class IRSalario3aFaixa : IRTest
    {
        public IRSalario3aFaixa()
        {
            SalarioAnual = 3000m;
            ValorEsperado = 169.38m;
        }
    }
}
