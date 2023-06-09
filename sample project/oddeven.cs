using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class oddeven
    {
        static void Main(string[] args)
        {
            int number;
            string result;

            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());

            result = (number % 2 == 0) ? "even" : "odd";

            Console.WriteLine($"Number is {result}");
        }
    }
}
