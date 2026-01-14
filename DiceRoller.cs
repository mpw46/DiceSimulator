using System;
using System.Collections.Generic;
using System.Text;

namespace DiceSimulator
{
    internal class DiceRoller
    {
        public static int[] Roll(int numRolls)
        {
            // Initialize variables
            int num1 = 0;
            int num2 = 0;
            int total = 0;
            int[] counts = new int[13];

            // Simulate as many dice rolls as the user inputs and count in array
            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                num1 = Random.Shared.Next(1, 7);
                num2 = Random.Shared.Next(1, 7);
                total = num1 + num2;
                counts[total] = counts[total] + 1;
            }

            // Return the counts array
            return counts;
        }


    }
}
