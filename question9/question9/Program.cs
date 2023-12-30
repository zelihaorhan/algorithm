using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code that finds how many digits the entered number has
            Console.Write("Enter the number:");
            int n=Convert.ToInt32(Console.ReadLine());
            int digit = 1;
            while(n>9)
            {
                n/=10; 
                digit++;
            }
            Console.WriteLine("Digit number: " + digit);

            Console.ReadLine();
        }
    }
}
