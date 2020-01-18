using OpenQA.Selenium;

namespace Scrapy.Core.Interfaces.PageObjects
{
    public interface ISearchResultPage
    {
        IWebElement MovieResult { get; }
        IWebElement Header { get; }
    }
}