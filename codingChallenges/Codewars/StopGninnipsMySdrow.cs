using System;
using System.Globalization;
using System.Linq;

namespace codingChallenges.CodeWars
{
    /*
        Write a function that takes in a string of one or more words, 
        and returns the same string, but with all five or more letter 
        words reversed (Just like the name of this Kata). Strings passed 
        in will consist of only letters and spaces. Spaces will be included 
        only when more than one word is present.

        Examples:

        spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw"
        spinWords( "This is a test") => returns "This is a test"
        spinWords( "This is another test" )=> returns "This is rehtona test"
     */
    public class StopGninnipsMySdrow
    {
        public string SpinWords(string sentence)
        {


            var senteceList = sentence.Split(' ');
            var result = "";

            foreach (var item in senteceList)
            {
                if (item.Length > 4)
                {
                    var charArray = item.ToCharArray();
                    Array.Reverse(charArray);

                    if (result != string.Empty)
                    {
                        result = result + " " + string.Join("", charArray); ;
                    }
                    else
                    {
                        result = result + string.Join("", charArray);
                    }

                }
                else
                {
                    if (result != string.Empty)
                    {
                        result = result + " " + item;
                    }
                    else
                    {
                        result = result + item;
                    }
                }

            }

            return result;
        }
    }
}