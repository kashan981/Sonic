using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Sonic_2
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtemail { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='password']")]
        public IWebElement txtpassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit' and text()=' Login']")]
        public IWebElement btnLoginn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@id, 'sidebar_menu')]")]
        public IWebElement btnMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(., 'Bookings')]")]
        public IWebElement btnBooking { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'menu-title') and contains(text(),'Book')]/parent::a/parent::li[contains(@class, 'is-shown')]")]
        public IWebElement btnBook { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Order Form')]")]
        public IWebElement btnOrderForm { get; set; }


        public void Login(string email, string password)
        {
            //email
            txtemail.SendKeys(email);
            //password
            txtpassword.SendKeys(password);
            //login
            btnLoginn.Submit();
            //menu
            btnMenu.Click();
            //booking button
            btnBooking.Click();            
            //book button
            btnBook.Click();
            //order form button
            Thread.Sleep(1000);
            btnOrderForm.Click();
        }
    }
}
