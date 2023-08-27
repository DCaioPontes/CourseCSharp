using System;
using System.Diagnostics;
using System.Globalization;
using MyApp.Enetities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int qntEmployees = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= qntEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (Y/N)? ");
                char ch = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double addionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\n Payment:");
            foreach (var employe in list)
            {
                Console.WriteLine($"{employe.Name} - ${employe.Payment().ToString("F2")}");
            }
            
        }
    }
}