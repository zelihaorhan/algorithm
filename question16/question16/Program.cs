using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If x and y are positive integers, if the sum of the factors of x is equal to the number y and at the same time the sum of the factors of y is equal to the number x, these numbers are friendly numbers. Accordingly, write the code of the program that finds whether the two entered numbers are friends or not.
            Console.WriteLine("Please enter the X:");
            int x=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Please enter the Y:");
            int y=Convert.ToInt32(Console.ReadLine());

            int xSum = 0;
            int ySum = 0;

            for(int i=1; i < x; i++)
            {
                if (x % i == 0)
                {
                    xSum += i;
                }
            }
            for(int i=1;i<y; i++)
            {
                if(y%i == 0)
                {
                    ySum += i;
                }
            }

            if (xSum == y && ySum == x)
            {
                Console.WriteLine("X and Y are friendly numbers :)");
            }
            else
            {
                Console.WriteLine("X and Y are not friendly numbers :(");
            }

            Console.ReadLine(); 
        }
    }
}
