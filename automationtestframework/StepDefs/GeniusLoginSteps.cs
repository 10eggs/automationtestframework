using automationtestframework.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace automationtestframework.StepDefs
{

    [Binding]
    public class GeniusLoginSteps
    {
        IWebDriver driver = new ChromeDriver();
        //GeniusLoginPage geniusLogin = new GeniusLoginPage(driver);
        //GeniusLoginPage geniusLogin = new GeniusLoginPage();

        public GeniusLoginSteps() 
            {
            GeniusLoginPage geniusLogin = new GeniusLoginPage(driver);
            }
        

        [Given(@"I am on the genius homepage")]
        public void GivenIAmOnTheGeniusHomepage()
        {
            GeniusLoginPage geniusLogin = new GeniusLoginPage(driver);
            driver.Navigate().GoToUrl("https://genius.com/");
            driver.Manage().Window.Maximize();
            geniusLogin.SelectAlertBtn();
            }
        
        [Given(@"I select the sign in button")]
        public void GivenISelectTheSignInButton()
        {
            GeniusLoginPage geniusLogin = new GeniusLoginPage(driver);
            geniusLogin.SelectSigninBtn();
            }
        
        [Given(@"I input my genius login")]
        public void GivenIInputMyGeniusLogin()
        {
            GeniusLoginPage geniusLogin = new GeniusLoginPage(driver);
            geniusLogin.TypeUsername();
            }
        
        [Given(@"I input my genius password")]
        public void GivenIInputMyGeniusPassword()
        {
            GeniusLoginPage geniusLogin = new GeniusLoginPage(driver);
            geniusLogin.TypePassword();
            }
        
        [When(@"i select the login button")]
        public void WhenISelectTheLoginButton()
        {
            GeniusLoginPage geniusLogin = new GeniusLoginPage(driver);
            geniusLogin.SelectloginBtn();
            }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            GeniusLoginPage geniusLogin = new GeniusLoginPage(driver);
            driver.Quit();
            }
    }
}
