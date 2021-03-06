using System;
using System.Collections.Generic;
using System.Linq;

namespace codingChallenges.ProjectEuler
{
    // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
    // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
    public class EvenFibonacciNumbers
    {

        public void EvenFibonacciSquence4M()
        {
            List<int> intList = new List<int>();

            bool fibonacciSquence = true;            
             // first value of the addition
            int i = 1;
            // second value of the addition
            int j = 1;           
            // Holds the temp value from i+j
            int k = 0;

            while (fibonacciSquence)
            {
                k = i + j;

                if (k % 2 == 0)
                {
                    intList.Add(k);
                }                

                i = j;               
                j = k;
                             
                if (i > 4000000)
                {
                    fibonacciSquence = false;
                }
            }

            Console.WriteLine("the sum of the even-valued terms = " + intList.Sum());
        } 

        // Simplified version
         public void EvenFibonacciSquence4MSimplified()
        {
            // Holds the sum of the even-valued terms
            int sum = 0;

            // first value of the addition
            int i = 1;
            // second value of the addition
            int j = 1;           
            // Holds the temp value from i+j
            int k = 0;
            
            // Fibonacci squence limit
            int limit = 4000000;
            // while k is lower than the limit the while loop will continue.
            while (k<limit)
            {
                k = i + j;
                if (k % 2 == 0){ sum += k;}
                i = j;               
                j = k;
            }

            Console.WriteLine("the sum of the even-valued terms = " + sum);
        } 


    }
}