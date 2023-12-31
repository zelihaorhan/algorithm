using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code for a program that prints perfect square numbers between 10 and 1000.

            for(int i = 1; i <=31; i++)
            {
                int square=i*i;
                if (square >= 10 && square <= 1000)
                {
                    Console.WriteLine(square);
                }
            }
            Console.ReadLine();
        }
    }
}
