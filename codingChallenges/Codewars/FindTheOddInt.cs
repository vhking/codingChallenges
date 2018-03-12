using System;
using System.Linq;

namespace codingChallenges.CodeWars
{
    public class FindTheOddInt
    {
        /*
            Given an array, find the int that appears an odd number of times.
            There will always be only one integer that appears an odd number of times.
         */
        // 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5
        public int Find(int[] seq)
        {
            // the sort can possibly make the prosess faster             
            Array.Sort(seq);
            // holds the count
            var count = 0;
            var oddCountInt = 0;
            //Compere every int in the array to the other ints in the array
            for (int i = 0; i < seq.Length; i++)
            {
                for (int j = 0; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j])
                    {
                        count++;
                        // when the count is a odd number the variable is given that seq number
                        if (count % 2 == 1)
                        {
                            oddCountInt = seq[i];
                        }
                    }
                }
                // makes sure that the for loop stops when the oddIntCount has been found
                // this can be done because the challenge stat that an oddCount can only 
                // appear once.
                if (count % 2 == 1)
                {
                    // Break may be considered bad practice
                    // Insted of breaking the loop
                    // the oddCountInt could be returned.
                    break;
                }
                // if not the right oddint has been found
                // the count is set to 0 again
                count = 0;
            }
            return oddCountInt;
        }

        //Best practices
        public static int FintBP(int[] seq)
        {
            return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
        
        // Cleaver, but not best practice
        // because it can be hard to understand what it does.
         public static int FindClever(int[] seq)
        {
            int found = 0;
            // If you will xor 0 and any integer even times you will get 0. 
            // But if you will xor 0 and integer odd times then you will get your integer.
            foreach (var num in seq)
            {
                found ^= num;
            }

            return found;
        }
    }

}