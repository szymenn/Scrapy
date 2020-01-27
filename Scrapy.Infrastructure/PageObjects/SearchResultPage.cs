using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
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
        public IWebElement ListResult => SectionResult.FindElement(By.ClassName("findList"));
        public IEnumerable<IWebElement> MovieResults => _driver.FindElements(By.ClassName("result_text"));
        public IWebElement Header => SectionResult.FindElement(By.CssSelector("#main > div > div:nth-child(3) > h3"));
        
        public IEnumerable<IWebElement> AnchorTags => SectionResult.FindElements(
            By.XPath("/html/body/div[2]/div/div[2]/div/div[1]/div/div[3]/table/tbody/tr[1]/td[2]/a"));

        public IWebElement Article => _driver.FindElement(By.ClassName("article"));
    }
}