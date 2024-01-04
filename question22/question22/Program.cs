using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code that finds whether the entered number is an abundant number or a deficient number.
            Console.WriteLine("Enter the number:");
            int number=Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for(int i=1;i<number;i++)
            {
                if (number % i == 0)
                {
                    result += i;
                }
            }
            if (number > result)
            {
                Console.WriteLine("Number is abundant");
            }
            else
            {
                Console.WriteLine("Number is deficient");
            }

            Console.ReadLine();
        }
    }
}
