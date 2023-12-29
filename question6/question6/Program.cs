using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to find multiplication using addition
            Console.Write("Enter the first number:");
            int n1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for(int i=n2;i>0;i--)
            {
                result += n1;
            }

            Console.WriteLine("Result:" + result);

            Console.ReadLine(); 
        }
    }
}
