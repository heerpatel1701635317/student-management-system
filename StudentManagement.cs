using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Marks;
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    DeleteStudent();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter ID: ");
        s.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        s.Marks = Convert.ToInt32(Console.ReadLine());

        students.Add(s);
        Console.WriteLine("Student Added!");
    }

    static void ViewStudents()
    {
        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        students.RemoveAll(s => s.Id == id);
        Console.WriteLine("Student Deleted!");
    }
}
