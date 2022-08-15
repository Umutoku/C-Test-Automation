using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Component.Impl
{
     public class SearchComponent: WebComponent
    {
        public SearchComponent(IWebElement rootElement) : base(rootElement)
        {

        }

        public void PerformSearch(string searchPhrase)
        {
            SenKeys(searchPhrase);
            SenKeys(Keys.Enter);
        }
    }
}
