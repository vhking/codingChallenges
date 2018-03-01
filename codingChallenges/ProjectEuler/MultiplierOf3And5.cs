using System;
using System.Collections.Generic;
using System.Linq;

namespace codingChallenges.ProjectEuler
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, 
    // we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.
    public class MultiplierOf3And5
    {
        // Check of the first statement in the challenge .
        public void naturalNumbersBelow10()
        {
            // goes from 1 to 9
            for (int i = 1; i < 10; i++)
            {
                // natural numbers that multiplies of 3
                // the mod operation finds the rest. If the rest is 0 
                // the number is a natural number
                bool multipliesOf3 = i % 3 == 0;
                bool multipliesOf5 = i % 5 == 0;
                if (multipliesOf3)
                {                    
                    Console.Write(i + " Multiplies of 3 -> " + multipliesOf3);

                }else if (multipliesOf5)
                {
                    Console.Write(i +" Multiplies of 5 -> " + multipliesOf5);
                }else
                {
                    Console.Write(" "+ i);
                }                
            }
        }

        // Solution to the challenge
        public void naturalNumbersBelow1000()
        {
            List<int> naturalNumberList = new List<int>();
            int sum = 0;
            // goes from 1 to 999
            for (int i = 1; i < 1000; i++)
            {
                // natural numbers that multiplies of 3
                // the mod operation finds the rest. If the rest is 0 
                // the number is a natural number
                bool multipliesOf3 = i % 3 == 0;
                bool multipliesOf5 = i % 5 == 0;
                if (multipliesOf3)
                {                    
                    naturalNumberList.Add(i);
                    Console.Write(" + " + i);                    
                    //Console.Write("Multiplies of 3 -> " + multipliesOf3);

                }else if (multipliesOf5)
                {
                    naturalNumberList.Add(i);
                    Console.Write(" + " + i);
                    //Console.Write("Multiplies of 5 -> " + multipliesOf5);
                }else
                {
                    //Console.Write(i);
                }                
            }
            // Sums the values in the list with the help of Linq.
            Console.WriteLine(" = " + naturalNumberList.Sum());
            // multiplies all the values in the list
            foreach(var item in naturalNumberList)
            {sum+= item;}
            Console.WriteLine(" = " + sum);
        }

        public int naturalNumbersBelow1000Simplified()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}