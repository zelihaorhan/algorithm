using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code for the program that finds the sum of integers from 1 to 500
            int sum = 0;
            for(int i=1;i<500;i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
