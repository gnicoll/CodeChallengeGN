using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeGN.Website.Models
{
    public class DividendModel
    {
        public int Division { get; set; }
        public int BlocNumberOfWinners { get; set; }
        public float BlocDividend { get; set; }
        public string CompanyId { get; set; }
        public float CompanyDividend { get; set; }
        public string PoolTransferType { get; set; }
        public int PoolTransferredTo { get; set; }

    }
}
