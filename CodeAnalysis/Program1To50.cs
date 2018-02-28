using System;
using System.Text;


//TODO: move it its own project
namespace codingChallenges.CodeAnalysis
{
    // Q50 - What will be the output of the following code snippet?
    // A50 = "135"
    public class Program50
    {
        public void Main50()
        {
            // Empty string
            String str = "";
    
            StringBuilder sb1 = new StringBuilder("TechBeamers");
            StringBuilder sb2 = new StringBuilder("TechBeamers");
            StringBuilder sb3 = new StringBuilder("Welcome");
            // sb4 the same as sb3
            StringBuilder sb4 = sb3;

            // True - 1
            if (sb1.Equals(sb2)) str += "1";
            // False
            if (sb2.Equals(sb3)) str += "2";
            // true - 3
            if (sb3.Equals(sb4)) str += "3";
 
 
            String str1 = "TechBeamers";
            String str2 = "Welcome";
            String str3 = str2;

            // false   
            if (str1.Equals(str2)) str += "4";
            // true - 5
            if (str2.Equals(str3)) str += "5";
            // prints "135"
            Console.WriteLine(str);
        }
    }

    // Q49 - Wha will be the Output of the Following Code Snippet
    // A49 = HI - not sure why
    //       209
    public class Program49
    {
        public void Mai49n()
        {
            // string "H" + char 'I'
            Console.WriteLine("H" + 'I');
            // char 'h' + char 'i' 
            Console.WriteLine('h' + 'i');
        }
    }

    // Q48 - What will be the Output of the folloing code snippet?
    // A48 - The last one will be printed
    //     = "doubl array argument"
    public class Program48
    {
        public Program48(Object o)
        {
            Console.WriteLine("Object argument");
        }
        public Program48(double[] arr)
        {
            // Code execute at the top and goes down
            // the last instance of Program48 will be printed
            Console.WriteLine("double array argument");
        }
        public static void Main48(string[] args)
        {
            new Program48(null);
        }
    }

     // Q47 - What will be the Output of the folloing code snippet?
     // A47 - The check is false because the answer 
     // between of num1 - numb2 is not 1,0 but 1
     class Program47
    {
        void Main47()
        {
            double num1 = 1.000001;
            double num2 = 0.000001;
            // 1,000001 - 0,000001 = 1 -> 1 == 1,0 isFalse
            Console.WriteLine((num1 - num2) == 1.0);
        }
    }    

}