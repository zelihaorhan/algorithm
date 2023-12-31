using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the code for the program that finds the ratio of the sum of even numbers to the sum of odd numbers among 20 numbers entered from the keyboard.

            int oddsSum = 0;
            int evensSum = 0;

            for (int i=0;i<20;i++)
            {
                Console.WriteLine("Enter the number:");
                int number=Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    evensSum+=number;
                }
                else
                {
                    oddsSum+=number;
                }
            }
            try
            {
                double result = (double)evensSum / oddsSum;
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            

            Console.ReadLine();

            

            
        }
    }
}
