namespace Studentadministrasjonssystem
{
    class Student(string name, int age, string program, int studentID)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public string Program { get; set; } = program;
        public int StudentID { get; set; } = studentID;

        public static void SkrivUtInfo(int studentID, Student[] students)
        {
            Student student = Array.Find(students, student => student.StudentID == studentID);
            Console.WriteLine($"Navn: {student.Name}");
            Console.WriteLine($"Alder: {student.Age}");
            Console.WriteLine($"Fag: {student.Program}");
            Console.WriteLine($"Student ID: {student.StudentID}");

        }
    }
}
