using AutomationFramework.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AutomationFramework
{
    public class DriverFactory
    {
        #region properties
        private string DriverLocalPath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        #endregion
        #region methods
        public RemoteWebDriver CreateDriver(DriverType driverType)
        {           
            switch (driverType)
            {
                case DriverType.ChromeDriver:
                    return new ChromeDriver(DriverLocalPath, AddChromeBrowserOptions());
            }
            return null;
        }

        public ChromeOptions AddChromeBrowserOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--kiosk");
            return chromeOptions;
        }
        #endregion
    }
}
