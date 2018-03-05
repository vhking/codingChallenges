using System;
using System.Linq;

namespace codingChallenges.CodeWars
{
    /**
        Build Tower by the following given argument:
        number of floors (integer and always greater than 0).

        Tower block is represented as *

        Have fun!

        for example, a tower of 3 floors looks like below

        [
        '  *  ', 
        ' *** ', 
        '*****'
        ]

        and a tower of 6 floors looks like below

        [
        '     *     ', 
        '    ***    ', 
        '   *****   ', 
        '  *******  ', 
        ' ********* ', 
        '***********'
        ]

     */

    public class BuildTower
    {

        // Best practic verison of the challenge
        public string[] TowerBuilderBP(int nFloors)
        {
            var result = new string[nFloors];
            for (int i = 0; i < nFloors; i++)
                result[i] = string.Concat(new string(' ', nFloors - i - 1),
                                          new string('*', i * 2 + 1),
                                          new string(' ', nFloors - i - 1));
            return result;
        }

        public static string[] TowerBuilder(int nFloors)
        {

            string[] tower = new string[nFloors];
            // starts with the botton floor
            int currentFloor = nFloors;
            // starts with 0 spaces on the botton floor
            int spacesInt = 0;
            // will hold whitespace characters            
            string spaces;

            //starts on the end of the array
            for (int i = nFloors - 1; 0 <= i; i--)
            {
                // holdes number of stars on current floor
                int stars = i + currentFloor; 
                // Repeats * (stars)
                string floorStar = String.Concat(Enumerable.Repeat("*", stars));
                // Repeats ' ' (whitespace characters)
                spaces = String.Concat(Enumerable.Repeat(" ", spacesInt));

                // First increment check /w outs spaces 
                if (i == nFloors - 1)
                {
                    tower[i] = String.Format("{0}", floorStar);
                }
                else
                {
                    tower[i] = String.Format("{0}{1}{2}", spaces, floorStar, spaces);
                }
                // first increment check 
                if (spacesInt == 0)
                {
                    spacesInt = ((stars - stars) + 2) / 2;
                }
                else
                {
                    spacesInt = spacesInt + 1;
                }                
                currentFloor--;
            }
          
            return tower;
        }
    }
}