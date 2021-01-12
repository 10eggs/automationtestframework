using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace automationtestframework.POM {
    class GeniusLoginPage 
        {
        IWebDriver driver;

        By alertAcceptBtn = By.Id("onetrust-accept-btn-handler");
        By signInBtn = By.XPath("//span[.='Sign In']");
        By loginInputField = By.XPath("//input[@id='user_session_login']");
        By passwordField = By.XPath("//input[@id='user_session_password']");
        By loginBtn = By.XPath("//input[@id='user_session_submit']");

        public GeniusLoginPage(IWebDriver driver) {
            this.driver = driver;
            }

        public void SelectAlertBtn() {
            driver.FindElement(alertAcceptBtn).Click();
            }

        public void SelectSigninBtn() {
            driver.FindElement(signInBtn).Click();
            }

        public void TypeUsername() {
            driver.FindElement(loginInputField).SendKeys("kennylofton315@gmail.com");
            }

        public void TypePassword() {
            driver.FindElement(passwordField).SendKeys("genius123");
            }

        public void SelectloginBtn() {
            driver.FindElement(loginBtn).Click();
            }

        }
    }
