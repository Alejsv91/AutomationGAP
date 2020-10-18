using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework
{
    public class UIElement
    {
        private IWebElement _element;
        public IWebElement element
        {
            set
            {
                _element = value;
            }
            get 
            {
                return _element;
            }

        }


        public string Description { get; set; }


    }
}
