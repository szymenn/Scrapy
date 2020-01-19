using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Scrapy.Core.Interfaces;
using Scrapy.Core.Interfaces.PageObjects;
using Scrapy.Core.Interfaces.Services;
using Scrapy.Infrastructure.PageObjects;

namespace Scrapy.Infrastructure.Services
{
    public class ImdbScraperService : IImdbScraperService
    {
        public string Search(string title)
        {
            using IWebDriver driver = new ChromeDriver
                (@"C:\Users\User\RiderProjects\Scrapy\Scrapy.Infrastructure\bin\Debug\netcoreapp3.1");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            var homePage = new HomePage(driver);
            homePage.GoToPage();
            var search = homePage.Search(title);
            Console.WriteLine(search.MovieResults.Aggregate("", (current, next) => current + "\n" + next.Text));
            return search.MovieResults.Aggregate("", (current, next) => current + "\n" + next.Text);
        }
    }
}