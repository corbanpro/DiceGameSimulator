using System;

namespace DiceGameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //declare variables
            int numRolls = 0;
            int[] rollTotals = new int[11];
            string[] rollPercent = new string[11];

            // Print game instructions
            Console.Write("Welcome to the dice throwing simulator! \n\nHow many dice rolls would you like to simulate? ");
            numRolls = Convert.ToInt32(Console.ReadLine());

            //roll dice and fill rollTotals array with the data
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1, 7);
                int sumRolls = roll1 + roll2;

                rollTotals[sumRolls - 2]++;
            }

            // determine what percent of rolls were each value 2-12
            for (int i = 0; i < rollTotals.Length; i++)
            {
                rollPercent[i] = new String('*', ((rollTotals[i] * 100) / numRolls));
            }

            //print results of the dice roll simulation
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \" * \" represents 1 % of the total number of rolls.\nTotal number of rolls = " + numRolls + '\n');
            
            // print the asterisks
            for (int i = 0; i < rollPercent.Length; i++)
            {
                Console.WriteLine((i + 2) + ": " + '\t' + rollPercent[i]);
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

        }
    }
}

