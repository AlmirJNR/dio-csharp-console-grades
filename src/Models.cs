namespace ConsoleTest.Models
{
    class StudentModel
    {
        string name;
        float grade;

        public StudentModel(string name, float grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public string Name { get => name; set => name = value; }
        public float Grade { get => grade; set => grade = value; }

        override public string ToString()
        {
            return $"name: {name}, grade: {grade}";
        }
    }
}
