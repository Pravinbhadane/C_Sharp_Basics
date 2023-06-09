using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class AreaOfEqulateraalTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side length");
            double side = Convert.ToDouble(Console.ReadLine());

            double area = (Math.Sqrt(3) / 4) * side*side;

            Console.WriteLine($"Area Of Equlateral Triangle is {area}");
        }
    }
}
