using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate the factorial of the number entered by the user
            Console.Write("Enter the number:");
            int n=Convert.ToInt32(Console.ReadLine());
            int fac = 1;
            for(int i=1;i<=n;i++)
            {
                fac *= i;
            }
            Console.Write("Result:" + fac);

            Console.ReadLine(); 
        }
    }
}
