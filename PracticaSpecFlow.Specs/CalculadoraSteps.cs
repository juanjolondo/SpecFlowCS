using System;
using TechTalk.SpecFlow;
using ProCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticaSpecFlow.Specs
{
    [Binding]
    public class CalculadoraSteps
    {
        private Calculadora calculadora = new Calculadora();
        private int resultado;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numero1)
        {
            calculadora.PrimerNumero = numero1;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int numero2)
        {
            calculadora.SegundoNumero = numero2;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            resultado = calculadora.Sumar();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int resultadoEsperado)
        {
            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}
