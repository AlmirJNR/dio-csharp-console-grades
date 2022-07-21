using ConsoleTest.Models;

namespace ConsoleTest.Utils
{
    abstract class MenuOptions
    {
        public static StudentModel InsertNewStudent()
        {
            string name = "";
            float grade = 0.0f;

            Console.Clear();
            Console.WriteLine("Insert the student name:");
            Console.Write("-> ");

            name = Console.ReadLine() ?? "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                do
                {
                    Console.WriteLine("Type a valid name");
                    Console.Write("-> ");
                    name = Console.ReadLine() ?? "";
                } while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name));
            }

            Console.WriteLine("Insert the student grade:");
            Console.Write("-> ");

            bool wasParsed = float.TryParse(Console.ReadLine(), out float result);

            if (!wasParsed)
            {
                do
                {
                    Console.WriteLine("Input must be decimal, try again:");
                    Console.Write("-> ");
                    wasParsed = float.TryParse(Console.ReadLine(), out result);
                } while (!wasParsed);
            }

            Console.WriteLine();

            grade = result;

            return new StudentModel(name, grade);
        }

        public static void ListAllStudents(List<StudentModel> students)
        {
            Console.Clear();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
        }

        public static void ShowAverageStudentsGrades(List<StudentModel> students)
        {
            float grades = 0.0f;

            foreach (var student in students)
            {
                grades += student.Grade;
            }

            Console.Clear();
            Console.WriteLine($"The average is: {grades / students.Count()}");
            Console.WriteLine();
        }

        public static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
