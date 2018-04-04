using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace codingChallenges.Tests
{
    public class SimpleIdValidation
    {
        public bool Validatione(string id)
        {
            string tempstring = id.Replace(" ", "");
            Regex rgx = new Regex("---([A-Za-z0-9]{1,5})---");   //@"^[a-zA-Z0-9\s,]*$"
            MatchCollection matches = rgx.Matches(tempstring);
            if ((tempstring.Length >= 7) && (tempstring.Length <= 11))
            {
                if ((matches.Count >= 1) && (matches.Count <= 5))
                {
                    return true;  //rgx.IsMatch(tempstring);
                }
            }
            

            return false;
        }
    }
}