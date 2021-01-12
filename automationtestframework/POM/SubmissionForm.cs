using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace automationtestframework.POM {
    class SubmissionForm {
        IWebDriver driver;

        By firstNamField = By.CssSelector("[name='firstname']");
        By lastNameField = By.CssSelector("[name='lastname']");
        By maleRadioBtn = By.CssSelector("input[value='Male']");
        By twoYearsExpRadioBtn = By.CssSelector("input[value='2']");
        By dateInputField = By.XPath("//input[@id='datepicker']");
        By automationTesterCheckBox = By.Id("profession-1");
        By seleniumWebDriverCheckBox = By.XPath("//input[@value='Selenium Webdriver']");
        By continentDropDown = By.Id("continents");
        By seleniumCommands = By.XPath("//select[@id='selenium_commands']");
        By submitBtn = By.XPath("//button[@id='submit']");
        By okCookieAlert = By.XPath("//[@id='cookieChoiceDismiss']");
        By OkCookie = By.Id("cookieChoiceDismiss");

        public SubmissionForm (IWebDriver driver) {
            this.driver = driver;
            }

        public void InputFirstName() {
            driver.FindElement(firstNamField).SendKeys("kenny");
            }

        public void InputLastName() {
            driver.FindElement(lastNameField).SendKeys("Lofton");
            }

        public void SelectMaleRaidoBtn() {
            driver.FindElement(maleRadioBtn).Click();
            }

        public void SelectTwoYearsExp() {
            driver.FindElement(twoYearsExpRadioBtn).Click();
            }

        public void InputDate() {
            driver.FindElement(dateInputField).SendKeys("11/01/1970");
            }

        public void SelectAutomationTester() {
            Thread.Sleep(1000);
            driver.FindElement(OkCookie).Click();
            driver.FindElement(automationTesterCheckBox).Click();
            }

        public void SelectSelenumCheckBox() {
            driver.FindElement(seleniumWebDriverCheckBox).Click();
            }

        public void SelectContinent() {
            //driver.FindElement(continentDropDown);
            //SelectElement dropdown = new SelectElement(continentDropDown);
            }

        public void SelectSeleniumCommands() {
            //driver.FindElement(seleniumCommands);
            //SelectElement dropdown = new SelectElement(seleniumCommands);
            }

        public void SelectSubmitbtn() {
            driver.FindElement(submitBtn).Click();
            }
        }
    }
