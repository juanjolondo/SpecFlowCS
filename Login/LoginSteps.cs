using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases;

namespace Login
{
    [Binding]
    public class LoginSteps
    {
        private Cuenta c = new Cuenta();
        private String ruta;

        [Given(@"I have entered (.*) into the username space")]
        public void GivenIHaveEnteredIntoTheUsernameSpace(String user)
        {
            c.usuario = user;
        }
        
        [Given(@"I have also entered (.*) into the password space")]
        public void GivenIHaveAlsoEnteredPassIntoThePasswordSpace(String pas)
        {
            c.contrasena = pas;
        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            ruta = c.validar();
        }
        
        [Then(@"It should change to (.*) page")]
        public void ThenItShouldChangeToFormPage(String expectedRuta)
        {
            Assert.AreEqual(expectedRuta, ruta);
        }
    }
}
