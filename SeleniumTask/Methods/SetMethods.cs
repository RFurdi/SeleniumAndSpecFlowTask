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
                Console.WriteLine(String.Format("{0} is entered", value, nameof(element)));
                Logger.logger.Debug(String.Format("{0} is entered", value, nameof(element)));
            }
            catch (Exception ex)
            {
                Logger.logger.Error(String.Format("{0} is not entered", value, nameof(element)));
                throw new Exception(String.Format("{0} is not entered", ex.StackTrace));
            }
        }
        public static void Click(IWebElement element)
        {
            try
            {
                element.Click();
                Console.WriteLine(String.Format("{0} is clicked", nameof(element)));
                Logger.logger.Debug(String.Format("{0} is clicked", nameof(element)));
            }
            catch (Exception ex)
            {
                Logger.logger.Error(String.Format("{0} is not clicked", nameof(element)));
                throw new Exception(String.Format("{0} is not clicked", ex.StackTrace));
            }
        }
        public static void Submit(IWebElement element)
        {
            try
            {
                element.Submit();
                Console.WriteLine(String.Format("{0} is submited", nameof(element)));
                Logger.logger.Debug(String.Format("{0} is submited", nameof(element)));
            }
            catch (Exception ex)
            {
                Logger.logger.Error(String.Format("{0} is not submited", nameof(element)));
                throw new Exception(String.Format("{0} is not submited", ex.StackTrace));
            }
        }
        public static void Clear(IWebElement element)
        {
            try
            {
                element.SendKeys(Keys.LeftControl + Keys.Backspace);
                Console.WriteLine(String.Format("{0} is cleared", nameof(element)));
                Logger.logger.Debug(String.Format("{0} is cleared", nameof(element)));
            }
            catch (Exception ex)
            {
                Logger.logger.Error(String.Format("{0} is not cleared", nameof(element)));
                throw new Exception(String.Format("{0} is not cleared", ex.StackTrace));
            }

        }
        public static void Empty(IWebElement element)
        {
            string text = element.GetAttribute("value");
            try
            {
                Assert.IsEmpty(text);
                Console.WriteLine(String.Format("{0} is empty", nameof(element)));
                Logger.logger.Debug(String.Format("{0} is empty", nameof(element)));
            }
            catch (Exception ex)
            {
                Logger.logger.Error(String.Format("{0} is not empty", nameof(element)));
                throw new Exception(String.Format("{0} is not empty", ex.StackTrace));
            }
        }
        public static void Enabled(IWebElement element)
        {
            try
            {
                Assert.IsTrue(element.Enabled);
                Console.WriteLine(String.Format("{0} is enabled", nameof(element)));
                Logger.logger.Debug(String.Format("{0} is enabled", nameof(element)));
            }
            catch (Exception ex)
            {
                Logger.logger.Error(String.Format("{0} is  not enabled", nameof(element)));
                throw new Exception(String.Format("{0} is  not enabled", ex.StackTrace));
            }
        }
        public static void Displayed(IWebElement element)
        {
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine(String.Format("{0} is displayed", nameof(element)));
                Logger.logger.Debug(String.Format("{0} is displayed", nameof(element)));
            }
            catch (Exception ex)
            {
                Logger.logger.Error(String.Format("{0} is  not displayed", nameof(element)));
                throw new Exception(String.Format("{0} is  not displayed", ex.StackTrace));
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
                    Console.WriteLine(String.Format("{0} is shown.", nameof(element)));
                    Logger.logger.Debug(String.Format("{0} is shown", nameof(element)));
                    
                }
                else
                {
                    Console.WriteLine(String.Format("{0} is hidden.", nameof(element)));
                    Logger.logger.Debug(String.Format("{0} is hidden", nameof(element)));
                    
                }

            }
            catch (Exception e)
            {
                Logger.logger.Error(String.Format("{0} is displayed", nameof(element)));
                throw new Exception(String.Format("Element is displayed! {0}", e.StackTrace));
            }
        }


    }
}
