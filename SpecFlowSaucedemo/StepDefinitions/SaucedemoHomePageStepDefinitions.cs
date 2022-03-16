using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SeleniumTask.Methods;
using SeleniumTask.PageObjects;

namespace SpecFlowSaucedemo.StepDefinitions
{
    [Binding]
    public class SaucedemoHomePageStepDefinitions
    {
        [Given("I Logged in page")]
        public void ILoggedInPage()
        {
            SeleniumTask.WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            GetMethods.PageLoaded(SeleniumTask.WebDriver.driver.Url, "saucedemo");
            SetMethods.EnterText(SaucedemoLogInObjects.txtboxUsername, "standard_user");
            SetMethods.EnterText(SaucedemoLogInObjects.txtboxPassword, "secret_sauce");
            SetMethods.Submit(SaucedemoLogInObjects.btnLogIn);
            GetMethods.PageLoaded(SeleniumTask.WebDriver.driver.Url, "inventory");
        }
        [When("I click Menu button")]
        public void ClickMenuButton()
        {
            SetMethods.Click(SaucedemoHomePageObjects.btnMenu);
        }
        [Then("Menu has been displayed")]
        public void MenuHasBeenDisplayed()
        {
            SetMethods.Hidden(SaucedemoHomePageObjects.btnX);
        }
        [Given("I add Sauce Labs Bike Light to Cart")]
        public void AddSauceLabsBikeLightToCart()
        {
            SetMethods.Click(SaucedemoHomePageObjects.btnAddtocart);
        }
        [Then("I navigated to Cart page")]
        public void NavigatedToCartPage()
        {
            SetMethods.Click(SaucedemoHomePageObjects.btnCart);
            GetMethods.PageLoaded(SeleniumTask.WebDriver.driver.Url, "cart");
        }
    }
}
