using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTask.Methods;
using SeleniumTask.PageObjects;
using SeleniumTask.Log;


namespace SeleniumTask
{
    public class FirstTest : Setup
    {
        [Test]
        public void ExecuteTest()
        {
            Logger.LoggerRun();
            Logger.logger.Info("Saucedemo Test");

            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Logger.logger.Debug("Going to URL: 'https://www.saucedemo.com/'");

            Logger.logger.Debug("Maximizing Browser");
            WebDriver.driver.Manage().Window.Maximize();

            Logger.logger.Debug("Logging to web site");
            SaucedemoLogInObjects.LogIn("standard_user", "secret_sauce", "Robert", "Furdi");

            Logger.logger.Debug("Exit browser");

        }
    }
}
