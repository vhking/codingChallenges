using System;

namespace codingChallenges.CodeWars
{
    /**
        Define a function isPrime/is_prime() that takes one integer argument and 
        returns true/True or false/False depending on if the integer is a prime.
        Per Wikipedia, a prime number (or a prime) is a natural number greater 
        than 1 that has no positive divisors other than 1 and itself.
        Example

        Kata.IsPrime(5) => true

        Assumptions

        You can assume you will be given an integer input.
        You can not assume that the integer will be only positive. 
        You may be given negative numbers as well (or 0).

     */
    public class Prime
    {
        public bool IsPrime(int n)
        {
            if (n<2)
            {
                return false;
            }  

            int i = 2;

            while (i<=n/i)
            {
                if (n % i == 0)
                {
                    return false;
                }
                i++;
            } 
            return true;

        }

    }
}