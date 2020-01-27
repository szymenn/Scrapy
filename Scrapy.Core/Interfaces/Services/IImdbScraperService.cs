using System.Collections.Generic;
using Scrapy.Core.Dtos;
using Scrapy.Core.Interfaces.PageObjects;

namespace Scrapy.Core.Interfaces.Services
{
    public interface IImdbScraperService
    {
        IEnumerable<ResultItem> Search(string title);
    }
}