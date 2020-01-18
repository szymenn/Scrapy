using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Scrapy.Core.Interfaces.PageObjects;

namespace Scrapy.Infrastructure.PageObjects
{
    public class SearchResultPage : ISearchResultPage
    {
        private readonly IWebDriver _driver;
        
        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }


        private IWebElement SectionResult => _driver.FindElement(By.ClassName("findSection"));
        private IWebElement ListResult => SectionResult.FindElement(By.ClassName("findList"));
        public IWebElement MovieResult => ListResult.FindElement(By.ClassName("result_text"));
        public IWebElement Header => SectionResult.FindElement(By.CssSelector("#main > div > div:nth-child(3) > h3")); 
        
    }
}