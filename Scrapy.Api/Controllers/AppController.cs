using System;
using Microsoft.AspNetCore.Mvc;
using Scrapy.Core.Interfaces;

namespace Scrapy.Api.Controllers
{
    [ApiController, Route("/")]
    public class AppController : ControllerBase
    {
        private IImdbScraperService _scraperService;

        public AppController(IImdbScraperService scraperService)
        {
            _scraperService = scraperService;
        }
        
        [HttpGet]
        public IActionResult Run()
        {
            _scraperService.Run();
            return Ok();
        }
    }
}