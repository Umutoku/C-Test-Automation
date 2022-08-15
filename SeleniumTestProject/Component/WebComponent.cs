using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Component
{
    public class WebComponent
    {
        private readonly IWebElement rootElement;

        protected WebComponent(IWebElement rootElement) => this.rootElement = rootElement;

        protected IWebElement FindElement(By selector)
        =>
             rootElement.FindElement(selector);

        public void SenKeys(string keysToSend) =>
            rootElement.SendKeys(keysToSend);
        
        public string Text => rootElement.Text;
    }
}
