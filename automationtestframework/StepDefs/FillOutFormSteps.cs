using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace automationtestframework.POM
{
    [Binding]
    public class FillOutFormSteps {
        IWebDriver driver = new ChromeDriver();


        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite() {
            SubmissionForm submissionForm = new SubmissionForm(driver);
            driver.Navigate().GoToUrl("https://www.techlistic.com/p/selenium-practice-form.html");
            driver.Manage().Window.Maximize();
            }

        [Given(@"i enter my first name in the first name field")]
        public void GivenIEnterMyFirstNameInTheFirstNameField() {
            SubmissionForm submissionForm = new SubmissionForm(driver);
            submissionForm.InputFirstName();
            }

        [Given(@"I input my name in the last name field")]
        public void GivenIInputMyNameInTheLastNameField() {
            SubmissionForm submissionForm = new SubmissionForm(driver);
            submissionForm.InputLastName();
            }

        [Given(@"I select the gender option of male")]
        public void GivenISelectTheGenderOptionOfMale() {
            SubmissionForm submissionForm = new SubmissionForm(driver);
            submissionForm.SelectMaleRaidoBtn();
            }

        [Given(@"I select (.*) years of experience")]
        public void GivenISelectYearsOfExperience(int p0) {
            SubmissionForm submissionForm = new SubmissionForm(driver);
            submissionForm.SelectTwoYearsExp();
            }

        [Given(@"I input a relevant date")]
        public void GivenIInputARelevantDate() {
            SubmissionForm submissionForm = new SubmissionForm(driver);
            submissionForm.InputDate();
            }

        [Given(@"I select the Manual tester checkbox under the profession option")]
        public void GivenISelectTheManualTesterCheckboxUnderTheProfessionOption() {
            SubmissionForm submissionForm = new SubmissionForm(driver);
            submissionForm.SelectAutomationTester();
            }

        [Given(@"I select the selenium webdriver option under the automation tools")]
        public void GivenISelectTheSeleniumWebdriverOptionUnderTheAutomationTools() {
            SubmissionForm submissionForm = new SubmissionForm(driver);
            submissionForm.SelectSelenumCheckBox();
            }

        [Given(@"I select the continents dropdown to select the option of Europe")]
        public void GivenISelectTheContinentsDropdownToSelectTheOptionOfEurope() {
            IWebElement continentDropDown = driver.FindElement(By.Id("continents"));
            OpenQA.Selenium.Support.UI.SelectElement dropDown = new SelectElement(continentDropDown);
            dropDown.SelectByIndex(1);
            }

        [Given(@"I select the option of browser commands under the selenium commands heading")]
        public void GivenISelectTheOptionOfBrowserCommandsUnderTheSeleniumCommandsHeading() {
            IWebElement seleniumCommands = driver.FindElement(By.XPath("//select[@id='selenium_commands']"));
            SelectElement dropdown = new SelectElement(seleniumCommands);
            dropdown.SelectByIndex(0);
            }

        [Given(@"I select the submit button")]
        public void GivenISelectTheSubmitButton() {
            SubmissionForm submissionForm = new SubmissionForm(driver);
            submissionForm.SelectSubmitbtn();
            driver.Quit();
            }
        }
    }
