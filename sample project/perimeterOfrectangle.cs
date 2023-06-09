using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class perimeterOfrectangle
    {
        static void Main(string[] args)
        {
            int length, breadth , perimeter;
            Console.WriteLine("Enter Length");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Breadth");
            breadth = Convert.ToInt32(Console.ReadLine());

            perimeter = 2 * (length + breadth);
                Console.WriteLine($"Perimeter Of Rectangle is {perimeter}");
        }
    }
}
