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
            var validParentheseCount = 0;
            if (charArray.Length == 0)
            {
                return true;
            }
            foreach (var item in charArray)
            {

                if (item.Equals('('))
                {
                    leftParentheseCount++;
                }
                if (item.Equals(')'))
                {
                    rightParantheseCount++;
                }

                if (leftParentheseCount == rightParantheseCount)
                {
                    validParentheseCount++;
                    leftParentheseCount = 0;
                    rightParantheseCount = 0;

                }
                else if (rightParantheseCount > leftParentheseCount)
                {
                    return false;
                }

            }
            if (rightParantheseCount != leftParentheseCount)
            {
                return false;
            }
            return true;
        }

    }
}