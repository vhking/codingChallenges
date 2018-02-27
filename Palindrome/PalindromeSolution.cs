using System;

namespace codingChallenges.Palindrome
{
    /**
    A palindrome is a word that reads the same backward or forward!
    Write a fucntion that checks if a given word is a palindrome
    Character case should be ignored.
    */
    class PalindromeSolution
    {
        public bool Palindrome(string word)
        {
            // The substring starts at a specified character position and has a specified length.
            string firstHalf = word.Substring(0, word.Length / 2).ToLower();
            //Console.WriteLine("first halft of the word: "+firstHalf);
            // the word in a char array
            char[] wordToCharArray = word.ToCharArray();
            // reverse the word
            Array.Reverse(wordToCharArray);
            // makes a new string out of the revered word
            string temp = new string(wordToCharArray);
            string secondHalf = temp.Substring(0, temp.Length /2).ToLower();
            //Console.WriteLine("second reversed half of the word: " + secondHalf);
            // return true if the first half and the reversed second half are equal
            // which proves the word is palindrome
            return firstHalf.Equals(secondHalf);
        }

        public bool PalindromeWhile(string word)
        {   
            // makes the word non case sensitive
            string newWord = word.ToLower(); 
            // sets the index possision of the first letter in the word
            int f = 0;
            // sets the index possision of the last letter in the word
            int s = newWord.Length - 1;
            //loops through half the letters of the word
            while (f<s)
            {
                // The wile loops goes through the index possisions of 
                // the words from start and end to the middle.
                // This way half of the first letters of the word is compared 
                // to the reversed last half of the letters of the words  
                if (newWord[f] != newWord[s])
                {
                    Console.WriteLine("The word " + word + " is a palindrome: False");
                    return false;
                }
                // increment from 0 
                f++;
                // decrement from word.Length -1
                s--;
            }
            Console.WriteLine("The word " + word + " is a palindrome: True");
            return true;
        }
    }
}