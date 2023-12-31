using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code of the program that finds the sum of negative numbers, the multiplication of even numbers, the number of numbers equal to 7 among 25 numbers entered from the keyboard and prints them on the screen.

            int sumNegative = 0;
            int mEven = 1;
            int sAmong = 0;

            for(int i=0;i<25;i++)
            {
                Console.WriteLine("Enter the number:");
                int number=Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    sumNegative += number;
                }
                else if(number%2==0)
                {
                    mEven *= number;
                }
                else if (number == 7)
                {
                    sAmong++;
                }
            }
            Console.WriteLine("Sum of negative numbers:" + sumNegative);
            Console.WriteLine("Multiplication of even numbers:" + mEven);
            Console.WriteLine("Number of numbers equal to 7:" + sAmong);

            Console.ReadLine();
        }
    }
}
