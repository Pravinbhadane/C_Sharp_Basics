using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class AveragePerecentageOfSub
    {
        static void Main(string[] args)
        {
            double math, phy, chem, eng ,mar, total, average;
          

            Console.WriteLine("Enter math  Marks");
            math=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter phy Marks");
            phy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter chem Marks");
            chem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter eng Marks");
            eng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter mar Marks");
            mar = Convert.ToDouble(Console.ReadLine());

            total = math + phy + chem + eng + mar;
            average = total / 5;
           

            Console.WriteLine($"Total marks {total}");
            Console.WriteLine($"Average {average}");
            Console.WriteLine($"Prcentage {average}");
        }
    }
}
