using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTask.Methods;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTask.PageObjects
{
    public static class SaucedemoHomePageObjects
    {
        public static IWebElement btnMenu => WebDriver.driver.FindElement(By.Id("react-burger-menu-btn"));
        public static IWebElement btnX => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[2]/div"));
        public static IWebElement btnAllitems => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/nav/a[1]"));
        public static IWebElement btnAbout => WebDriver.driver.FindElement(By.Id("about_sidebar_link"));
        public static IWebElement btnLogout => WebDriver.driver.FindElement(By.Id("logout_sidebar_link"));
        public static IWebElement btnResetappstate => WebDriver.driver.FindElement(By.Id("reset_sidebar_link"));
        public static IWebElement btnCart => WebDriver.driver.FindElement(By.Id("shopping_cart_container"));
        public static IWebElement txtCart => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[3]/a/span"));
        public static IWebElement txtProducts => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/span"));
        public static IWebElement productsContainer => WebDriver.driver.FindElement(By.Id("inventory_container"));
        public static IWebElement dropDown => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div[2]/span"));
        public static IWebElement dropdownSort => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div[2]/span/select"));
        public static IWebElement btnTwitter => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/footer/ul/li[1]/a"));
        public static IWebElement btnFacebook => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/footer/ul/li[2]/a"));
        public static IWebElement btnLinkedin => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/footer/ul/li[3]/a"));
        public static IWebElement txtSauce => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/footer/div"));
        public static IWebElement btnAddtocart => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[2]/div[2]/div[2]/button"));
        public static IWebElement txtRemove => WebDriver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[1]/div[2]/div[2]/button"));


        public static void HomePage()
        {
            try
            {
                SetMethods.Start("Loads page-https://www.saucedemo.com/inventory.html", "1");
                GetMethods.PageLoaded(WebDriver.driver.Url, "inventory");

                Console.WriteLine("Menu button:");
                SetMethods.Displayed(btnMenu);
                SetMethods.Enabled(btnMenu);

                Console.WriteLine("Cart button:");
                SetMethods.Displayed(btnCart);
                SetMethods.Enabled(btnCart);

                Console.WriteLine("Text Products:");
                string text = GetMethods.GetText(txtProducts);
                GetMethods.VerifyText(text, "PRODUCTS");

                Console.WriteLine("Dropdown menu:");
                SetMethods.Displayed(dropDown);
                SetMethods.Enabled(dropDown);

                Console.WriteLine("Products list:");
                GetMethods.VerifyProduct(productsContainer, "Sauce Labs Backpack\ncarry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.\n$29.99\nADD TO CART");
                GetMethods.VerifyProduct(productsContainer, "Sauce Labs Bike Light\nA red light isn't the desired state in testing but it sure helps when riding your bike at night. Water-resistant with 3 lighting modes, 1 AAA battery included.\n$9.99\nADD TO CART");
                GetMethods.VerifyProduct(productsContainer, "Sauce Labs Bolt T-Shirt\nGet your testing superhero on with the Sauce Labs bolt T-shirt. From American Apparel, 100% ringspun combed cotton, heather gray with red bolt.\n$15.99\nADD TO CART");
                GetMethods.VerifyProduct(productsContainer, "Sauce Labs Onesie\nRib snap infant onesie for the junior automation engineer in development. Reinforced 3-snap bottom closure, two-needle hemmed sleeved and bottom won't unravel.\n$7.99\nADD TO CART");
                GetMethods.VerifyProduct(productsContainer, "Test.allTheThings() T-Shirt (Red)\nThis classic Sauce Labs t-shirt is perfect to wear when cozying up to your keyboard to automate a few tests. Super-soft and comfy ringspun combed cotton.\n$15.99\nADD TO CART");

                Console.WriteLine("Twitter button:");
                SetMethods.Displayed(btnTwitter);
                SetMethods.Enabled(btnTwitter);

                Console.WriteLine("Facebook button:");
                SetMethods.Displayed(btnFacebook);
                SetMethods.Enabled(btnFacebook);

                Console.WriteLine("LinkedIn button:");
                SetMethods.Displayed(btnLinkedin);
                SetMethods.Enabled(btnLinkedin);

                text = GetMethods.GetText(txtSauce);
                GetMethods.VerifyText(text, "© 2022 Sauce Labs. All Rights Reserved. Terms of Service | Privacy Policy");

                SetMethods.Start("Clicks Menu button", "2");
                var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("shopping_cart_container")));
                SetMethods.Click(btnMenu);

                Console.WriteLine("X button:");
                SetMethods.Displayed(btnX);
                SetMethods.Enabled(btnX);

                Console.WriteLine("ALL ITEMS button:");
                SetMethods.Displayed(btnAllitems);
                SetMethods.Enabled(btnAllitems);

                Console.WriteLine("ABOUT button:");
                SetMethods.Displayed(btnAbout);
                SetMethods.Enabled(btnAbout);

                Console.WriteLine("LOGOUT button:");
                SetMethods.Displayed(btnLogout);
                SetMethods.Enabled(btnLogout);

                Console.WriteLine("RESET APP STATE button:");
                SetMethods.Displayed(btnResetappstate);
                SetMethods.Enabled(btnResetappstate);

                SetMethods.Start("Click X button.", "3");
                SetMethods.Click(btnX);
                wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("shopping_cart_container")));
                SetMethods.Hidden(btnX);

                SetMethods.Start("Clicks dropdown menu.", "4");
                SetMethods.Click(dropdownSort);
                text = GetMethods.GetText(dropdownSort).Replace("\r", string.Empty);
                GetMethods.VerifyText(text, "Name (A to Z)\nName (Z to A)\nPrice (low to high)\nPrice (high to low)");

                SetMethods.Start("Clicks Sauce Labs Bike Light ADD TO CART button", "5");
                SetMethods.Click(btnAddtocart);
                text = GetMethods.GetText(btnAddtocart);
                //SetMethods.Hidden(btnX);
                GetMethods.VerifyText(text, "REMOVE");

                Console.WriteLine("REMOVE button:");
                text= GetMethods.GetText(txtCart);

                Console.WriteLine("Cart button:");
                GetMethods.VerifyText(text, "1");

                SetMethods.Start("Clicks Cart button:", "6");
                wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[3]/a")));
                SetMethods.Click(btnCart);
                GetMethods.PageLoaded(WebDriver.driver.Url, "cart");
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Test failed{0}", ex.StackTrace));
            }
        }










    }
}
