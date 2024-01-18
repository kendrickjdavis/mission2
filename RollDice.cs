using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    internal class RollDice
    {
        public static int[] DiceRolling(int numRolls)
        { 
            // Create a new random object so I can use it later on.
            Random r = new Random();

            // Create an array of integers that is 13 long so that I can store values from 2-12
            int[] rollResults = new int[13];

            // For loop that rolls both dice and then adds the values of the rolls together.
            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                // Rolls both dice
                int Die1 = r.Next(1, 7);
                int Die2 = r.Next(1, 7);

                // Calculates sum
                int Sum = Die1 + Die2;

                // Increments the value in the array
                rollResults[Sum]++;
            }

            // Returns the array back to the program.
            return rollResults;

        }
    }
}
