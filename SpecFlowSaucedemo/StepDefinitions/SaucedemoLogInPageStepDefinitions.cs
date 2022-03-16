using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTask;
using SeleniumTask.Methods;
using SeleniumTask.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlowSaucedemo.StepDefinitions
{
    [Binding]
    public class SaucedemoLogInPageStepDefinitions
    {
        private string? Username;
        private string? Password;
        private string? Message;
        private string? CorrectUsername;
        private string? CorrectPassword;
        [Given("I have navigated to Saucedemo web site")]
        public void NavigatedToSaucedemoWebSite()
        {
            SeleniumTask.WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            GetMethods.PageLoaded(SeleniumTask.WebDriver.driver.Url, "saucedemo");
        }
        [Given("I entered '(.*)' as Username")]
        public void EnteredUsername(string txt)
        {
            this.Username = txt;
            SetMethods.EnterText(SaucedemoLogInObjects.txtboxUsername, Username);
        }
        [Given("I entered '(.*)' as Password")]
        public void EnteredPassword(string txt)
        {
            this.Password = txt;

            SetMethods.EnterText(SaucedemoLogInObjects.txtboxPassword, Password);
        }
        [Given("I entered correct Username '(.*)'")]
        public void EnteredCorrectUsername(string txt)
        {
            this.CorrectUsername = txt;

            SetMethods.EnterText(SaucedemoLogInObjects.txtboxUsername, CorrectUsername);

        }
        [Given("I entered correct Password '(.*)'")]
        public void EnteredCorrectPassword(string txt)
        {
            this.CorrectPassword = txt;

            SetMethods.EnterText(SaucedemoLogInObjects.txtboxPassword, CorrectPassword);
        }
        [When("I submit LOGIN button")]
        public void SubmitLOGINButton()
        {

            SetMethods.Submit(SaucedemoLogInObjects.btnLogIn);
        }

        [Then("Login should fail with '(.*)'")]
        public void LoginFail(string txt)
        {
            this.Message = txt;

            string textMessage = GetMethods.GetText(SaucedemoLogInObjects.txtMessage);

            Assert.IsTrue(textMessage.Contains(Message));
            GetMethods.VerifyText(textMessage, Message);
        }
        [Then("I shuld be navigated to Inventory page")]
        public void InventoryPage()
        {
            GetMethods.PageLoaded(SeleniumTask.WebDriver.driver.Url, "inventory");
        }
    }
}
