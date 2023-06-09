using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class CelciusToFar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature In Celsius");
            double c= Convert.ToDouble(Console.ReadLine());

            double f = (c * 9 / 5) + 32;

            Console.WriteLine($"Temperature in Fahrenheit is {f}");
        }
    }
}
