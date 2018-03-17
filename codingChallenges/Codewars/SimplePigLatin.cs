using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codingChallenges.CodeWars
{
    /*
        Move the first letter of each word to the end of it, then add "ay" 
        to the end of the word. Leave punctuation marks untouched.
        Examples

        Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
        Kata.PigIt("Hello world !");     // elloHay orldWay !


     */
    public class SimplePigLatin
    {
        public string PigIt(string str)
        {
            // Word array
            var splitStr = str.Split(' ');
            // make it a List<string> to harvest the benefits
            List<string> wordList = new List<string>(splitStr);
            // Will hold the result
            var result = "";

            foreach (var item in wordList)
            {   
                // Make the word into a char list 
                var charArray = item.ToList();
                // store the first element
                var first = charArray.First();
                // remove the first element
                charArray.RemoveAt(0);
                // insert value to the last spot in list
                charArray.Insert(charArray.Count, first);
                // makes a strig of he new word
                var newWord = string.Join("", charArray);
                // Gimmicky way to make sure the string is correct
                if (result != string.Empty)
                {
                    result = result + " " + newWord + "ay";
                }
                else
                {
                    result = newWord + "ay";
                }
            }
            return result;
        }

        // best practice
        public static string PigItBP(string str)
        {
            var words = str.Split(' ');
            var sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i].Substring(1));
                sb.Append(words[i][0]);
                sb.Append("ay ");
            }
            
            return sb.ToString().TrimEnd(' ');
        }
    }
}