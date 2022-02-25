
using System;
using System.Collections.Generic; 
namespace SOLID.ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = After.Repository.LoadEmployees();

            foreach (var e in employees)
            {
                Console.WriteLine(e.PrintSalarySlip());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
