using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using CodeChallengeGN.Website.Models;
using CodeChallengeGN.Website.Controllers;
using CodeChallengeGN.Website.Services;

namespace CodeChallengeGN.Tests.Services
{
    [TestClass]
    public class WebApiServiceTests
    {
        
        [TestMethod]
        public async void GetLatestResultsSuccess()
        {
            WebApiService webApiService = new WebApiService();

            //correct companyId
            var result = await webApiService.GetLatestResults("Tattersalls", 1);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
        }

        [TestMethod]
        public async void GetLatestResultsFail()
        {
            WebApiService webApiService = new WebApiService();

            //incorrect companyId, webservice result will be unsuccessful
            var result = await webApiService.GetLatestResults("", 1);

            Assert.IsNotNull(result);
            Assert.IsFalse(result.Success);
        }
    }
}
