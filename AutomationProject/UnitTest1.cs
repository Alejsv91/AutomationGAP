using System;
using AutomationFramework;
using AutomationFramework.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void StartAutomatedTest()
        {
            Driver driver = new Driver(DriverType.ChromeDriver);
             
        }
        [TestMethod]
        public void TestMethod1()
        {
            var test = "";
        }
    }
}
