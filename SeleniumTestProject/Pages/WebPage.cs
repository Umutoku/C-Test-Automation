using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Pages
{
    public class WebPage
    {
        private readonly IWebDriver driver;

        public WebPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FindElement(By bySelector)
        {
            return driver.FindElement(bySelector);
        }

        public IList<IWebElement> FindElements(By bySelector)
        {
            return driver.FindElements(bySelector);
        }
    }
}
