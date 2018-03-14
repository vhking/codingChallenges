using System.Linq;

namespace codingChallenges.CodeWars
{
    /*
        The input is a string str of digits. Cut the string into chunks 
        (a chunk here is a substring of the initial string) of size sz 
        (ignore the last chunk if its size is less than sz).

        If a chunk represents an integer such as the sum of the cubes of its digits is divisible by 2,
        reverse that chunk; otherwise rotate it to the left by one position. Put together these modified 
        hunks and return the result as a string.

        If
        sz is <= 0 or if str is empty return ""
        sz is greater (>) than the length of str it is impossible to take a chunk of size sz hence return "".

        Examples:
        revrot("123456 987654", 6) --> "234561 876549"
        revrot("123456 987653", 6) --> "234561 356789"
        revrot("66443875", 4) --> "44668753"
        revrot("66443875", 8) --> "64438756"
        revrot("664438769", 8) --> "67834466"
        revrot("123456779", 8) --> "23456771"
        y revrot("", 8) --> ""
        y revrot("123456779", 0) --> "" 
        revrot("5630 00655 7344 6948 5", 4) --> "0365 0650 7345 6944"

     */
    public class ReverseOrRotate
    {
        public string RevRot(string str, int size)
        {
            //makes the string a number list
            var numList = str.Select(digi => int.Parse(digi.ToString()));
            // Variable to holde the chunck sum
            var sum = 0;
            // Variable to holde the count until it reaches the value of 'size'
            var count = 1;
            // holds the temp string chuncks  
            var chunckTemp = "";   
            var result = "";  
            // if this checks fails an empty result string will be returned 
            if (str != string.Empty || size != 0)
            {
                foreach (var item in numList)
                {
                    //adds the items
                    sum += item;
                    // adds the numbers to a new string
                    chunckTemp = chunckTemp + item;                  
                    if (count == size)
                    {   
                        if (sum % 2 == 0) // reverse it
                        {
                            var chunckReverse = chunckTemp.Select(digi => int.Parse(digi.ToString())).ToList();
                            chunckReverse.Reverse();
                            result = result + string.Join("", chunckReverse);

                            chunckTemp = "";
                            sum = 0;
                                                      
                                                       
                        }else // Rotate it to the left by one position
                        {
                            var chunckRotate = chunckTemp.Select(digi => int.Parse(digi.ToString())).ToList();
                            var first = chunckRotate.First(); 
                            chunckRotate.RemoveAt(0);
                            chunckRotate.Insert(chunckTemp.Length -1,first);

                            result = result + string.Join("", chunckRotate);

                            chunckTemp = "";
                            sum = 0;
                        }                        
                        count = 0;                        
                    }
                    count++;
                }                
            }
            return result;
        }
    }
}