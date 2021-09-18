﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeGN.Website.Models
{
    public class DrawResultModel
    {
        public string ProductId { get; set; }
        public int DrawNumber { get; set; }

        public DateTime DrawDate { get; set; }

        public string DrawDateStr
        {
            get
            {
                return DrawDate.ToLongDateString();
            }
        }

        public string DrawDisplayName { get; set; }

        public string DrawLogoUrl { get; set; }
        public string DrawLogoSrcLocal { 
            get
            {
                return "/images/" + ProductId.ToLower() + ".png";
            }
        }

        public IEnumerable<int> PrimaryNumbers { get; set; }
        public IEnumerable<int> SecondaryNumbers { get; set; }
        //public IEnumerable<int> TicketNumbers { get; set; }

        public IEnumerable<DividendModel> Dividends { get; set; }

        public int JackPotWinnersCount
        {
            get
            {
                if (Dividends.Any())
                {
                    var firstD = Dividends.First((d) => d.Division == 1);
                    if (firstD != null)
                    {
                        return firstD.BlocNumberOfWinners;
                    }
                }

                return 0;
            }
        }

        public string JackPot
        {
            get
            {
                if (Dividends.Any())
                {
                    var firstD = Dividends.First((d)=>d.Division==1);
                    if (firstD != null)
                    {
                        return "$"+String.Format("{0:n}", firstD.BlocDividend);
                    }
                }

                return "-";
            }
        }

    }
}
