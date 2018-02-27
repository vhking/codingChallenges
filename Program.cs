using System;
using codingChallenges.FizzBuzz;
using codingChallenges.Palindrome;

namespace codingChallenges
{
    class Program
    {
        private static FizzBuzzSolution _fizzBuzzSolution = new FizzBuzzSolution();
        private static PalindromeSolution _palindromeSolution = new PalindromeSolution();

      
        static void Main(string[] args)
        {
            // Call the induvidual coding challanges
            Console.WriteLine("Coding Challange: FizzBuzz");
            _fizzBuzzSolution.FizzBuzz();
            Console.WriteLine("\r\nfrom array:");
            _fizzBuzzSolution.FizzBuzzArray();
            Console.WriteLine("\r\nfrom list:");
            _fizzBuzzSolution.FizzBuzzList();
            Console.WriteLine("\r\n***********************************");
            Console.WriteLine("");
            Console.WriteLine("Coding Challange: Palindrome");
            Console.WriteLine("Array.Reverse:");
            Console.WriteLine("The word Vidarradiv is a palindrome : " + _palindromeSolution.Palindrome("Vidarradiv"));
            Console.WriteLine("While loop:");
            _palindromeSolution.PalindromeWhile("Vidarradiv");



        }
    }
}
