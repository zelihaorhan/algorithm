using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code of the program that finds the desired number between the numbers 1 to 63 in a maximum of 6 times.

            Console.WriteLine("Select a number between 1 and 63 and press enter.");
            Console.ReadLine();

            int lowerBound = 1;
            int upperBound = 63;
            int guess = 0;
            int guessNumber = 0;

            do
            {
                guess = (lowerBound + upperBound) / 2;

                Console.WriteLine($"Guess: {guess}");
                Console.WriteLine("Is it true? (T/F/E): ");
                string answer = Console.ReadLine();

                if (answer.ToUpper() == "T")
                {
                    Console.WriteLine($"Bingo! {guess} the number of {guessNumber + 1}. I guessed.");
                    break;
                }
                else if (answer.ToUpper() == "F")
                {
                    upperBound = guess - 1;
                }
                else if (answer.ToUpper() == "E")
                {
                    lowerBound = guess + 1;
                }
                else
                {
                    Console.WriteLine("You entered an invalid answer. Please enter 'D', 'K' or 'E'.");
                }

                guessNumber++;

            } while (guessNumber < 6);

            if (guessNumber == 6)
            {
                Console.WriteLine("Unfortunately, after 6 guesses, I couldn't find the correct number.");
            }

            Console.ReadLine();
        }
    }
}
