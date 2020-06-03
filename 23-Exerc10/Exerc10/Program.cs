using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exerc10 {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int numberemployees = int.Parse(Console.ReadLine());

            Console.WriteLine();

            List<Employee> employees = new List<Employee>();            
            
            for (int i = 1; i <= numberemployees; i++) {
                Console.WriteLine("Employee #" + i + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idsalaryincrease = int.Parse(Console.ReadLine());

            int count = 0;

            foreach (Employee obj in employees) {
                if (obj.Id == idsalaryincrease) {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    obj.IncreaseSalary(percentage);
                    count = 1;
                }
            }

            if (count == 0) {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employees) {
                Console.WriteLine(obj);
            }

            


        }       
    }   
}
