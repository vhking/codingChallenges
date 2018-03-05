using System;
using System.Linq;

namespace codingChallenges.CodeWars
{
    /**
        In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
        Example:
        Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
        Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
        Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
        Notes:
        All numbers are valid Int32, no need to validate them.
        There will always be at least one number in the input string.
        Output string must be two numbers separated by a single space, and highest number is first.
     */
    public class HighestAndLowest
    {
        public string HighAndLow(string numbers)
        {
            // removes whitespace characters
            var numArray = numbers.Split(' ');
            var maxNum = numArray[0]; 
            var minNum = numArray[0];
            for (int i = 0; i < numArray.Length; i++)
            {
                if (Int32.Parse(numArray[i]) > Int32.Parse(maxNum))
                {
                    maxNum = numArray[i];
                }
                if (Int32.Parse(numArray[i]) < Int32.Parse(minNum))
                {
                    minNum = numArray[i];
                }
            }
            var result = maxNum + " " + minNum;
            return result;
        }
    }
    
}

// function highAndLow(numbers){
//   var arr =numbers.split(' ');
//   var max = arr[0],min =arr[0];
//   for(var i = 0;i<arr.length;i++){
//     if(parseInt(arr[i]) > max){
//       max = arr[i];
//     }
//     if(parseInt(arr[i]) < min){
//       min = arr[i]
//     }
//   }
//   var result = max + ' ' + min;
//   return result;
// }