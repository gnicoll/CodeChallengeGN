using System;
using System.Collections.Generic;

namespace CodeChallengeGN.Website.Models
{
    public class LatestResultsModel
    {
        public IEnumerable<DrawResultModel> DrawResults { get; set; }

        public bool Success { get; set; }

        public ErrorInfoModel ErrorInfo { get; set; }
    }
}
