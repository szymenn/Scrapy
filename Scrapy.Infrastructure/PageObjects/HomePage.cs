using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Scrapy.Core.Interfaces.PageObjects;

namespace Scrapy.Infrastructure.PageObjects
{
    public class HomePage : IHomePage
    {
         private readonly IWebDriver _driver;

         private IWebElement SearchBar => _driver.FindElement(By.Name("q"));

         public HomePage(IWebDriver driver)
           {
               _driver = driver;
           }
           
           public void GoToPage()
           {
               _driver.Navigate().GoToUrl("https://imdb.com/");
           }
   
           public ISearchResultPage Search(string movie)
           {
               SearchBar.SendKeys(movie + Keys.Enter);
               return new SearchResultPage(_driver);
           }
       }
   }