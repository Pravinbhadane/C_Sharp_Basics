using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class DivisibleBy5n11
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());

            if(number % 5 == 0 && number % 11 == 0)
            {
                Console.WriteLine("Divisible By Both 5 and 11");
            } 
            else
            {
                Console.WriteLine("Not Divisible");
            }

        }
    }
}
