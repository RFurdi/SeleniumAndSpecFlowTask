using NUnit.Framework;
using System;
using SeleniumTask.Log;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumTask.Methods
{
    public static class GetMethods
    {
        public static string GetValue(IWebElement element)
        {
            return element.GetAttribute("value");
        }
        public static string GetText(IWebElement element)
        {
            return element.Text;
        }
        public static void PageLoaded(string URL, string condition)
        {
            try
            {
                Assert.IsTrue(URL.Contains(condition), condition);
                Console.WriteLine("Correct page loaded");
                Logger.logger.Debug("Correct page loaded");

            }
            catch (Exception ex)
            {
                Logger.logger.Error("Wrong page loaded");
                throw new Exception(String.Format("Wrong page loaded", ex.StackTrace));
            }


        }
        public static void VerifyText(string text, string condition)
        {
            try
            {
                StringAssert.Contains(condition, text);
                Console.WriteLine("{0} is displayed", text);
                Logger.logger.Debug(String.Format("{0} is displayed", text));
            }
            catch (Exception ex)
            {
                Logger.logger.Error(String.Format("{0} wrong text", text));
                throw new Exception(String.Format("{0} wrong text", ex.StackTrace));
            }

        }
        public static void VerifyProduct(IWebElement element, string productinfo)
        {

            try
            {
                IList<IWebElement> products = element.FindElements(By.ClassName("inventory_item"));

                foreach (IWebElement product in products)
                {
                    string text = product.Text.Replace("\r", string.Empty);

                    if (text.Contains(productinfo))
                    {
                        Console.WriteLine(String.Format("Is displayed", productinfo));
                        Logger.logger.Debug(String.Format("Is displayed", productinfo));
                        return;
                    }

                }
                Console.WriteLine(String.Format("Does not exist!", productinfo));
                Logger.logger.Debug(String.Format("Does not exist", productinfo));
            }
            catch (Exception ex)
            {
                Logger.logger.Error(String.Format("No elements in container"));
                throw new Exception(String.Format("No elements in container!", ex.StackTrace));

            }
        }
    }
}
