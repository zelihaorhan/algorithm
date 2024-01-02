using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code for the program that finds whether the entered number is a power of 5 or not
            Console.WriteLine("Enter the number:");
            int number=Convert.ToInt32(Console.ReadLine());

            if(IsFivePower(number))
            {
                Console.WriteLine("Number is power of 5");
            }
            else
            {
                
                    Console.WriteLine("Number is not power of 5");
                
            }
            Console.ReadLine(); 

        }
        static bool IsFivePower(int num)
        {
            while (num > 1)
            {
                if(num%5!=0)
                {
                    return false;
                }
                num /= 5;
            }
            return num == 1;
        }
    }
}
