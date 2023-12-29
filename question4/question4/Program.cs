using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate the age of the person whose date of birth is entered

            Console.Write("Enter the birth year:");
            int bYear=Convert.ToInt32(Console.ReadLine());

            int currentYear=DateTime.Now.Year;

            Console.Write("Age: " + (currentYear - bYear));

            Console.ReadLine(); 
        }
    }
}
