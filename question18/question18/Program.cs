using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code that finds whether a number entered from the keyboard is negative, positive or 0

            Console.WriteLine("Enter the number:");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n<0)
            {
                Console.WriteLine("Number is negative");
            }
            else if(n>0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }

            Console.ReadLine(); 

        }
    }
}
