using ConsoleGrades.Models;
using ConsoleGrades.Utils;

List<StudentModel> students = new();

while (true)
{
    Console.WriteLine("Select your menu option:");
    Console.WriteLine("1 - Insert new student");
    Console.WriteLine("2 - List all students");
    Console.WriteLine("3 - Show average students grade");
    Console.WriteLine("0 - Exit program");
    Console.Write("-> ");

    bool wasParsed = int.TryParse(Console.ReadLine(), out int option);

    while (!wasParsed || option > 3)
    {
        Console.WriteLine("Invalid input, try again:");
        Console.Write("-> ");
        wasParsed = int.TryParse(Console.ReadLine(), out option);
    }

    switch (option)
    {
        case 1:
            students.InsertNewStudent();
            break;
        case 2:
            students.ListAllStudents();
            break;
        case 3:
            students.ShowAverageStudentsGrades();
            break;
        default:
            return;
    }
}
