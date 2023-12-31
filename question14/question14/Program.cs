using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code for the multiplication table
            for(int i=1;i<=10;i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + "*" + j + "=" + i * j);
                }
            }
            Console.ReadLine();
        }
    }
}
