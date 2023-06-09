using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class ifelse
    {
        static void Main(string[] args)
        {
            int number, num1, num2;

            Console.WriteLine("Enter Number to Check Positive or Negative");
            number = Convert.ToInt32(Console.ReadLine());

           if (number >= 0)
            {
                Console.WriteLine($"{number} is Positive");
            }
            else
            {
                Console.WriteLine($"{number} is Negative");

            }

            Console.WriteLine("\nEnter Number to Check Odd or Even");
            num1= Convert.ToInt32(Console.ReadLine());

            if(num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is Even");
            }
            else {
                Console.WriteLine($"{num1} is Odd");
            } 

            Console.WriteLine("\nEnter Age To Check Valid for Vote or Not");
            num2= Convert.ToInt32(Console.ReadLine());

            if(num2 >= 18)
            {
                Console.WriteLine("Valid For Vote");
            }
            else {
                Console.WriteLine("Not Valid For Vote");
            }

            
        }
    }
}
