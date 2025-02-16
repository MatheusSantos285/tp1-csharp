using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C_
{
    internal class NumberSecretGame
    {
        static void Main (string[] args)
        {
            int numberToBeGuessed = new Random().Next(1, 10);
            int remainingChances = 5;

            bool numberFound = false;

            while (remainingChances > 0 && !numberFound)
            {
                Console.WriteLine("Enter a number between 1 and 10:");
                string input = Console.ReadLine();
                int number;

                if (int.TryParse(input, out number))
                {
                    if (number == numberToBeGuessed)
                    {
                        numberFound = true;
                        Console.WriteLine($"Congratulations! Youve guessed the number with {remainingChances} remaining chances!");
                    }
                    else
                    {
                        remainingChances--;
                        Console.WriteLine($"Wrong number! You have {remainingChances} chances left.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                if (remainingChances == 0)
                {
                    Console.WriteLine($"You lost! The number was {numberToBeGuessed}");
                }
            }
        }
    }
}
