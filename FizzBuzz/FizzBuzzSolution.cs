using System;
using System.Collections.Generic;

namespace codingChallenges.FizzBuzz
{
    /**
       Write a short program that prints each number from 1 to 100 on a new line. 
        For each multiple of 3, print "Fizz" instead of the number. 
        For each multiple of 5, print "Buzz" instead of the number. 
        For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.   
     */
    class FizzBuzzSolution{

       public enum FizzBuzzWords {Fizz, Buzz, FizzBuzz}    
       public void FizzBuzz()
       {
           for (int i = 1; i < 101; i++)
           {
               // To check that a number multiplies with one of the given numbers
               // we can use the % operator which represent "mod" in math. 
               // If the numbers mulitiplies there will be a rest of 0. 
               bool fizz = i % 3 == 0;
               bool buzz = i % 5 == 0;
            
               // The if statements should start with the most spesific to most generic
               if (fizz && buzz)
               {
                   Console.Write(" FizzBuzz");
               }else if(buzz)
               {
                   Console.Write(" Fizz");
               }else if (fizz && buzz)
               {
                   Console.Write(" Buzz");
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
               if (i % 3 == 0 && i % 5 == 0)
               {
                   fizzBuzz[i] = " FizzBuzz";
               }else if (i % 3 == 0)
               {
                   fizzBuzz[i] = " Bizz";
               }else if (i % 5 == 0)
               {
                   fizzBuzz[i] = " Fizz";
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

       public void FizzBuzzList()
       {
           List<string> fizzBuzzList = new List<string>();
          
           for (int i = 1; i < 101; i++)
           {
               bool fizz = i % 3 == 0;
               bool buzz = i % 5 == 0;
               bool fizzbuzz = i % 3 == 0 && i % 5 == 0;
               
               if (fizzbuzz)
               {
                    fizzBuzzList.Add(" FizzBuzz");                   
               }else if (fizz)
               {
                   fizzBuzzList.Add(" Fizz");
               }else if (buzz)
               {
                   fizzBuzzList.Add(" Buzz");
               }else
               {   
                   //makes the integer a string with an extra space on the left
                   fizzBuzzList.Add(" " + i);                   
               }
             
           }

           foreach (var item in fizzBuzzList)
           {
               Console.Write(item);
           }
       }
    }    
}