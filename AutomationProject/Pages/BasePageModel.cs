using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.Pages
{
    public abstract class BasePageModel
    {
        #region properties
        public abstract string Url { get; }
        public IWebDriver WebDriver { get; set; }

        public WebDriverWait WaitDriver { get; set;  } 
        #endregion

        #region pageElements
        public IWebElement header { get; set; }
        #endregion
    }
}
