﻿using System;
using System.Collections.Generic;
using codingChallenges.Codewars;
using codingChallenges.CodeWars;
using codingChallenges.FizzBuzz;
using codingChallenges.Palindrome;
using codingChallenges.ProjectEuler;
using codingChallenges.UserInput;
namespace codingChallenges
{
    class Program
    {
        private static FizzBuzzSolution _fizzBuzzSolution = new FizzBuzzSolution();
        private static PalindromeSolution _palindromeSolution = new PalindromeSolution();
        private static UserInputSolution _userInputSolution = new UserInputSolution();
        private static MultiplierOf3And5 _multiplierOf3And5 = new MultiplierOf3And5();
        private static EvenFibonacciNumbers _evenFibonaccciNumbers = new EvenFibonacciNumbers();
        private static LargestPrimeFactor _largetPrimeFactor = new LargestPrimeFactor();
        private static Dubstep _stop = new Dubstep();
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
            Console.WriteLine("\r\n***********************************");
            Console.WriteLine("");

            Console.WriteLine("Coding challange: UserInput");
            Console.Write("UserInput should print out 10. And it printed out -> ");
            _userInputSolution.UserInterface();
            Console.WriteLine("\r\n***********************************");
            Console.WriteLine("");

            Console.WriteLine("Coding Challenge : Multiplier of 3 and 5");
            Console.WriteLine("Natural numbers below 10");
            _multiplierOf3And5.naturalNumbersBelow10();
            Console.WriteLine("\r\nNatural numbers below 1000");
            _multiplierOf3And5.naturalNumbersBelow1000();
            Console.WriteLine("\r\n***********************************");
            Console.WriteLine("");

            Console.WriteLine("Coding Challenge : Even Fibonacci numbers");
            _evenFibonaccciNumbers.EvenFibonacciSquence4M();
            Console.WriteLine("\r\n***********************************");
            Console.WriteLine("");

            Console.WriteLine("Coding Challenge : Largest prime factor");
            _largetPrimeFactor.FindLargestPrimeFactor();
            Console.WriteLine("\r\n***********************************");
            Console.WriteLine("");

            // Console.WriteLine("Coding Challenge : blabla");
            // int[] numbers = {-1, 2, 10, 5, 100, -10, -100 , 0};
            // _sum.sumTwoSmallestNumbers(numbers);
            // Console.WriteLine("\r\n***********************************");            
            // Console.WriteLine("");

            //  Console.WriteLine("Coding Challenge : towerBuild");      

            var ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            Console.Write(_stop.SongDecoder("RWUBWUBWUBLWUB"));
            Console.WriteLine("\r\n***********************************");
            Console.WriteLine("");






        }
    }
}
