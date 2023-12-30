using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code that calculates the mode of the entered number according to the desired number.

            Console.WriteLine("Enter number:");
            int number=Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter mode:");
            int mode=Convert.ToInt32(Console.ReadLine());

            int result = number-(number/mode)*mode;

            

            Console.WriteLine("Result:" + result);

            Console.ReadLine();
        }
    }
}
