using System;


namespace codingChallenges.CodeWars
{
    /**
        Implement a function that adds two numbers together and returns their sum in binary. 
        The conversion can be done before, or after the addition.
        The binary number returned should be a string.
     */
    public class BinaryAddition
    {
        public string AddBinary(int a, int b)
        { 
            // Converts the value of a+b to binary            
            var result  = Convert.ToString(a+b, 2);
            return result;
        }
    }

}
