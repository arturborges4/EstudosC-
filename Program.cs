using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Collections.Generic;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a;
            List<Employee> list = new List<Employee>();

            Console.WriteLine("How many employees will be registered?: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #{0}: ", i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.WriteLine("Enter the employee ID that will have salary increase: ");
            int SearchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == SearchId);
            if (emp != null)
            {
                Console.WriteLine("Enter percentage: ");
                double per = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(per);
            }
            else
            {
                Console.WriteLine("ID does not exist!");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}