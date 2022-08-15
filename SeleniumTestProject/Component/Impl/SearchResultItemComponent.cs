using OpenQA.Selenium;
using SeleniumTestProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Component.Impl
{
    public class SearchResultItemComponent :WebComponent
    {
        private static readonly By TitleSelector = By.CssSelector(".v-align-middle");
        private static readonly By DescriptionSelector = By.CssSelector(".mb-1");

        public SearchResultItemComponent(IWebElement rootElement) : base(rootElement)
        {

        }

        public SearchResultItem ConvertToSearchResultItem() =>
              new SearchResultItem(
                  FindElement(TitleSelector).Text.ToLower(),
                  FindElement(DescriptionSelector).Text.ToLower());
    }
}
