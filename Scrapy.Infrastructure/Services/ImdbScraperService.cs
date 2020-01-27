using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Scrapy.Core.Dtos;
using Scrapy.Core.Interfaces;
using Scrapy.Core.Interfaces.PageObjects;
using Scrapy.Core.Interfaces.Services;
using Scrapy.Infrastructure.PageObjects;

namespace Scrapy.Infrastructure.Services
{
    public class ImdbScraperService : IImdbScraperService
    {
        public IEnumerable<ResultItem> Search(string title)
        {
            using IWebDriver driver = new ChromeDriver
                (@"C:\Users\User\RiderProjects\Scrapy\Scrapy.Infrastructure\bin\Debug\netcoreapp3.1");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            var homePage = new HomePage(driver);
            homePage.GoToPage();
            var search = homePage.Search(title);

            return search.MovieResults.Select(movie => new ResultItem
            {
                Name = movie.Text,
                Href = movie.FindElement(By.TagName("a")).GetAttribute("href")
            }).ToList();
        }
    }
}