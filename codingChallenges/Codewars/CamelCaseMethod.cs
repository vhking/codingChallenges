using System;
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
            var upperCaseStr = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            // Removes the spaces
            var upperCaseStrArray = upperCaseStr.Split(' ');
            // Joins it to a single word with an Upper case letter at every single new word
            return string.Join("", upperCaseStrArray);

        }

        /*
            Complete the method/function so that it converts dash/underscore 
            delimited words into camel casing. The first word within the output 
            should be capitalized only if the original word was capitalized.

            Examples:

            // returns "theStealthWarrior"
            Kata.ToCamelCase("the-stealth-warrior") 

            // returns "TheStealthWarrior"
            Kata.ToCamelCase("The_Stealth_Warrior")
        */

        public static string ToCamelCase(string str)
        {
           
            var upperCaseStr = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
            var strArray = upperCaseStr.Split(' ', '-', '_');          
            var result = "";
            if (char.IsLower(str[0]))
            {
                var strJoin = string.Join("", strArray);
                result = Char.ToLowerInvariant(strJoin[0]) + strJoin.Substring(1);
                return result;
            }
            else
            {
                result = string.Join("", strArray);
                return result;
            }
        }
    }
}