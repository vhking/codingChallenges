using System.Linq;

namespace codingChallenges.CodeWars
{

    /*
       Write a function named firstNonRepeatingLetter† that takes a string input, 
       and returns the first character that is not repeated anywhere in the string.
       For example, if given the input 'stress', the function should return 't', 
       since the letter t only occurs once in the string, and occurs first in the string.
       As an added challenge, upper- and lowercase letters are considered the same character, 
       but the function should return the correct case for the initial letter. For example, 
       the input 'sTreSS' should return 'T'.

       If a string contains all repeating characters, it should return the empty string ("").
           † Note: the function is called firstNonRepeatingLetter for historical reasons, 
           but your function should handle any Unicode character.
    */

    public class FirstNonRepeatingLetter
    {
        // very inefficient 
        public string Find(string s)
        {   

            string result = "";
            // make a new string all in lower cased letters
            string newS = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                // compare
                // first occurrence of the specified string in this instance.
                // to the
                // last occurrence of a specified string within this instance.
                if (newS.LastIndexOf(newS[i]) == newS.IndexOf(newS[i]))
                {
                    // returns the index of the original string
                    result = s[i].ToString();
                    // the first non repeating letter is found
                    // the for loop is exited to make it more efficient
                    break;
                }
            }

            return result;
        }

        public string Find_w_Linq(string s)
        {
            // compare
            // first occurrence of the specified string in this instance.
            // to the
            // last occurrence of a specified string within this instance.
            // cons: 
            // not case sensitive
            // does not return empty string when none are found
            return s.FirstOrDefault(ch => s.IndexOf(ch) == s.LastIndexOf(ch)).ToString();
        }

        // Best practice 
        public string FindBP(string s)
        {
            // Groups every letter that is not repeated            
            // empty string if none are found
            // picks the first in the sequence and returnes it
            return s.GroupBy(char.ToLower)
           .Where(gr => gr.Count() == 1)
           .Select(x => x.First().ToString())
           .DefaultIfEmpty("")
           .First();
        }

    }
}