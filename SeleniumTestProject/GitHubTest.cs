using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumTestProject.Pages.Impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumTestProject
{
    public class GitHubTest
    {
        private const string searchPhrase = "selenium";

        private static IWebDriver driver;
        private static WebDriverWait wait;

        [OneTimeSetUp]
        public static void SetUpWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
        }

        [OneTimeSetUp]

        public static void SetUpWait() =>
         wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        [Test]
        public void CheckGitHubSearch()
        {
                
                driver.Navigate().GoToUrl("https://github.com");

                var homePage = new HomePage(driver);
                var searchResultpage = new SearchResultpage(driver);
                
                homePage.SearchComponent.PerformSearch(searchPhrase);

            var actualItems = searchResultpage.SearchResultsItemWithText(searchPhrase);
            var expectedItems = searchResultpage.SearchResultsItemWithText(searchPhrase);

                Assert.AreEqual(expectedItems, actualItems);

                //Assert.True(actualItems.All(item => item.ToLower().Contains("invalid search phrase")));

                
         }

        [OneTimeTearDown]
        public static void TearDownDriver()
        {
            
            driver.Quit();
        }

        private bool IsElementVisible(By selector)
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            try
            {
                return driver.FindElement(selector).Displayed;
            }
            catch (NoSuchElementException)
            {

                return false;
            }
            finally
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString());
            }
        }

        private bool IsElementVisibleExplicitWait(By selector)
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            try
            {
                return wait.Until(d=>driver.FindElement(selector).Displayed);
            }
            finally
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString());
            }
        }

        private static void SwitchOffImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(0);
        }

    }
    
    
    }
