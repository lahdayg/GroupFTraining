using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProjectGroupF.PageObject;

namespace TestProjectGroupF.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage;

        public LoginSteps()
        {
            loginPage = new LoginPage();
        }






        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            loginPage.NavigateToWebsite();
        }
        
        [Given(@"I click on Sign up button")]
        public void GivenIClickOnSignUpButton()
        {
            loginPage.ClickOnSignUpButton();
        }
        
        [Given(@"I enter Username")]
        public void GivenIEnterUsername()
        {
            loginPage.EnterUserName();
        }
        
        [Given(@"I enter Email Address")]
        public void GivenIEnterEmailAddress()
        {
            loginPage.EnterEmail();
        }
        
        [Given(@"I enter Password")]
        public void GivenIEnterPassword()
        {
            Thread.Sleep(5000);
            loginPage.EnterPassword();
        }
        
        [When(@"I click on Sign Up button")]
        public void WhenIClickOnSignUpButton()
        {
            loginPage.ClickOnSignUp();
        }
        
        [Then(@"I should be able to sign up successfully on the website")]
        public void ThenIShouldBeAbleToSignUpSuccessfullyOnTheWebsite()
        {
            Thread.Sleep(5000);
            Assert.That(loginPage.IsGlobalFeedDisplayed);
        }

        [Given(@"I click on Sign in button")]
        public void GivenIClickOnSignInButton()
        {
            loginPage.ClickSignInButton();
        }

        [Given(@"I enter something that doesn`t make sense")]
        public void GivenIEnterSomethingThatDoesnTMakeSense()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
