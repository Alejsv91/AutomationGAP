using AutomationFramework.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace AutomationFramework
{
    public class Driver
    {
        public static  FactoryDriver(DriverType driverType)
        {
            DriverLocalPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            switch (driverType)
            {
                case DriverType.ChromeDriver:
                    TestScenarioDriver = new ChromeDriver(DriverLocalPath); 
                    
                    break;
            }


        }

        private void AddDriverOptions()
        {
           
        }

        public DriverOptions TestScenarioDriverOptions { get; set; }
        public RemoteWebDriver TestScenarioDriver { get; set; }
        private string DriverLocalPath { get; set; }
    }
}
