using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AutomationProject.Pages;
using AutomationFramework.Utilities;
using System.Net.Http;
using System.IO;
using System.Net.Http.Headers;

namespace AutomationProject.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ProductTest : BaseTest
    {
        [TestMethod]
        public void TC1()
        {
            ProductPage productPage = new ProductPage(WebDriver);
            //Verifying the product Name
            Assert.AreEqual(DataAccess.getParameterValue("ExpectedProductName"), productPage.ProductTitle.Text);
            //Verifying the product price
            Assert.AreEqual(DataAccess.getParameterValue("ProductValue"), productPage.Price.Text);
            //Increase the quantity to 7
            productPage.ProductQuantity.Clear();
            productPage.ProductQuantity.SendKeys("7");
            //Click on add button
            productPage.AddToCardButton.Click();
            //Verify if is added
            productPage = new ProductPage(WebDriver);
            Assert.AreEqual(DataAccess.getParameterValue("CartProductQuantity"), productPage.CartQuantity.Text);
            productPage.CartCheckout.Click();
            //Go to CheckOut
            CheckOutPage checkOutPage = new CheckOutPage(WebDriver);
            //Verify if the product is present
            Assert.AreEqual(DataAccess.getParameterValue("ExpectedProductName"), checkOutPage.productName.Text);
            //Verify if the amount is the expected
            Assert.AreEqual(DataAccess.getParameterValue("TotalAmount"), checkOutPage.TotalAmount.Text);
        }

    }
}
