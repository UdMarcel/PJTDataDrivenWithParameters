using NUnit.Framework;
using PJTDataDrivenWithParameters.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PJTDataDrivenWithParameters.StepDefinitions
{
    [Binding]
    public class StepDefinitionsDataDriven
    {
        DataDrivenPageObject datadrivenPageObject;
        public StepDefinitionsDataDriven() 
        { 
            datadrivenPageObject = new DataDrivenPageObject();
        }
        [Given(@"I navigate to the wesbite ""([^""]*)""")]
        public void GivenINavigateToTheWesbite(string url)
        {
            datadrivenPageObject.NavigateToWebsite(url);
        }

        [Given(@"I Click on SignUp")]
        public void GivenIClickOnSignUp()
        {
            datadrivenPageObject.ClickOnSignUP();
        }

        [Given(@"I Enter my Username ""([^""]*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            //Thread.Sleep(5000);
            datadrivenPageObject.EnterUsername(username);
            
        }

        [Given(@"I Enter my email ""([^""]*)""")]
        public void GivenIEnterMyEmail(string email)
        {
            datadrivenPageObject.EnterEmail(email);
        }

        [Given(@"I Enter passowrd ""([^""]*)""")]
        public void GivenIEnterPassowrd(string password)
        {
            datadrivenPageObject.EnterPassword(password);
        }

        [When(@"I Click on the Sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            datadrivenPageObject.Enterlogin();
        }

        [Then(@"I Should be able to register succesfully")]
        public void ThenIShouldBeAbleToRegisterSuccesfully()
        {
            //Thread.Sleep(5000);
            Assert.That(datadrivenPageObject.IsNewArticleDisplayed);
        }
    }
}
