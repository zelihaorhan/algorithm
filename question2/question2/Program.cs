using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write code that calculates the sum of squares of two numbers entered by the user
            Console.Write("Enter first number: ");
            int n1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result: " + (Math.Pow(n1,2)+ Math.Pow(n2, 2)));

            Console.ReadLine(); 
        }
    }
}
