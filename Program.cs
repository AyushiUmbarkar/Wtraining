using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        // Define Employee collection using SortedDictionary
        static SortedDictionary<int, Employee> employees = new SortedDictionary<int, Employee>
    {
        { 101, new Employee { Name = "Ayushi", Designation = "Manager", Salary = 70000 } },
        { 102, new Employee { Name = "Swamini", Designation = "Developer", Salary = 60000 } },
        { 103, new Employee { Name = "Anuradha", Designation = "Designer", Salary = 50000 } },
        {104,new Employee{Name="Ex",Designation="Hr",Salary=5000} }
    };

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1. Display Employees\n2. Remove Employee\n3. Update Salary\n4. Exit");
                Console.Write("Enter your choice: ");
                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        DisplayEmployees();
                        break;
                    case 2:
                        Console.Write("Enter Employee ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        RemoveEmployee(removeId);
                        break;
                    case 3:
                        Console.Write("Enter Employee ID to update salary: ");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.Write("Enter new salary: ");
                        double newSalary = double.Parse(Console.ReadLine());
                        UpdateSalary(updateId, newSalary);
                        break;
                    case 4:
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        // Function to display all employee records
        static void DisplayEmployees()
        {
            Console.WriteLine("\nEmployee Records:");
            if (employees.Count == 0)
            {
                Console.WriteLine("No employee records found.");
                return;
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value.Name}, Designation: {emp.Value.Designation}, Salary: {emp.Value.Salary}");
            }
        }

        // Function to remove an employee by ID
        static void RemoveEmployee(int id)
        {
            if (employees.ContainsKey(id))
            {
                employees.Remove(id);
                Console.WriteLine($"Employee with ID {id} removed successfully.");
            }
            else
            {
                Console.WriteLine("Employee ID not found.");
            }
        }

        // Function to update an employee's salary
        static void UpdateSalary(int id, double newSalary)
        {
            if (employees.ContainsKey(id))
            {
                employees[id].Salary = newSalary;
                Console.WriteLine($"Salary updated for Employee ID {id}. New Salary: {newSalary}");
            }
            else
            {
                Console.WriteLine("Employee ID not found.");
            }
        }
    }

    // Employee class definition
    class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}



