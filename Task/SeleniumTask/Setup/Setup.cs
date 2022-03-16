using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTask
{
    public class Setup
    {
        [SetUp]
        public static void Initialize()
        {
            WebDriver.driver = new EdgeDriver(@"C:\Users\rober\OneDrive - ahqb\Desktop\edgedriver_win64");
        }
        [TearDown]
        public static void CleanUp()
        {
            WebDriver.driver.Close();
            Console.WriteLine("Browser closed!");
        }

    }
}
