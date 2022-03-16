using NUnit.Framework;
using System;
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
                

            }
            catch (Exception ex)
            {
                
                throw new Exception(String.Format("Wrong page loaded", ex.StackTrace));
            }


        }
        public static void VerifyText(string text, string condition)
        {
            try
            {
                StringAssert.Contains(condition, text);
                Console.WriteLine("{0} is displayed", text);
                
            }
            catch (Exception ex)
            {
                
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
                        
                        return;
                    }

                }
                Console.WriteLine(String.Format("Does not exist!", productinfo));
                
            }
            catch (Exception ex)
            {
                
                throw new Exception(String.Format("No elements in container!", ex.StackTrace));

            }
        }
    }
}
