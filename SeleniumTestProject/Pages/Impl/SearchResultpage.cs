using OpenQA.Selenium;
using SeleniumTestProject.Component.Impl;
using SeleniumTestProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.Pages.Impl
{
    public class SearchResultpage : WebPage
    {
        private static readonly By SearchResultItemSelector = By.CssSelector(".repo-list-item");

        private IList<SearchResultItemComponent> SearchResultItems =>
            FindElements(SearchResultItemSelector).Select(element =>
            new SearchResultItemComponent(element)).ToList();
        public SearchResultpage(IWebDriver driver) : base(driver)
        {
        }
        public IList<SearchResultItem> SearchResultsItems()
        {
            return SearchResultItems
                    .Select(item => item.ConvertToSearchResultItem())
                    .ToList();
        }
        public IList<SearchResultItem> SearchResultsItemWithText(string searchPhrase)
        {
            return SearchResultsItems()
                .Where(item => item.Title.Contains(searchPhrase)
                || item.Description.Contains(searchPhrase))
                    .ToList();
        }
    }
}
