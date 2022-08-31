using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Threading;
using ExcelDataReader;
using System.Data;
using System.IO;
using System.Reflection;

namespace Sonic_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to start Execution");
            Console.ReadLine();
            Initialize();
            Execution();
            Form1();
            Console.WriteLine("Execution Completed");
            Console.ReadLine();

        }
        public static void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://app.sonic.pk/cod/login");
            PropertiesCollection.driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            
        }

        public static void Execution()
        {

            DataTable table = ExcelLib.PopulateInCollection(ConfigurationManager.AppSettings["data"]);

            LoginPageObject obj1 = new LoginPageObject();

            obj1.Login(ExcelLib.ReadData(1, "email"), ExcelLib.ReadData(1, "password"));
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            
            //obj1.btnLoginn.Submit();
            //PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //obj1.btnMenu.Click();
            //PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            //obj1.btnBooking.Click();
            //PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            //obj1.btnBook.Click();
            //PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            //obj1.btnOrderForm.Click();
            //PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles[1]);
            
        }
        public static void Form1()
        {
            Booking obj2 = new Booking();
            
            obj2.Form(ExcelLib.ReadData(1, "City"), ExcelLib.ReadData(1, "Name"), ExcelLib.ReadData(1, "Address"), ExcelLib.ReadData(1, "Phone1"), ExcelLib.ReadData(1, "Phone2"),ExcelLib.ReadData(1,"Cemail"), ExcelLib.ReadData(1, "OrderId"), ExcelLib.ReadData(1, "Itemdesc"), ExcelLib.ReadData(1, "ItemQuan"), ExcelLib.ReadData(1, "Instructions"), ExcelLib.ReadData(1, "Weight"),ExcelLib.ReadData(1, "Pieces"),ExcelLib.ReadData(1, "Amount"));
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            
            //PropertiesCollection.driver.Close();
            //PropertiesCollection.driver.Quit();

        }

    }
    
}