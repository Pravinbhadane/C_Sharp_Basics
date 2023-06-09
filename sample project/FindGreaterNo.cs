using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class FindGreaterNo
    {
        static void Main(string[] args)
        {
            int number1, number2, result;

            Console.WriteLine("Enter Number 1");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            number2 = Convert.ToInt32(Console.ReadLine());

            result = (number1 > number2) ? number1 : number2;

            Console.WriteLine($" Greater Number is {result}");
        }
    }
}
