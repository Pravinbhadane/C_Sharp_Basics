using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class radiusofcircle
    {
        static void Main(string[] args)
        {
            int radius;
            double area_of_circle ,pie = 3.14;

            Console.WriteLine("Enter Radius");
            radius= Convert.ToInt32(Console.ReadLine());

            area_of_circle = pie*radius*radius;
            Console.WriteLine($"Area Of Circle is {area_of_circle}");

          
        }
    }
}
