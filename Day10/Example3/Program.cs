
using System;
using System.IO;
namespace Example3;

class Program
{
    static void Main(string[] args)
    {
        const string file = @"C:\Users\HP-PC\OneDrive\Desktop\C# bootcamp\cSharp\Day10\students.txt";
        Console.WriteLine("How many students do you want to create");
        int numberOfStudents = Convert.ToInt16(Console.ReadLine());

        Student[] students = new Student[numberOfStudents];

        for (int counter = 0; counter < numberOfStudents; counter++)
        {
            Console.WriteLine($"\nEnter for student {1 + counter} \n");
            students[counter] = GetStudent();
        }
        Console.WriteLine();
        StoreAllStudents(students, file);
        ShowStoredData(file);
    }

    private static Student GetStudent()
    {
        Student student = new Student();
        Console.WriteLine("Please enter student first name");
        student.FirstName = Console.ReadLine();

        Console.WriteLine("Please enter student last name");
        student.LastName = Console.ReadLine();

        Console.WriteLine("Please enter student email");
        student.Email = Console.ReadLine();

        Console.WriteLine("Please enter student phone");
        student.Phone = Console.ReadLine();

        return student;
    }
    private static void StoreAllStudents(Student[] students, string filePath)
    {
        for (int i = 0; i < students.Length; i++)
        {
            string Id = $"Id: {students[i].Id}\n";
            string FirstName = $"First name: {students[i].FirstName}\n";
            string LastName = $"Last name: {students[i].LastName}\n";
            string Email = $"Email: {students[i].Email}\n";
            string Phone = $"Phone: {students[i].Phone}\n\n";

            File.AppendAllText(filePath, Id);
            File.AppendAllText(filePath, FirstName);
            File.AppendAllText(filePath, LastName);
            File.AppendAllText(filePath, Email);
            File.AppendAllText(filePath, Phone);
        }

    }
    private static void ShowStoredData(string filePath)
    {
        Console.WriteLine(File.ReadAllText(filePath));
    }
}
