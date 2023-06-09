using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year= Convert.ToInt32(Console.ReadLine());

            //if (year % 4 == 0 && year % 400 == 0 && year % 100 != 0)
            //{
            //    Console.WriteLine("Leap Year");
            //}
            //else
            //{
            //    Console.WriteLine("Not A Leap Year");
            //}

            if (year % 4 != 0)
            {
                Console.WriteLine("Not A Leap Year");
            }
            else if (year % 100 != 0)
            {
                Console.WriteLine(" Leap Year");
            }
            else if (year % 400 != 0)
            {
                Console.WriteLine("Not A Leap Year");
            }
            else
            {
                Console.WriteLine($"{year} is Leap Year");
            }
        }
    }
}
