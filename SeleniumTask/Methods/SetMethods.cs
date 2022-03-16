using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTask.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTask.Methods
{
    public class SetMethods
    {
        public static void EnterText(IWebElement element, string value)
        {
            try
            {
                element.SendKeys(value);
                Console.WriteLine("Text is entered");
                Logger.logger.Debug("Text is entered");
            }
            catch (Exception)
            {
                Logger.logger.Error("Text is not entered");
                throw new Exception("Text is not entered");
            }
        }
        public static void Click(IWebElement element)
        {
            try
            {
                element.Click();
                Console.WriteLine("Clicked");
                Logger.logger.Debug("Clicked");
            }
            catch (Exception)
            {
                Logger.logger.Error("Not clicked");
                throw new Exception("Not clicked");
            }
        }
        public static void Submit(IWebElement element)
        {
            try
            {
                element.Submit();
                Console.WriteLine("Submited");
                Logger.logger.Debug("Submited");
            }
            catch (Exception)
            {
                Logger.logger.Error("Not submited");
                throw new Exception("Not submited");
            }
        }
        public static void Clear(IWebElement element)
        {
            try
            {
                element.SendKeys(Keys.LeftControl + Keys.Backspace);
                Console.WriteLine("Cleared");
                Logger.logger.Debug("Cleared");
            }
            catch (Exception)
            {
                Logger.logger.Error("Not cleared");
                throw new Exception("Not cleared");
            }

        }
        public static void Empty(IWebElement element)
        {
            string text = element.GetAttribute("value");
            try
            {
                Assert.IsEmpty(text);
                Console.WriteLine("Textbox is empty");
                Logger.logger.Debug("Textbox is empty");
            }
            catch (Exception ex)
            {
                Logger.logger.Error("Textbox is not empty");
                throw new Exception("Texbox is not empty");
            }
        }
        public static void Enabled(IWebElement element)
        {
            try
            {
                Assert.IsTrue(element.Enabled);
                Console.WriteLine("Enabled");
                Logger.logger.Debug("Enabled");
            }
            catch (Exception)
            {
                Logger.logger.Error("Not enabled");
                throw new Exception("Not enabled");
            }
        }
        public static void Displayed(IWebElement element)
        {
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Displayed");
                Logger.logger.Debug("Displayed");
            }
            catch (Exception)
            {
                Logger.logger.Error("Not displayed");
                throw new Exception("Not displayed");
            }
        }
        public static void Start(string stepname, string stepnumber)
        {
            Console.WriteLine("\nStep {0} - {1}\n", stepnumber, stepname);
            Logger.logger.Debug(String.Format("Step {0} - {1}\n", stepnumber, stepname));
        }
        public static void Hidden(IWebElement element)
        {
            try
            {
                
                string hidden = element.GetAttribute("tabindex");
                if (hidden == "-1")
                {
                    Console.WriteLine("Shown.");
                    Logger.logger.Debug("Shown");
                    
                }
                else
                {
                    Console.WriteLine("Hidden.");
                    Logger.logger.Debug("Hidden");
                    
                }

            }
            catch (Exception ex)
            {
                Logger.logger.Error("Displayed");
                throw new Exception(String.Format("Displayed! {0}", ex.StackTrace));
            }
        }


    }
}
