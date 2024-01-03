using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace question19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code to find out whether a number entered from the keyboard is a perfect number or not

            Console.WriteLine("Enter the number:");
            int number=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1;i<number;i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (number == sum)
            {
                Console.WriteLine("This number is perfect number");
            }
            else
            {
                Console.WriteLine("This number is not perfect number");
            }

            Console.ReadLine(); 
        }
    }
}
