using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CodeChallengeGN.Website.Interfaces;
using CodeChallengeGN.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CodeChallengeGN.Website.Services
{
    public class WebApiService : IWebApiService
    {

        private string ApiUrl = "https://data.api.thelott.com";
        public async Task<LatestResultsModel> GetLatestResults(string CompanyId = "Tattersalls", int MaxDrawCountPerProduct = 1)
        {
            LatestResultsModel latestResults = new LatestResultsModel();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(ApiUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //company id = Tattersalls
                HttpContent content = new StringContent("{\"CompanyId\": \"" + CompanyId + "\",\"MaxDrawCountPerProduct\": " + MaxDrawCountPerProduct + ",}");
                HttpResponseMessage response = await client.PostAsync("/sales/vmax/web/data/lotto/latestresults", content);

                if (response.IsSuccessStatusCode)
                {

                    var ResultsResponse = response.Content.ReadAsStringAsync().Result;

                    latestResults = JsonConvert.DeserializeObject<LatestResultsModel>(ResultsResponse);
                }

                return latestResults;
            }
        }
    }
}
