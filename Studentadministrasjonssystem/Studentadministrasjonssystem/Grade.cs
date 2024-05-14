namespace Studentadministrasjonssystem
{
    class Grade (Student student, Subject subject, int grade)
    {
        Student Student { get; set; } = student;
        Subject Subject { get; set; } = subject;
        int StudentGrade { get; set; } = grade;
        public static void SkrivUtInfo(Student student, Grade[] grades)
        {
            Grade studentGrade = Array.Find(grades, grade => grade.Student == student);
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Fag: {student.Program}");
            Console.WriteLine($"Karakter: {studentGrade.StudentGrade}");

        }
    }
}
