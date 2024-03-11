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
            IWebDriver driver = new ChromeDriver();

            // Searching for Item

             driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            IWebElement element = driver.FindElement(By.Id("search"));
            element.SendKeys("shirt");
            element.Submit();

            element = driver.FindElement(By.CssSelector("#maincontent > div.columns > div.column.main > div.search.results > div.products.wrapper.grid.products-grid > ol > li:nth-child(1) > div > a > span > span > img"));
            element.Click();

            //Checking Out, ensure products are in cart prior to running or call Add Item function  
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            // TODO: breakpoint to manually add products
            element = driver.FindElement(By.CssSelector("body > div.page-wrapper > header > div.header.content > div.minicart-wrapper > a"));
            element.Click();
            element = driver.FindElement(By.CssSelector("#top-cart-btn-checkout"));
            element.Click();
            element = driver.FindElement(By.CssSelector("#customer-email"));
            element.SendKeys("test@test.com");
            element = driver.FindElement(By.Name("firstname"));
            element.SendKeys("test");
            element = driver.FindElement(By.Name("lastname"));
            element.SendKeys("tester");
            element = driver.FindElement(By.Name("street[0]"));
            element.SendKeys("123 Tester Ln");
            element = driver.FindElement(By.Name("city"));
            element.SendKeys("Testerville");
            element = driver.FindElement(By.Name("region_id"));
            element.Click();
            // TODO breakpoint to manually select state for now
            element.SendKeys("tennessee");
            element.Submit();
            element = driver.FindElement(By.Name("postcode"));
            element.SendKeys("00000");
            element = driver.FindElement(By.Name("telephone"));
            element.SendKeys("1234567890");
            element = driver.FindElement(By.CssSelector("#checkout-shipping-method-load > table > tbody > tr:nth-child(1) > td:nth-child(1) > input"));
            element.Click();
            element = driver.FindElement(By.CssSelector("#shipping-method-buttons-container > div > button"));
            element.Click();
            element = driver.FindElement(By.CssSelector("#checkout-payment-method-load > div > div > div.payment-method._active > div.payment-method-content > div.actions-toolbar > div > button"));
            element.Click();

            //TODO: item removal

            // Adding item to cart  - STALE ERROR EXCEPTION
            //driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            //element = driver.FindElement(By.CssSelector("#maincontent > div.columns > div > div:nth-child(6) > div.block.widget.block-products-list.grid > div > div > ol > li:nth-child(2) > div"));
            //element.Click();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            //element.FindElement(By.CssSelector("#product-addtocart-button"));
            //element.Click();  



            // Close Window
            //driver.Quit();
        }
    }
}