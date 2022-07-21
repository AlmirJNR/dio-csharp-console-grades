using ConsoleTest.Models;
using ConsoleTest.Utils;

internal class Program
{
    int option;
    List<StudentModel> students = new List<StudentModel>();

    private void Main(string[] args) => ShowMenu();

    private void ShowMenu()
    {
        Console.WriteLine("Select your menu option:");
        Console.WriteLine("1 - Insert new student");
        Console.WriteLine("2 - List all students");
        Console.WriteLine("3 - Show average students grade");
        Console.WriteLine("0 - Exit program");
        Console.Write("-> ");

        bool wasParsed = int.TryParse(Console.ReadLine(), out int result);

        if (!wasParsed || result > 3)
        {
            do
            {
                Console.WriteLine("Invalid input, try again:");
                Console.Write("-> ");
                wasParsed = int.TryParse(Console.ReadLine(), out result);
            } while (!wasParsed || result > 3);
        }

        option = result;

        switch (option)
        {
            case 1:
                students.Add(MenuOptions.InsertNewStudent());
                break;
            case 2:
                MenuOptions.ListAllStudents(students);
                break;
            case 3:
                MenuOptions.ShowAverageStudentsGrades(students);
                break;
            default:
                MenuOptions.Exit();
                break;
        }

        ShowMenu();
    }
}
