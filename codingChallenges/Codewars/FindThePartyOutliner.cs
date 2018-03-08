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
     */
    public class FindThePartyOutliner
    {
        // horribel way to do it, but made me laught 
        // note to self: Learn to use Linq...
        public int Find(int[] integers)
        {
            int oddCount = 0;
            int evenCount = 0;
            // the rules are simple. There is only one out of place number
            // by counting them. It will be easy to know if it is a even or odd array
            foreach (var item in integers)
            {
                if (item % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            // return the N, based on the number of odd or even numbers in the array
            if (oddCount > evenCount)
            {
                foreach (var item in integers)
                {
                    if (item % 2 == 0)
                    {
                        return item;
                    }
                }
            }
            else
            {
                foreach (var item in integers)
                {
                    if (!(item % 2 == 0))
                    {
                        return item;
                    }
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
            var evenNumbers = integers.Where(integer => integer % 2 == 0);
            var oddNumbers = integers.Where(integer => integer % 2 == 1);
            return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
        }
    }
}