using System;
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
        public void Run()
        {
            using IWebDriver driver = new ChromeDriver
                (@"C:\Users\User\RiderProjects\Scrapy\Scrapy.Infrastructure\bin\Debug\netcoreapp3.1");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            var homePage = new HomePage(driver);
            homePage.GoToPage();
            var search = homePage.Search("Batman");
            Console.WriteLine(search.MovieResult.Text);
            Console.WriteLine(search.Header.Text);
        }
    }
}