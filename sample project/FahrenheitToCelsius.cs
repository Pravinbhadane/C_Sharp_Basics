using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature In Fahrenheit");
            double f = Convert.ToDouble(Console.ReadLine());

            double c = (f - 32) * 5 / 9;

            Console.WriteLine($"Temperature in Fahrenheit is {c}");
        }
    }
}
