using System;
using System.Collections.Generic;
using System.Linq;

namespace codingChallenges.ProjectEuler
{
    /**
        The prime factors of 13195 are 5, 7, 13 and 29.
        What is the largest prime factor of the number 600851475143 ?
     */
    public class LargestPrimeFactor
    {
        
        public void FindLargestPrimeFactor()
        {   
            
            long testNum = 600851475143;
            int largestFactor = 0;           
            long loopMax = 174251701;
            for (int i = 3; i*i <= 174251701; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {                         
                        isPrime = false;
                        break;
                    }
                    
                }
                if (isPrime && testNum % i == 0)
                {
                    Console.WriteLine("prime factor " + i);
                    largestFactor = i;
                    loopMax = (testNum / i) + 1;
                }                
            }

            Console.WriteLine("result is : " + largestFactor);
        }

    }
    
}