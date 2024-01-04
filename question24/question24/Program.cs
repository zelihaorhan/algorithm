using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //When the entered numbers a and b are greater than 50, write the code that prints that if the operation c=a+b is not performed, these numbers are not valid.
            Console.WriteLine("Enter the a:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the b:");
            int b=Convert.ToInt32(Console.ReadLine());
            int c = 0;
            if (a > 50 && b > 50)
            {
                c = a + b;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("These numbers are not valid");
            }

            Console.ReadLine();
        
        }
    }
}
