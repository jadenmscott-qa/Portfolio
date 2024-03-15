using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TODO: change into functions
namespace SeleniumWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize window
           
        }
        static void Search(string[] args) {
            // Searching for Item
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
        IWebElement element = driver.FindElement(By.Id("search"));
        element.SendKeys("shirt");
            element.Submit();

            element = driver.FindElement(By.CssSelector("#maincontent > div.columns > div.column.main > div.search.results > div.products.wrapper.grid.products-grid > ol > li:nth-child(1) > div > a > span > span > img"));
            element.Click();

        }
        static void Checkout(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //Checking Out, ensure products are in cart prior to running or call Add Item function  
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            // TODO: breakpoint to manually add products
            IWebElement  element = driver.FindElement(By.CssSelector("body > div.page-wrapper > header > div.header.content > div.minicart-wrapper > a"));
            element.Click();
            element = driver.FindElement(By.CssSelector("#top-cart-btn-checkout"));
            element.Click();
            IWebElement customerEmail = driver.FindElement(By.CssSelector("#customer-email"));
            customerEmail.SendKeys("test@test.com");
            IWebElement customerFirstName = driver.FindElement(By.Name("firstname"));
            customerFirstName.SendKeys("test");
            IWebElement customerLastName = driver.FindElement(By.Name("lastname"));
            customerLastName.SendKeys("tester");
            IWebElement customerStreetAddress = driver.FindElement(By.Name("street[0]"));
            customerStreetAddress.SendKeys("123 Tester Ln");
            IWebElement customerCity = driver.FindElement(By.Name("city"));
            customerCity.SendKeys("Testerville");
            // TODO breakpoint to manually select state for now
            IWebElement customerRegion = driver.FindElement(By.Name("region_id"));
            customerRegion.Click();
            customerRegion.SendKeys("tennessee");
            customerRegion.Submit();
            IWebElement customerPostalCode = driver.FindElement(By.Name("postcode"));
            customerPostalCode.SendKeys("00000");
            IWebElement customerTelephone = driver.FindElement(By.Name("telephone"));
            customerTelephone.SendKeys("1234567890");
            IWebElement shipping = driver.FindElement(By.CssSelector("#checkout-shipping-method-load > table > tbody > tr:nth-child(1) > td:nth-child(1) > input"));
            shipping.Click();
            IWebElement payment = driver.FindElement(By.CssSelector("#checkout-payment-method-load > div > div > div.payment-method._active > div.payment-method-content > div.actions-toolbar > div > button"));
            payment.Click();
        }
        static void RemoveItem(string[] args)
        {
            //TODO: item removal
            //  driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            // Adding item to cart  - STALE ERROR EXCEPTION
            //driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            //IWebElement element = driver.FindElement(By.CssSelector("#maincontent > div.columns > div > div:nth-child(6) > div.block.widget.block-products-list.grid > div > div > ol > li:nth-child(2) > div"));
            //element.Click();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            //element.FindElement(By.CssSelector("#product-addtocart-button"));
            //element.Click();  
        }


        // Close Window
        //driver.Quit();
    }
    }
