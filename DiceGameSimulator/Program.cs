using System;

namespace DiceGameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numRolls = 0;
            int[] rollArray = new int[11];
            string[] rollPercent = new string[11];

            Console.Write("Welcome to the dice throwing simulator! \n\nHow many dice rolls would you like to simulate? ");
            numRolls = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1, 7);
                int sumRolls = roll1 + roll2;

                rollArray[sumRolls - 2] = rollArray[sumRolls - 2] + 1;
            }

            for (int i = 0; i < rollArray.Length; i++)
            {
                rollPercent[i] = new String('*', ((rollArray[i] * 100) / numRolls));
            }

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \" * \" represents 1 % of the total number of rolls.\nTotal number of rolls = " + numRolls + '\n');

            for (int i = 0; i < rollPercent.Length; i++)
            {
                Console.WriteLine((i + 2) + ": " + '\t' + rollPercent[i]);
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

        }
    }
}

