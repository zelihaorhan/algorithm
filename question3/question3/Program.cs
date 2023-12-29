using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code to find the sum of the cubes of numbers from 1 to 100
            double sum = 0;
            for(int i=1;i<100;i++)
            {
                sum +=(Math.Pow(i, 3));
            }
            Console.WriteLine("Sum:" + sum);

            Console.ReadLine(); 
        }
    }
}
