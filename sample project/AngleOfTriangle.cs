using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class AngleOfTriangle
    {
        static void Main(string[] args)
        {
            int angle1, angle2, angle3;

            Console.WriteLine("Enter angle1");
            angle1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter angle2");
            angle2 = Convert.ToInt32(Console.ReadLine());

            angle3 = 180 - (angle1 + angle2);
            Console.WriteLine($" Angle Third is {angle3}");

        }
    }
}
