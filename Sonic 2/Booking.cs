using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Sonic_2
{
    class Booking
    {
        public Booking()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Service Type')]/parent::span/parent::span[contains(@role, 'combobox')]")]
        public IWebElement btnServices { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(), 'Regular')]")]
        public IWebElement btnRegular { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='modal-footer']")]
        public IWebElement btnSide { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@type, 'submit') and contains(text(), 'Select')]")]
        public IWebElement btnSelect { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//span[contains(@id,'select2-consignee_city-container')]")]
        public IWebElement btnCities { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@class, 'select2-search__field')]")]
        public IWebElement txtCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[contains(@id, 'select2-consignee_city-results')]")]
        public IWebElement btnResult { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name, 'consignee_name')]")]
        public IWebElement txtName { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[contains(@id, 'consignee_address')]")]
        public IWebElement txtAddress { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder, 'Phone Number 1*')]")]
        public IWebElement txtPhone1 { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder, 'Phone Number 2')]")]
        public IWebElement txtPhone2 { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[contains(@name, 'consignee_email_address')]")]
        public IWebElement txtemail { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder, 'Order ID')]")]
        public IWebElement txtOrderID { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@name= 'item_description']")]
        public IWebElement txtItemdesc { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name= 'item_quantity']")]
        public IWebElement txtItemQuatity { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@name= 'special_instructions']")]
        public IWebElement txtInstructions { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name= 'estimated_weight']")]
        public IWebElement txtWeight { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name= 'pieces_quantity']")]
        public IWebElement txtPieces { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id= 'amount']")]
        public IWebElement txtAmount{ get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(), 'Shipper References (Optional)')]")]
        public IWebElement btnSide2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@name='book_and_print']")]
        public IWebElement btnPrint { get; set; }


        public void Form(string City, string Name, string Address, string Phone1, string Phone2, string Cemail, string OrderId, string Itemdesc, string ItemQuan, string Instructions, string Weight, string Pieces, string Amount)
        {
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //service type button
            btnServices.Click();
            //regular button
            btnRegular.Click();
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            //button side
            btnSide.Click();
            //select button
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            Actions act1 = new Actions(PropertiesCollection.driver);
            act1.DoubleClick(btnSelect).Perform();
            //btncities
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            btnCities.Click();
            if (txtCity.Displayed)
            {
                //city
                txtCity.SendKeys(City);
                //result city
                btnResult.Click();
                //name
                txtName.SendKeys(Name);
                //address
                txtAddress.SendKeys(Address);
                //phone1
                txtPhone1.SendKeys(Phone1);
                //phone2
                txtPhone2.SendKeys(Phone2);
                //email
                txtemail.SendKeys(Cemail);
                //Order Id
                txtOrderID.SendKeys(OrderId);
                //Item Descripton
                txtItemdesc.SendKeys(Itemdesc);
                //Item Quantity
                txtItemQuatity.SendKeys(ItemQuan);
                //Special Instructions
                txtInstructions.SendKeys(Instructions);
                //Weight
                txtWeight.SendKeys(Weight);
                //pieces
                txtPieces.SendKeys(Pieces);
                //amount
                txtAmount.SendKeys(Amount);
                PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
                //button Side2
                btnSide2.Click();
                PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
                //book and print
                Actions act = new Actions(PropertiesCollection.driver);
                act.DoubleClick(btnPrint).Perform();
            }
            else
            {
                Console.WriteLine("Element Not Found");
                Console.ReadLine();
            }
        }



    }
}
        