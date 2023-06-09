using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class compoundInterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principle Ammount ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter The Interest Rate");
            double  r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter The Time");
            double  t = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Annual compound");
            //double  n = Convert.ToDouble(Console.ReadLine());

            double compound_interest = p * Math.Pow(1 + r, t);

            Console.WriteLine($"Compound Interest is {compound_interest}");
        }
    }
}
