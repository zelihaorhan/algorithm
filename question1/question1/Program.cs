using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code for the program that returns the sum of two numbers

            Console.Write("Enter first number:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum: " + (n1 + n2));

            Console.ReadLine(); 

        }
    }
}
