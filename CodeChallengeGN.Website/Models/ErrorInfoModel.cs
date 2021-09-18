using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeGN.Website.Models
{
    public class ErrorInfoModel
    {
        public bool ContactSupport { get; set; }
        public string DisplayMessage { get; set; }
        public int ErrorNo { get; set; }
        public string SupportErrorReference { get; set; }
        public int SystemId { get; set; }
    }
}
