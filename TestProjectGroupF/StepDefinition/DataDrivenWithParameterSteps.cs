using System;
using TechTalk.SpecFlow;
using TestProjectGroupF.PageObject;

namespace TestProjectGroupF.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {

        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }




        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);

        }
        
        [Given(@"I enter Username ""(.*)""")]
        public void GivenIEnterUsername(string UsernameText)
        {
            dataDrivenWithParameterPage.EnterUserName(UsernameText);
        }
        
        [Given(@"I enter Email Address ""(.*)""")]
        public void GivenIEnterEmailAddress(string EmailText)
        {
            dataDrivenWithParameterPage.EnterEmail(EmailText);
        }
        
        [Given(@"I enter Password ""(.*)""")]
        public void GivenIEnterPassword(string PasswordText)
        {
            dataDrivenWithParameterPage.EnterPassword(PasswordText);
        }
    }
}
