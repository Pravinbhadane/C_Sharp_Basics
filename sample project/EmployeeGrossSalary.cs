using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_project
{
    internal class EmployeeGrossSalary
    {
        static void Main(string[] args)
        {
            string  emp_name;
            int emp_id, pt=200;
            double  basic_salary, hra, ta, da, pf, gross_salary;

            Console.WriteLine("Enter Employee Name");
            emp_name = Console.ReadLine();

            Console.WriteLine("Enter Employee ID");
            emp_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employees Salary");
            basic_salary = Convert.ToDouble(Console.ReadLine());

            hra = 40.00 /100 * basic_salary ;
            ta = 20.00 / 100 * basic_salary;
            da = 10.00 / 100 * basic_salary;
            pf = 12.00 / 100 * basic_salary;

            gross_salary= basic_salary + hra + ta + da - (pf+pt);

            Console.WriteLine($"Employee Name = {emp_name}\nID = {emp_id}\nBasic Salary = {basic_salary} Rs\nGross Salary = {gross_salary} Rs");
        }
    }
}
