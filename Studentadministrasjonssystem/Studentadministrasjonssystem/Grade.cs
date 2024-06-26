﻿namespace Studentadministrasjonssystem
{
    class Grade (Student student, Subject subject, int grade)
    {
        public Student Student { get; set; } = student;
        public Subject Subject { get; set; } = subject;
        public int StudentGrade { get; set; } = grade;
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {Student.Name}");
            Console.WriteLine($"Fag: {Subject.SubjectName}");
            Console.WriteLine($"Karakter: {StudentGrade}");

        }
    }
}
