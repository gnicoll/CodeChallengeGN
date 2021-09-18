using CodeChallengeGN.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CodeChallengeGN.Website.Interfaces;
using CodeChallengeGN.Website.Services;
using Newtonsoft.Json;

namespace CodeChallengeGN.Website.Controllers
{
    public class HomeController : Controller
    {
        private IWebApiService WebApiService;
        public HomeController()
        {
            WebApiService = new WebApiService();
        }

        public async Task<ViewResult> Index(string CompanyId= "Tattersalls", int MaxDrawCountPerProduct=1)
        {
            LatestResultsModel latestResults = await WebApiService.GetLatestResults(CompanyId, MaxDrawCountPerProduct);

            return View(latestResults);
        }
    }
}
