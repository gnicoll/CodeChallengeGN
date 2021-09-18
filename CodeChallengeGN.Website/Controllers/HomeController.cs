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
using Newtonsoft.Json;

namespace CodeChallengeGN.Website.Controllers
{
    public class HomeController : Controller
    {
        //Hosted web API REST Service base url
        string Baseurl = "https://data.api.thelott.com/sales/vmax/web/data/lotto/latestresults";
        public async Task<ActionResult> Index()
        {
            LatestResultsModel latestResults= new LatestResultsModel();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpContent content  = new StringContent("{\"CompanyId\": \"Tattersalls\",\"MaxDrawCountPerProduct\": 2,}");
                HttpResponseMessage response = await client.PostAsync(Baseurl, content);
                //Checking the response is successful or not which is sent using HttpClient
                if (response.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var ResultsResponse = response.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list
                    latestResults = JsonConvert.DeserializeObject<LatestResultsModel>(ResultsResponse);
                }
                //returning the employee list to view
                return View(latestResults);
            }
        }
    }
}
