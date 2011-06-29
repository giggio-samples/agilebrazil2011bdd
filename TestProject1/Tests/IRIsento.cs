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
    public class IRIsento : IRTest
    {
        public IRIsento()
        {
            SalarioAnual = 0m;
            ValorEsperado = 0m;
        }
    }
}
