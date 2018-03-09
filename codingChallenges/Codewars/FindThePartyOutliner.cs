using System.Collections.Generic;
using System.Linq;

namespace codingChallenges.CodeWars
{
    /**
        You are given an array (which will have a length of at least 3, but could be very large)
        containing integers. The array is either entirely comprised of odd integers or entirely
        comprised of even integers except for a single integer N. Write a method that takes the
        array as an argument and returns this "outlier" N.
        Examples:
        [2, 4, 0, 100, 4, 11, 2602, 36]
        Should return: 11 (the only odd number)

        [160, 3, 1719, 19, 11, 13, -21]
        Should return: 160 (the only even number)

        2, 6, 8, -10, 3
        3
     */
    public class FindThePartyOutliner
    {
        // horribel way to do it, but made me laught
        // Bg pluss : it will as a maximum iterate through the array once.
        // and optimaly when it it has found the N
        // note to self: Learn to use Linq...
        public int Find(int[] integers)
        {
            int oddCount = 0;
            int evenCount = 0;
            int oddNumbers = 0;
            int evenNumbers = 0;
            foreach (var item in integers)
            {
                // checks if the number is even
                if (item % 2 == 0)
                {
                    evenCount++;
                    evenNumbers = item;                  
                }
                else // checks if the number is odd
                {
                    oddCount++;
                    oddNumbers = item;                    
                }
                // Makes sure the return the outliner when its found
                if (evenCount > oddCount && oddNumbers != 0)
                {
                    return oddNumbers;
                }if (oddCount > evenCount && evenNumbers != 0)
                {
                    return evenNumbers;
                }

            }
            // The return is required by the compiler, but only gets called if there are
            // no even in a odd array or vice versa
            return 0;
        }

        // Best practice
        public static int FindBP(int[] integers)
        {
            // Uses Linq
            /*Though the solution looks good. It itirate through the array twice.
              Which would be a problem if the array was huge*/
            var evenNumbers = integers.Where(integer => integer % 2 == 0);
            var oddNumbers = integers.Where(integer => integer % 2 == 1);
            return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
        }
    }
}