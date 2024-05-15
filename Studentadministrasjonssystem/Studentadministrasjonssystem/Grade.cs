namespace Studentadministrasjonssystem
{
    class Grade (Student student, Subject subject, int grade)
    {
        public Student Student { get; set; } = student;
        public Subject Subject { get; set; } = subject;
        public int StudentGrade { get; set; } = grade;
        public static void SkrivUtInfo(Student student, Subject subject, Grade[] grades)
        {
            Grade studentGrade = Array.Find(grades, grade => grade.Student == student);
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"Fag: {subject.SubjectName}");
            Console.WriteLine($"Karakter: {studentGrade.StudentGrade}");

        }
    }
}
