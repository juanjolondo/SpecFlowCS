using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases;

namespace Login
{
    [Binding]
    public class FormSteps
    {
        private Form form = new Form();
        private String result;

        [Given(@"I have entered (.*) into the name space")]
        public void GivenIHaveEnteredJuanitoIntoTheNameSpace(String name)
        {
            form.name = name;
        }
        
        [Given(@"I have entered (.*) into the last name space")]
        public void GivenIHaveEnteredAlimanaIntoTheLastNameSpace(String lastName)
        {
            form.lastName = lastName;
        }
        
        [Given(@"I have also entered (.*) into the age space")]
        public void GivenIHaveAlsoEnteredIntoTheAgeSpace(int age)
        {
            form.age = age;
        }
        
        [When(@"I press send")]
        public void WhenIPressSend()
        {
            result = form.send();
        }
        
        [Then(@"It should show (.*) on the screen")]
        public void ThenItShouldShowCorrectOnTheScreen(String expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
