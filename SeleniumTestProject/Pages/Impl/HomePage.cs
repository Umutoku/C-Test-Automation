using OpenQA.Selenium;
using SeleniumTestProject.Component.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Pages.Impl
{
    public class HomePage : WebPage
    {
        private static readonly By SearchComponentSelector = By.CssSelector("[name='q']");
        //private IWebElement searchInput => (IWebElement)FindElements(By.CssSelector("[name='q']"));

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        //public void PerformSearch(string searchPhrase)
        //{
            //searchInput.SendKeys(searchPhrase);
          //  searchInput.SendKeys(Keys.Enter);
        //}

        public SearchComponent SearchComponent => new SearchComponent(FindElement(SearchComponentSelector));
    }
}
