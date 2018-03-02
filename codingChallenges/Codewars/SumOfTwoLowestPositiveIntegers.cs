
using System;
using System.Collections.Generic;
using System.Linq;

namespace codingChallenges.CodeWars
{
    
    /**
        Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 integers.
        No floats or empty arrays will be passed.
        For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
        [10, 343445353, 3453445, 3453545353453] should return 3453455.
           Hint: Do not modify the original array.
           array {5, 8, 12, 19, 22};
    */
    public class SumOfTwoLowestPositiveIntegers
    {
	    public int sumTwoSmallestNumbers(int[] numbers)
	    {
          List<int> negativeNumberList = new List<int>();
          List<int> positiveNumberList = new List<int>();

          foreach (var item in numbers)
          {
              if (item < 0)
              {
                  negativeNumberList.Add(item);
              }
              else
              {
                  positiveNumberList.Add(item);
              }
          }
            positiveNumberList.Sort();
            //int result = 0;
            int firstValue = positiveNumberList[0];
            int secondValue = positiveNumberList[1];

           

         
            //int tempValue = 0;
            foreach (var item in positiveNumberList)
            {
                       
                    if (item < firstValue)
                    {
                        Console.WriteLine(secondValue + " " + item);
                        firstValue = item;     
                                 
                    } 
                    if (firstValue < secondValue && item != firstValue && item < secondValue)
                    {
                    
                         Console.WriteLine(secondValue + " " + item);
                         secondValue = item;
                    }      
                      
            }
          
            Console.WriteLine(firstValue + " " + secondValue);
		    return firstValue + secondValue;
	    }

         public int sumTwoSmallestNumbersLinq(int[] numbers)
         {
             return numbers.OrderBy(o=> o).Take(2).Sum();
         }
    }
    

}

