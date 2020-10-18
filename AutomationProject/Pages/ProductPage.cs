using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.Pages
{
    public class ProductPage: BasePageModel
    {
        #region constructor
        public ProductPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            WaitDriver = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
            //Verify when the page is loaded
            WaitDriver.Until(driver => ((IJavaScriptExecutor)webDriver).ExecuteScript("return document.readyState").Equals("complete"));
            //Adding the required IWebElement
            ProductTitle = webDriver.FindElement(By.XPath("//h1[contains(@class,'product_title entry-title')]"));
            Price = webDriver.FindElement(By.XPath("//p[@class='price']/."));
            ProductQuantity = webDriver.FindElement(By.XPath("//input[@type='number' and @class= 'input-text qty text']"));
            AddToCardButton = webDriver.FindElement(By.XPath("//button[@type='submit' and @name= 'add-to-cart']"));
            CartQuantity = webDriver.FindElement(By.XPath("//span[@class='count']"));
            CartCheckout = webDriver.FindElement(By.XPath("//a[@class='cart-contents']"));

        }
        #endregion
        #region properties
        public override string Url =>"http://34.205.174.166/product/Alejandro/";

        internal IWebElement ProductTitle { get; set; }
        internal IWebElement Price { get; set; }
        internal IWebElement ProductQuantity { get; set; }
        internal IWebElement AddToCardButton { get; set; }
        internal IWebElement CartQuantity { get; set; }
        internal IWebElement CartCheckout { get; set; }
        #endregion
    }
}
