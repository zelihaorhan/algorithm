using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code to find out whether the sum of even numbers between 1-100 is a perfect number.
            int sum = 0;
            int sum2 = 0;
            for(int i=1;i<100;i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            for(int i = 1; i < sum; i++)
            {
                if(sum%i== 0)
                {
                    sum2 += i;
                }
            }
            if(sum2==sum)
            {
                Console.WriteLine("The sum of even numbers between 1-100 is a perfect number.");

            }
            else
            {
                Console.WriteLine("The sum of even numbers between 1-100 is not a perfect number.");
            }

            Console.ReadLine();
            
        }
    }
}
