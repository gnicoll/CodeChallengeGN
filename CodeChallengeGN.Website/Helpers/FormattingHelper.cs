using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeGN.Website.Helpers
{
    public static class FormattingHelper
    {
        public static string FloatToDollarString(float value = 0)
        {
            return "$" + String.Format("{0:n}", value);
        }
    }
}
