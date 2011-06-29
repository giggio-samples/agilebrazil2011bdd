using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WatiN.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using WatiN.Extensions;
using TestProject1.Features.Support;
namespace TestProject1.Features.StepDefinitions
{
    [Binding]
    public class IRSteps
    {
        [Given(@"um contribuinte que ganha (\d+\.?\d+) reais por mês")]
        public void DadoUmContribuinteQueGanhaXReaisPorMes(string reais)
        {
            UI.Browser.GoTo("http://localhost:32001/IR");
            UI.Browser.SetText("Salario", reais);
        }

        [When(@"ele solicita o cálculo do IR")]
        public void QuandoEleSolicitaOCalculoDoIR()
        {
            UI.Browser.Click<Button>("Calcule");
        }

        [Then(@"ele deve confirmar que vai pagar (\d+\.?\d+) reais")]
        public void EntaoEleDeveConfirmarQueVaiPagarXReais(string reais)
        {
            UI.Browser.Get<Span>("Resultado").Text.Should().Be(reais);
        }

    }
}
