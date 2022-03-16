using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTask.Methods;

namespace SeleniumTask.PageObjects
{

    public static class SaucedemoLogInObjects
    {

        public static IWebElement txtboxUsername => WebDriver.driver.FindElement(By.Name("user-name"));
        public static IWebElement txtboxPassword => WebDriver.driver.FindElement(By.Name("password"));
        public static IWebElement txtUsername => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[2]/div/div[1]"));
        public static IWebElement txtPassword => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[2]/div/div[2]"));
        public static IWebElement btnLogIn => WebDriver.driver.FindElement(By.Name("login-button"));
        public static IWebElement btnX => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[3]/h3/button"));
        public static IWebElement txtMessage => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[3]"));

        public static void LogIn(string correctusername, string correctpassword, string incorrectusername, string incorrectpassword)
        {
            try
            {
                SetMethods.Start("Loads web page:https://www.saucedemo.com/", "1");
                GetMethods.PageLoaded(WebDriver.driver.Url, "saucedemo");
                Console.WriteLine("Username text box:");
                SetMethods.Displayed(txtboxUsername);
                SetMethods.Enabled(txtboxUsername);
                SetMethods.Empty(txtboxUsername);
                Console.WriteLine("Password tex box:");
                SetMethods.Displayed(txtboxPassword);
                SetMethods.Enabled(txtboxPassword);
                SetMethods.Empty(txtboxPassword);
                Console.WriteLine("LOGIN button:");
                SetMethods.Displayed(btnLogIn);
                SetMethods.Enabled(btnLogIn);

                string Usernames = GetMethods.GetText(txtUsername).Replace("\r", string.Empty);
                GetMethods.VerifyText(Usernames, "Accepted usernames are:\nstandard_user\nlocked_out_user\nproblem_user\nperformance_glitch_user");


                string Password = GetMethods.GetText(txtPassword).Replace("\r", string.Empty);
                GetMethods.VerifyText(Password, "Password for all users:\nsecret_sauce");

                SetMethods.Start("Submit LOGIN button", "2");
                SetMethods.Submit(btnLogIn);
                Console.WriteLine("X button:");
                SetMethods.Displayed(btnX);
                SetMethods.Enabled(btnX);
                string message = GetMethods.GetText(txtMessage);
                GetMethods.VerifyText(message, "Epic sadface: Username is required");

                SetMethods.Start("Enter incorrect username", "3");
                SetMethods.EnterText(txtboxUsername, incorrectusername);
                string enteredtext = GetMethods.GetValue(txtboxUsername);
                GetMethods.VerifyText(enteredtext, incorrectusername);

                SetMethods.Start("Submit LOGIN button", "4");
                SetMethods.Submit(btnLogIn);
                Console.WriteLine("X button:");
                SetMethods.Displayed(btnX);
                SetMethods.Enabled(btnX);
                message = GetMethods.GetText(txtMessage);
                GetMethods.VerifyText(message, "Epic sadface: Password is required");

                SetMethods.Start("Clear username textbox.", "5");
                SetMethods.Clear(txtboxUsername);
                SetMethods.Empty(txtboxUsername);

                SetMethods.Start("Enter incorrect password", "6");
                SetMethods.EnterText(txtboxPassword, incorrectpassword);
                enteredtext = GetMethods.GetValue(txtboxPassword);
                GetMethods.VerifyText(enteredtext, incorrectpassword);

                SetMethods.Start("Submit LOGIN button", "7");
                SetMethods.Submit(btnLogIn);
                Console.WriteLine("X button:");
                SetMethods.Displayed(btnX);
                SetMethods.Enabled(btnX);
                message = GetMethods.GetText(txtMessage);
                GetMethods.VerifyText(message, "Epic sadface: Username is required");

                SetMethods.Start("Clear password textbox.", "8");
                SetMethods.Clear(txtboxPassword);
                SetMethods.Empty(txtboxPassword);

                SetMethods.Start("Enter incorrect username and incorrect password", "9");
                SetMethods.EnterText(txtboxUsername, incorrectusername);
                SetMethods.EnterText(txtboxPassword, incorrectpassword);
                enteredtext = GetMethods.GetValue(txtboxUsername);
                GetMethods.VerifyText(enteredtext, incorrectusername);
                enteredtext = GetMethods.GetValue(txtboxPassword);
                GetMethods.VerifyText(enteredtext, incorrectpassword);

                SetMethods.Start("Submit LOGIN button", "10");
                SetMethods.Submit(btnLogIn);
                Console.WriteLine("X button:");
                SetMethods.Displayed(btnX);
                SetMethods.Enabled(btnX);
                message = GetMethods.GetText(txtMessage);
                GetMethods.VerifyText(message, "Epic sadface: Username and password do not match any user in this service");

                SetMethods.Start("Clear username and password textboxes.", "11");
                SetMethods.Clear(txtboxUsername);
                SetMethods.Clear(txtboxPassword);
                SetMethods.Empty(txtboxUsername);
                SetMethods.Empty(txtboxPassword);

                SetMethods.Start("Enter incorrect username and correct password", "12");
                SetMethods.EnterText(txtboxUsername, incorrectusername);
                SetMethods.EnterText(txtboxPassword, correctpassword);
                enteredtext = GetMethods.GetValue(txtboxUsername);
                GetMethods.VerifyText(enteredtext, incorrectusername);
                enteredtext = GetMethods.GetValue(txtboxPassword);
                GetMethods.VerifyText(enteredtext, correctpassword);

                SetMethods.Start("Submit LOGIN button", "13");
                SetMethods.Submit(btnLogIn);
                Console.WriteLine("X button:");
                SetMethods.Displayed(btnX);
                SetMethods.Enabled(btnX);
                message = GetMethods.GetText(txtMessage);
                GetMethods.VerifyText(message, "Epic sadface: Username and password do not match any user in this service");

                SetMethods.Start("Clear username and password textboxes.", "14");
                SetMethods.Clear(txtboxUsername);
                SetMethods.Clear(txtboxPassword);
                SetMethods.Empty(txtboxUsername);
                SetMethods.Empty(txtboxPassword);

                SetMethods.Start("Enter correct username and incorrect password", "15");
                SetMethods.EnterText(txtboxUsername, correctusername);
                SetMethods.EnterText(txtboxPassword, incorrectpassword);
                enteredtext = GetMethods.GetValue(txtboxUsername);
                GetMethods.VerifyText(enteredtext, correctusername);
                enteredtext = GetMethods.GetValue(txtboxPassword);
                GetMethods.VerifyText(enteredtext, incorrectpassword);

                SetMethods.Start("Submit LOGIN button", "16");
                SetMethods.Submit(btnLogIn);
                Console.WriteLine("X button:");
                SetMethods.Displayed(btnX);
                SetMethods.Enabled(btnX);
                message = GetMethods.GetText(txtMessage);
                GetMethods.VerifyText(message, "Epic sadface: Username and password do not match any user in this service");

                SetMethods.Start("Clear username and password textboxes.", "17");
                SetMethods.Clear(txtboxUsername);
                SetMethods.Clear(txtboxPassword);
                SetMethods.Empty(txtboxUsername);
                SetMethods.Empty(txtboxPassword);

                SetMethods.Start("Enter correct username and correct password", "18");
                SetMethods.EnterText(txtboxUsername, correctusername);
                SetMethods.EnterText(txtboxPassword, correctpassword);
                enteredtext = GetMethods.GetValue(txtboxUsername);
                GetMethods.VerifyText(enteredtext, correctusername);
                enteredtext = GetMethods.GetValue(txtboxPassword);
                GetMethods.VerifyText(enteredtext, correctpassword);

                SetMethods.Start("Submit LOGIN button", "19");
                SetMethods.Submit(btnLogIn);
                string URLLogged = WebDriver.driver.Url;
                GetMethods.PageLoaded(URLLogged, "inventory");
                Console.WriteLine("Login successfuly!");
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Test failed{0}", ex.StackTrace));
            }

        }
    }

}


