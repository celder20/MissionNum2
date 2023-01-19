using System;

namespace MissionNum2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the dice throwing simulator!" + "\n");
            //Ask the user how many times they want to roll the pair of dice; store this number in userNum
            Console.Write("How many dice rolls would you like to simulate? ");
            int userNum = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + userNum + "\n");

            //Variables that will hold how many times this total number is seen
            decimal two = 0;
            decimal three = 0;
            decimal four = 0;
            decimal five = 0;
            decimal six = 0;
            decimal seven = 0;
            decimal eight = 0;
            decimal nine = 0;
            decimal ten = 0;
            decimal eleven = 0;
            decimal twelve = 0;

            //Generate a random number that will be used for how many times numbers are rolled
            Random r = new Random();

            //Array to store how many times we see each total number when the two dice are rolled
            int[] totalNum = new int[userNum];

            //For loop to store how many instances of each number occurs
            for (int i = 0; i < userNum; i++)
            {
                totalNum[i] = ((r.Next(6) + 1) + (r.Next(6) + 1));

                if (totalNum[i] == 2)
                {
                    two++;
                }
                if (totalNum[i] == 3)
                {
                    three++;
                }
                if (totalNum[i] == 4)
                {
                    four++;
                }
                if (totalNum[i] == 5)
                {
                    five++;
                }
                if (totalNum[i] == 6)
                {
                    six++;
                }
                if (totalNum[i] == 7)
                {
                    seven++;
                }
                if (totalNum[i] == 8)
                {
                    eight++;
                }
                if (totalNum[i] == 9)
                {
                    nine++;
                }
                if (totalNum[i] == 10)
                {
                    ten++;
                }
                if (totalNum[i] == 11)
                {
                    eleven++;
                }
                if (totalNum[i] == 12)
                {
                    twelve++;
                }

                totalNum[i]++;
            }

            //Array that does the math for the number of asterisks of the total rolls for each number
            decimal[] numAsterisks = { Math.Round((decimal)(two / userNum) * 100, 0), Math.Round((decimal)(three / userNum) * 100, 0), Math.Round((decimal)(four / userNum) * 100, 0), Math.Round((decimal)(five / userNum) * 100, 0), Math.Round((decimal)(six / userNum) * 100, 0), Math.Round((decimal)(seven / userNum) * 100, 0), Math.Round((decimal)(eight / userNum) * 100, 0), Math.Round((decimal)(nine / userNum) * 100, 0), Math.Round((decimal)(ten / userNum) * 100, 0), Math.Round((decimal)(eleven / userNum) * 100, 0), Math.Round((decimal)(twelve / userNum) * 100, 0), };

            //For loop to show the actual number of asterisks
            for (int i = 0; i < 11; i++)
            {
                string percentAsterisks = (i + 2) + ": ";
                for (int z = 0; z < numAsterisks[i]; z++)
                {
                    percentAsterisks += "*";
                }
                Console.WriteLine(percentAsterisks);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
