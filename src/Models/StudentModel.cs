namespace ConsoleGrades.Models;

class StudentModel
{
    public string Name { get; init; } = string.Empty;
    public double Grade { get; init; }

    public override string ToString() => $"name: {Name}, grade: {Grade}";
}
