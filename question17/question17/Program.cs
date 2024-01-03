using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code that prints the first 10 terms of the Fibonacci series to the screen

            int first = 1;
            int second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i=0;i<8;i++)
            {
                
                int temp=first+second;
                first = second;
                second = temp;
                Console.WriteLine(temp);
            }

            Console.ReadLine();
        }
    }
}
