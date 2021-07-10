using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupF.Utilities;

namespace TestProjectGroupF.PageObject
{
    class LoginPage
    {
        public LoginPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("(//a[@class='nav-link'])[2]"));

        IWebElement Username => driver.FindElement(By.CssSelector("body > div.ng-scope > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));

        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));

        IWebElement SignIn => driver.FindElement(By.XPath("(//a[@class='nav-link'])[1]"));

        //IWebElement Example => driver.FindElement(By.Id("ember761"));

        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));

        IWebElement SignUpButton => driver.FindElement(By.CssSelector("body > div.ng-scope > div > div > div > div > div > form > fieldset > button"));

        IWebElement GlobalFeed => driver.FindElement(By.XPath("(//a[@class='nav-link'])[5]"));



        public void ClickOnSignUpButton()
        {
            SignUp.Click();
        }

        public void EnterUserName()
        {
            Username.SendKeys("Anthony12345");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void EnterEmail()
        {
            Email.SendKeys("anthony123@demo.com");
        }

        public void ClickSignInButton()
        {
            SignIn.Click();
        }

        public void EnterPassword()
        {
            Password.SendKeys("PasswordSecure");
        }

        public void ClickOnSignUp()
        {
            SignUpButton.Click();
        }

        public bool IsGlobalFeedDisplayed()
        {
            return GlobalFeed.Displayed;
        }








    }
}
