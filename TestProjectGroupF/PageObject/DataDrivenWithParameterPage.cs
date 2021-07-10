using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupF.Utilities;

namespace TestProjectGroupF.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));

        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));

        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));



        public void EnterUserName(string UsernameText)
        {
            //Username.SendKeys(UsernameText);
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(UsernameText + randomInt);
        }

        public void EnterEmail(string EmailText)
        {
            //Email.SendKeys(EmailText);
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(EmailText + randomInt + "@gmail.com");
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterPassword(string PasswordText)
        {
            Password.SendKeys(PasswordText);
        }






    }
}
