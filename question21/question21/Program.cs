using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code to find the power of any number to any degree
            Console.WriteLine("Enter the number:");
            int  number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power:");
            int power=Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for(int i=0;i<power;i++)
            {
                result*=number;
            }
            Console.WriteLine("Result:" + result);

            Console.ReadLine();
        }
    }
}
