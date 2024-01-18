using System;
using mission2;

// Kendrick Davis
// IS 413 
// Team 3-8
// Description: This program simulates the rolling of 2 dice and displays the percentage that each number was rolled.

internal class Program
{
    private static void Main(string[] args)
    {
        // Introductory text and asking the use how many dice they would like to roll.
        System.Console.WriteLine("Welcome to the dice throwing simulator! \n");
        System.Console.Write("How many dice rolls would you like to simulate?");

        // Creating a new variable to store the number of rolls the user would like to do.
        int numRolls = int.Parse(System.Console.ReadLine());

        // Create an array of integers that will be the array passed from my dice rolling function.
        int[] rollResults = RollDice.DiceRolling(numRolls);

        // Display the text for the final results of the rolls.
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine($"Total number of rolls = {numRolls}.\n");

        // Create a variable that will hold my string output.
        string output = "";

        // For loop that will calculate percentages and allocate astricks/stars.
        for (int iCount = 2; iCount < 13; iCount++)
        {
            float PercentOfTotal = rollResults[iCount] * 100 / numRolls;
            string StringOfStars = new string('*', (int)Math.Round(PercentOfTotal));

            output += $"{iCount}: {StringOfStars}\n";
        }

        // Write my output variable to the console.
        System.Console.WriteLine(output);
    }
}