using System.Linq;

namespace codingChallenges.CodeWars
{
    /**
        Write a function, persistence, that takes in a positive parameter num and returns its multiplicative 
        persistence, which is the number of times you must multiply the digits in num until you reach a single digit.
        For example:
        persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
                      // and 4 has only one digit

        persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
                       // 1*2*6 = 12, and finally 1*2 = 2

        persistence(4) == 0 // because 4 is already a one-digit number
     */
    public class PersistentBugger
    {
       public int Persistence(long n) 
	    {           
            string tempNum = n.ToString();
            // makes the number into a list
            var intList = tempNum.Select(digit => int.Parse(digit.ToString()));
           
            int count = 0;
            long sum = n;         
            
            while (sum >= 10)
            {       
                // set sum to 1 so the first number in the list don't change        
                sum= 1; 
                foreach (var item in intList) // 39
                {                    
                    sum *= item; // 1                    
                }
                string sumString = sum.ToString();
                // creats new list based on the new sum
                intList = sumString.Select(digit => int.Parse(digit.ToString()));   
                ++count; 
            }
            return count;
	    }

        // best practice
        public int PersistenceBP(long n)
        {
            int count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }
         return count;
        }

    }
}