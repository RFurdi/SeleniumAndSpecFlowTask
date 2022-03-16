using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTask.PageObjects;


namespace SeleniumTask.Tests.SecondTest
{
    public class SecondTest : Setup
    {
        [Test]
        public void ExecuteTest()
        {
            
            Console.WriteLine("Saucedemo Home Page Test");

            Console.WriteLine("Going to URL: 'https://www.saucedemo.com/'");
            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");


            Console.WriteLine("Maximizing Browser");
            WebDriver.driver.Manage().Window.Maximize();

            Console.WriteLine("Logging to web site");
            SaucedemoLogInObjects.LogIn("standard_user", "secret_sauce", "Robert", "Furdi");

            Console.WriteLine("Adding products to cart");
            SaucedemoHomePageObjects.HomePage();
        }

    }
}
