using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig game!");

            int totalScore = 0;
            int turnScore = 0;
            Random random = new Random();

            while (totalScore < 20)
            {
                Console.WriteLine("Total Score: "+totalScore +" \n Turn Score: "+turnScore);
                Console.Write("Roll -> ( r )or Hold -> ( h ) ?: ");
                char choice = Console.ReadLine()[0];

                if (choice == 'r')
                {
                    int roll = random.Next(1, 7);
                    Console.WriteLine("You rolled : " + roll);

                    if (roll == 1)
                    {
                        Console.WriteLine("Turn ended. No points earned.");
                        turnScore = 0;
                        continue;
                    }
                    else
                    {
                        turnScore = roll;
                        totalScore += turnScore;
                    }
                }
                else if (choice == 'h')
                {
                   // totalScore += turnScore;
                    turnScore = 0;
                    Console.WriteLine("Hold !! . Your Total Score : "+totalScore);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'r' to roll or 'h' to hold.");
                }
            }

            Console.WriteLine("Congratulations! \n You won with a total score of "+totalScore);
        }
    }
}





