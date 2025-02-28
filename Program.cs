using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*class Studentuniversity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static List<Studentuniversity> students = new List<Studentuniversity>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nUniversity Student Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input, please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    DisplayStudents();
                    break;
                case 3:
                    RemoveStudent();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Age: ");
        int age = int.Parse(Console.ReadLine());

        students.Add(new Studentuniversity { Id = id, Name = name, Age = age });
        Console.WriteLine("Student added successfully.");
    }

    static void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("\nStudent List:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }

    static void RemoveStudent()
    {
        Console.Write("Enter Student ID to remove: ");
        int id = int.Parse(Console.ReadLine());

        Studentuniversity studentToRemove = students.Find(s => s.Id == id);
        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            Console.WriteLine("Student removed successfully.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }*/
}

