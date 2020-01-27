using System.Collections.Generic;
using OpenQA.Selenium;

namespace Scrapy.Core.Interfaces.PageObjects
{
    public interface ISearchResultPage
    {
        IEnumerable<IWebElement> MovieResults { get; }
        IWebElement Header { get; }
        IEnumerable<IWebElement> AnchorTags { get; }
        IWebElement ListResult { get; }
        IWebElement Article { get; }
    }
}