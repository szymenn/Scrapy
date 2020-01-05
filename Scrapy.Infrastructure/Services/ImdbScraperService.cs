using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Scrapy.Core.Interfaces;

namespace Scrapy.Infrastructure.Services
{
    public class ImdbScraperService : IImdbScraperService
    {
        public void Run()
        {
            using IWebDriver driver = new ChromeDriver
                (@"C:\Users\User\RiderProjects\Scrapy\Scrapy.Infrastructure\bin\Debug\netcoreapp3.1");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://imdb.com/");
            driver.FindElement(By.Name("q")).SendKeys("Batman" + Keys.Enter);
            var firstElement = wait.Until(ExpectedConditions.ElementExists(By.ClassName("findSection")));
            Console.WriteLine(firstElement.FindElement(By.ClassName("result_text")));
        }
    }
}