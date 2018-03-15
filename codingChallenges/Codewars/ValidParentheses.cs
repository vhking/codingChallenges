namespace codingChallenges.CodeWars
{
    /*
        Write a function called that takes a string of parentheses, 
        and determines if the order of the parentheses is valid. 
        The function should return true if the string is valid, 
        and false if it's invalid.
        Examples

        "()"              =>  true
        ")(()))"          =>  false
        "("               =>  false
        "(())((()())())"  =>  true
        "()()()()()()()"  => true
        "())()()()()()(()" => false

Constraints

0 <= input.length <= 100

Along with opening (() and closing ()) parenthesis, input may contain any valid ASCII characters. 
Furthermore, the input string may be empty and/or not contain any parentheses at all. 
Do not treat other forms of brackets as parentheses (e.g. [], {}, <>).

     */
    public class ValidParentheses
    {
        public bool FindValidParentheses(string input)
        {            
            char[] charArray = input.ToCharArray();
            var leftParentheseCount = 0;
            var rightParantheseCount = 0;
            if (charArray.Length == 0)
            {
                return true;
            }
            foreach (var item in charArray)
            {
                // counts left parenthese
                if (item.Equals('('))
                {
                    leftParentheseCount++;
                }
                // counts right parenthese
                if (item.Equals(')'))
                {
                    rightParantheseCount++;
                }

                // if the count of the left and right paranthese is equal
                // then a single or a series of paranthese are closed
                if (leftParentheseCount == rightParantheseCount)
                {  
                    // starts over again to check the rest of the array                 
                    leftParentheseCount = 0;
                    rightParantheseCount = 0;

                }
                // if a right paranthese is the first in parenthese in a sequence
                // the the result is invalid so it returns false
                else if (rightParantheseCount > leftParentheseCount)
                {
                    return false;
                }

            }
            // The count after the loop should be equal
            if (rightParantheseCount != leftParentheseCount)
            {
                return false;
            }
            return true;
        }

        // Best practice
        public static bool FindValidParenthesesBP(string input)
        {
            int parentheses = 0;
            foreach (char t in input)
            {
                if (t == '(')
                {
                    parentheses++;
                }
                else if (t == ')')
                {
                    parentheses--;

                    if (parentheses < 0)
                    {
                        return false;
                    }
                }
            }

            return parentheses == 0;
        }

    }
}