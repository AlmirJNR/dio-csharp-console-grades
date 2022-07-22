using ConsoleGrades.Models;

namespace ConsoleGrades.Utils;

static class StudentModelListExtension
{
    public static void InsertNewStudent(this List<StudentModel> students)
    {
        Console.Clear();
        Console.WriteLine("Insert the student name:");
        Console.Write("-> ");

        var name = Console.ReadLine() ?? string.Empty;

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Type a valid name");
            Console.Write("-> ");
            name = Console.ReadLine() ?? "";
        }

        Console.WriteLine("Insert the student grade:");
        Console.Write("-> ");

        var wasParsed = double.TryParse(Console.ReadLine(), out double grade);

        while (!wasParsed)
        {
            Console.WriteLine("Input must be decimal, try again:");
            Console.Write("-> ");
            wasParsed = double.TryParse(Console.ReadLine(), out grade);
        }

        Console.WriteLine();

        students.Add(new StudentModel()
        {
            Name = name,
            Grade = grade,
        });
    }

    public static void ListAllStudents(this List<StudentModel> students)
    {
        Console.Clear();

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();
    }

    public static void ShowAverageStudentsGrades(this List<StudentModel> students)
    {
        var grades = students.Sum(students => students.Grade);

        Console.Clear();
        Console.WriteLine($"The average is: {grades / students.Count}");
        Console.WriteLine();
    }
}
