using Enum03.Entites;
using Enum03.Entites.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name departement: ");
            string dptName = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("Worker Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior, MidLevel, Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(dptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Numbers Contracts: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                Console.WriteLine($"Contract #{i}");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract); 
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string MonthYear = Console.ReadLine();
            int Month = int.Parse(MonthYear.Substring(0, 2));
            int Year = int.Parse(MonthYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {MonthYear}: {worker.Income(Month, Year)}");
        }
    }
}
