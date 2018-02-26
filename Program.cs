using System;
using codingChallenges.FizzBuzz;

namespace codingChallenges
{
    class Program
    {
        private static FizzBuzzSolution _fizzBuzzSolution = new FizzBuzzSolution();

      
        static void Main(string[] args)
        {
            // Call the induvidual coding challanges
            Console.WriteLine("Coding Challange: FizzBuzz");
            _fizzBuzzSolution.FizzBuzz();
            _fizzBuzzSolution.FizzBuzzArray();
            Console.WriteLine("\r\n***********************************");

        }
    }
}
