using System.Linq;

namespace Studentadministrasjonssystem
{
    class Student(string name, int age, string program, int studentId, List<Subject> subjects)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public string Program { get; set; } = program;
        public int StudentId { get; set; } = studentId;
        public List<Subject> Subjects { get; set; } = subjects;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Name}");
            Console.WriteLine($"Alder: {Age}");
            Console.WriteLine($"Program: {Program}");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine("Fag:");
            foreach (var subject in Subjects)
            {
                Console.WriteLine($"- {subject.SubjectName}");
            }

        }

        public void BeregnGjennomsnitt(List<Grade> grades)
        {
            int sumOfGrades = 0;
            int count = 0;

            foreach (var grade in grades)
            {
                if (grade.Student == this)
                {
                    sumOfGrades += grade.StudentGrade;
                    count++;
                }
            }

            double averageGrade = (double)sumOfGrades / count;
            Console.WriteLine($"Gjennomsnittskarakter: {averageGrade}");
        }

        public void BeregnStudiepoeng()
        {
            int sumOfStudiepoeng = Subjects.Sum(subject => subject.SubjectPoints);
            Console.WriteLine($"{Name} sine studiepoeng er: {sumOfStudiepoeng}");
        }
    }
}
