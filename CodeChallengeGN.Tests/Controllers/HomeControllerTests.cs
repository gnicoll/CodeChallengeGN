using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using CodeChallengeGN.Website.Models;
using CodeChallengeGN.Website.Controllers;

namespace CodeChallengeGN.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexPass()
        {
            HomeController controller = new HomeController();

            //correct companyId
            var result = controller.Index("Tattersalls") as Task<ViewResult>;

            var actionresult = result.Result;

            var model = (LatestResultsModel)(actionresult.Model);

            Assert.IsNotNull(result);
            Assert.IsTrue(model.Success);
        }

        [TestMethod]
        public void IndexFail()
        {
            HomeController controller = new HomeController();

            //incorrect companyId, webservice result will be unsuccessful
            var result = controller.Index("") as Task<ViewResult>;

            var actionresult = result.Result;

            var model = (LatestResultsModel)(actionresult.Model);

            Assert.IsNotNull(result);
            Assert.IsFalse(model.Success);
        }
    }
}  

