using System;
using System.Collections.Generic;

namespace codingChallenges.UserInput
{
    /**
    User interface contains two types of user input controls: 
    TextInput, which accepts all characters amd NumericInput, Which accepts only 
    digits
    Implements the class TextInput that contains:
        * Public method void Add(char c) - adds the given character to the current value
        * Public method string GetValue() - returns the current value

    Implement the class NumericInput that:
        * Inherits TextInput
        * Overrides the Add method so that each non-numeric character is ignored.

    For example, the following code should output "10":

    TextInput input = new NumericInput();
    input.Add('1');
    input.Add('a');
    input.Add('0');
    Console.WriteLine(input.GetValue());
    */
    public class TextInput
    {
        // list to holde the values
        public List<char> charList = new List<char>();
        
        // The virtual Add mmethod makes it possible to override it
        // and provide its one functionaility
        public virtual void Add(char c)
        {
            charList.Add(c);
        }

        public string GetValue()
        {
            string es = ""; 
            foreach (var item in charList)
            {
                // The items in the collection are of the char type
                // It must be made a string so we can return it.
                es = es + item;       
            }

            return es;
        }        

    }

    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            // checks if the char input is of an numeric type
            // if not c is lower then 0
            // &&
            // if not c is higher or the same as 9
            if (!(c < '0') && !(c >= '9'))
            {
                charList.Add(c);

            }else
            {
                //charList.Add(c);
            }
        }

    }

    public class UserInputSolution
    {             
        public void UserInterface()
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }          
    }

}