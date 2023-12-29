using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write code to find division using subtraction
            Console.Write("Enter the first number:");
            int n1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            while(n1>=n2)
            {
                n1 -= n2;
                counter++;
            }

            Console.Write("Result: " + counter);
            Console.ReadLine();
        }
    }
}
