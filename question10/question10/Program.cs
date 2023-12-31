using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code to find whether the sum of the cubes of the digits of a 3-digit number is equal to itself

            Console.WriteLine("Enter the number:");
            int number=Convert.ToInt32(Console.ReadLine());
            int fDigit = number / 100;
            int sDigit = (number / 10)%10;
            int tDigit = number % 10;
            if (fDigit * fDigit * fDigit + sDigit * sDigit * sDigit + tDigit * tDigit * tDigit == number)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            Console.ReadLine();
        }
    }
}
