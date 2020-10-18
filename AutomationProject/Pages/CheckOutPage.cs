using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.Pages
{
    public class CheckOutPage : BasePageModel
    {
        public CheckOutPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            WaitDriver = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
            //Verify when the page is loaded
            WaitDriver.Until(driver => ((IJavaScriptExecutor)webDriver).ExecuteScript("return document.readyState").Equals("complete"));
            //WaitDriver.Until(Expe)
            productName = WebDriver.FindElement(By.XPath("//tbody/tr/td[@class='product-name']/a"));
            TotalAmount = WebDriver.FindElement(By.XPath("//td[@class='product-subtotal']/span"));
        }
        public override string Url => "http://34.205.174.166/cart/";

        internal IWebElement productName { get; set; }
        internal IWebElement TotalAmount { get; set; }

    }
}
