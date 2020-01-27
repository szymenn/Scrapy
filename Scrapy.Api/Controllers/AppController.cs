using System;
 using Microsoft.AspNetCore.Mvc;
 using Scrapy.Core.Interfaces;
 using Scrapy.Core.Interfaces.Services;
 
 namespace Scrapy.Api.Controllers
 {
     [ApiController, Route("/")]
     public class AppController : ControllerBase
     {
         private readonly IImdbScraperService _scraperService;
 
         public AppController(IImdbScraperService scraperService)
         {
             _scraperService = scraperService;
         }
         
         [HttpGet("{title}")]
         public IActionResult Search(string title)
         {
             return Ok(_scraperService.Search(title));
         }
     }
 }