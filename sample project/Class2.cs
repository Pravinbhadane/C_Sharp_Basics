using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number*i);
            }
        }
    }
}
