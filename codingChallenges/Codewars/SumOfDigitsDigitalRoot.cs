using System.Linq;

namespace codingChallenges.CodeWars
{
    public class SumOfDigitsDigitalRoot
    {
        // Not recomended solution, but works. Need refactoring.
        public int DigitalRoot(long n)
        {
            var result = 0;
            var tempSum = 0;
            // While loop condition
            bool notRoot = true;
            var count = 0;
            // makes the number into a int array
            var numList = n.ToString()
                           .Select(digit => int.Parse(digit.ToString()))
                           .ToArray();

            while (notRoot)
            {
                // sums up the number in the list
                tempSum += numList[count];
                // true when the list is at its end
                if (count == numList.Length - 1)
                {
                    // true if the sum is a single number
                    if (tempSum.ToString().Length == 1)
                    {
                        // updates the result variable 
                        // and fulfill the while loop condition
                        result = tempSum;
                        notRoot = false;
                    }
                    else
                    {
                        // makes a new list from the sum of the former list
                        numList = tempSum.ToString()
                                 .Select(digit => int.Parse(digit.ToString()))
                                 .ToArray();
                        // starts every thing over again until the while loop
                        // condition has been fulfilled
                        count = -1;
                        tempSum = 0;
                    }
                }
                count++;
            }
            return result;
        }

        // Mathematically very clever
        // But not best practice. Because it 
        // can be hard to understand what it does.
        public int DigitalRootClever(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }

        //Best practice with recursion!
        public int DigitalRootBP(long n)
        {
            if (n < 10) return (int)n;
            long r = 0;
            while (n > 0)
            {
                r += n % 10;
                n /= 10;
            }
            return DigitalRootBP(r);
        }

        // Refactored version. using recursion to make it a bit faster
        //
        /*
            Clever : 00:00:03.50 #0
            BP     : 00:00:03.52 #1
            RF     : 00:00:04.94 #2
            first  : 00:00:05.39 #3
            
         */
        public int DigitalRootRF(long n)
        {
            if (n < 10)
            {
                return (int)n;
            }
            var result = 0;
            bool notRoot = true;
            var numList = n.ToString()
                           .Select(digit => int.Parse(digit.ToString()));

            while (notRoot)
            {
                result = numList.Sum();
                if (result.ToString().Length == 1)
                {    
                    notRoot = false;
                }
                else
                {      
                    return DigitalRootRF(result);
                }
            }
            return result;
        }
    }
}