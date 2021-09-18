using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallengeGN.Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallengeGN.Website.Interfaces
{
    interface IWebApiService
    {
        public Task<LatestResultsModel> GetLatestResults(string CompanyId, int MaxDrawCountPerProduct);
    }
}
