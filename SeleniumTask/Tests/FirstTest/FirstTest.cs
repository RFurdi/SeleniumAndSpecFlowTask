using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTask.Methods;
using SeleniumTask.PageObjects;


namespace SeleniumTask
{
    public class FirstTest : Setup
    {
        [Test]
        public void ExecuteTest()
        {

            Console.WriteLine("Saucedemo LogIn Test");


            Console.WriteLine("Going to URL: 'https://www.saucedemo.com/'");
            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");


            Console.WriteLine("Maximizing Browser");
            WebDriver.driver.Manage().Window.Maximize();

            Console.WriteLine("Logging to web site");
            SaucedemoLogInObjects.LogIn("standard_user", "secret_sauce", "Robert", "Furdi");
        }
    }
}
