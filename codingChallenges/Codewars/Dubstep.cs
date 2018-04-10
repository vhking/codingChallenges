using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace codingChallenges.Codewars
{
    public class Dubstep
    {
        public string SongDecoder(string input)
        {
            var tempResult = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'W')
                {
                    if (input[i + 1] == 'U')
                    {
                        if (input[i + 2] == 'B')
                        {
                            i += 2;
                            tempResult = tempResult + " ";
                        }
                        else
                        {
                            tempResult = tempResult + input[i];
                        }
                    }
                    else
                    {
                        tempResult = tempResult + input[i];
                    }
                }
                else
                {
                    tempResult = tempResult + input[i];
                }
            }
            var result = tempResult.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return string.Join(" ", result);
        }

        public string SongDecoderRF(string input)
        {
            var tempResult = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'W' && input[i + 1] == 'U' && input[i + 2] == 'B')
                {
                    i += 2;
                    tempResult = tempResult + " ";
                }
                else
                {
                    tempResult = tempResult + input[i];
                }
            }
            var result = tempResult.Split(' ')
                                   .Select(e => e.Trim())
                                   .Where(e => !string.IsNullOrEmpty(e));

            return string.Join(" ", result);
        }

        public string SongDecoderBPCleaver(string input)
        {
            return Regex.Replace(input, "(WUB)+", " " ).Trim();
        }
    }
}