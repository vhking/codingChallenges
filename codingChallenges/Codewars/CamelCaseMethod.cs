using System.Globalization;
using System.Linq;

namespace codingChallenges.CodeWars
{
    /*  
        Write simple .camelCase method (camel_case function in PHP or CamelCase in C#) for strings. 
        All words must have their first letter capitalized without spaces.

        For instance:
        "hello case".camelCase() => HelloCase
        "camel case word".camelCase() => CamelCaseWord
     */
    public static class CamelCaseMethod
    {
        public static string CamelCase(this string str)
        {
             // title casing converts the first character of a word to uppercase and the rest of the characters to lowercase. 
             var upperCaseStr = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
             // Removes the spaces
             var upperCaseStrArray = upperCaseStr.Split(' ');
             // Joins it to a single word with an Upper case letter at every single new word
             return string.Join("", upperCaseStrArray);

        }
    }
}