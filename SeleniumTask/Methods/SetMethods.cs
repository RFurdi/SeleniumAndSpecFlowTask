using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            }
            catch (Exception)
            {
                throw new Exception("Text is not entered");
            }
        }
        public static void Click(IWebElement element)
        {
            try
            {
                element.Click();
                Console.WriteLine("Clicked");
                
            }
            catch (Exception)
            {
               
                throw new Exception("Not clicked");
            }
        }
        public static void Submit(IWebElement element)
        {
            try
            {
                element.Submit();
                Console.WriteLine("Submited");
                
            }
            catch (Exception)
            {
               
                throw new Exception("Not submited");
            }
        }
        public static void Clear(IWebElement element)
        {
            try
            {
                element.SendKeys(Keys.LeftControl + Keys.Backspace);
                Console.WriteLine("Cleared");
                
            }
            catch (Exception)
            {
                
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
               
            }
            catch (Exception)
            {
              
                throw new Exception("Texbox is not empty");
            }
        }
        public static void Enabled(IWebElement element)
        {
            try
            {
                Assert.IsTrue(element.Enabled);
                Console.WriteLine("Enabled");
            
            }
            catch (Exception)
            {
              
                throw new Exception("Not enabled");
            }
        }
        public static void Displayed(IWebElement element)
        {
            try
            {
                Assert.IsTrue(element.Displayed);
                Console.WriteLine("Displayed");
           
            }
            catch (Exception)
            {
               
                throw new Exception("Not displayed");
            }
        }
        public static void Start(string stepname, string stepnumber)
        {
            Console.WriteLine("\nStep {0} - {1}\n", stepnumber, stepname);
            
        }
        public static void Hidden(IWebElement element)
        {
            try
            {
                
                string hidden = element.GetAttribute("tabindex");
                if (hidden == "-1")
                {
                    Console.WriteLine("Shown.");
                   
                    
                }
                else
                {
                    Console.WriteLine("Hidden.");
                   
                    
                }

            }
            catch (Exception ex)
            {
               
                throw new Exception(String.Format("Displayed! {0}", ex.StackTrace));
            }
        }


    }
}
