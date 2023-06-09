using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class StudentPercentage
    {
        static void Main(string[] args)
        {
            int math, physics, chemistry, total;
            double percentage;

            Console.WriteLine("Enter Math Marks");
            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Physics Marks");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Physics Marks");
           chemistry = Convert.ToInt32(Console.ReadLine());

            total = math + physics + chemistry;
            percentage = (total / 3);

            Console.WriteLine($"Total Marks of the student is {total} and Percentage is {percentage}");
            Console.WriteLine(percentage);

        }
    }
}
