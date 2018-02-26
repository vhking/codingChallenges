using System;

namespace codingChallenges.FizzBuzz
{
    /**
        Write a program that prints the numbers from 1 to 100. But for multiples 
        of three print “Fizz” instead of the number and for the multiples of five 
        print “Buzz”. For numbers which are multiples of both three and five print 
        “FizzBuzz”."   
     */
    class FizzBuzzSolution
    {
       public void FizzBuzz()
       {
           for (int i = 1; i < 101; i++)
           {
               // To check that a number multiplies with one of the given numbers
               // we can use the % operator which represent "mod" in math. 
               // If the numbers mulitiplies there will be a rest of 0. 
               bool fizz = i % 3 == 0;
               bool buzz = i % 5 == 0;

               if (fizz)
               {
                   Console.Write(" Fizz");
               }else if(buzz)
               {
                   Console.Write(" Buzz");
               }else if (fizz && buzz)
               {
                   Console.Write(" FizzBuzz");
               }else
               {
                   //print number with space on the left
                   Console.Write(" " + i);
               }

           }
       }

       public void FizzBuzzArray()
       {
           string[] fizzBuzz = new string[101];

           for (int i = 1; i <= 100; i++)
           {
               if (i % 3 == 0)
               {
                   fizzBuzz[i] = " Fizz";
               }else if (i % 5 == 0)
               {
                   fizzBuzz[i] = " Bizz";
               }else if (i % 5 == 0 && i % 3 == 0)
               {
                   fizzBuzz[i] = " FizzBuzz";
               }else
               {
                   fizzBuzz[i] =  " " + i;
               }
           }

           foreach (var item in fizzBuzz)
           {
               Console.Write(item);
           }

       }
    }    
}