using System;
using System.Security.Cryptography.X509Certificates;
using AutomationFramework;
using AutomationFramework.Enums;
using AutomationFramework.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationProject
{
    [TestClass]
    public class BaseTest
    {
        public RemoteWebDriver WebDriver { get; set; }
        public TestContext TestContext { get; set; }
        public DataAccess DataAccess { get; set; }



        [TestInitialize]
        public void StartAutomatedTest()
        {
            DataAccess = new DataAccess(TestContext.TestName);
            WebDriver = new DriverFactory().CreateDriver(DriverType.ChromeDriver);
            WebDriver.Navigate().GoToUrl(DataAccess.getParameterValue("StartedUrl"));
        }

        [TestCleanup]
        public void TestMethod1()
        {
            WebDriver.Close();
        }
    }
}
