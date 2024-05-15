namespace Studentadministrasjonssystem
{
    class Student(string name, int age, string program, int studentId, Subject[] subjects)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public string Program { get; set; } = program;
        public int StudentId { get; set; } = studentId;
        public Subject[] Subjects { get; set; } = subjects;

        public static void SkrivUtInfo(int studentId, Student[] students)
        {
            Student student = Array.Find(students, student => student.StudentId == studentId);
            Console.WriteLine($"Navn: {student.Name}");
            Console.WriteLine($"Alder: {student.Age}");
            Console.WriteLine($"Program: {student.Program}");
            Console.WriteLine($"Student ID: {student.StudentId}");
            Console.WriteLine("Fag:");
            foreach (var subject in student.Subjects)
            {
                Console.WriteLine($"- {subject.SubjectName}");
            }

        }

        public static void BeregnGjennomsnitt(int studentId, Student[] students, Grade[] grades)
        {
            Student student = Array.Find(students, student => student.StudentId == studentId);
            int[] StudentsGrades = new int[student.Subjects.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                if (student == grades[i].Student)
                {
                    StudentsGrades[i] = grades[i].StudentGrade;
                }
            }

            int SumOfGrades = StudentsGrades.Sum();
            int AverageGrade = SumOfGrades / StudentsGrades.Length;

                Console.WriteLine($@"{AverageGrade}");
            
        }

        public static void BeregnStudiepoeng(int studentId, Student[] students, Subject[] subjects)
        {
            Student student = Array.Find(students, student => student.StudentId == studentId);
            int SumOfStudiepoeng = 0;
            for (int i = 0; i < student.Subjects.Length; i++)
            {
                SumOfStudiepoeng += student.Subjects[i].SubjectPoints;
            }

            Console.WriteLine($"{student.Name} sine studiepoeng er: {SumOfStudiepoeng}");
        }
    }
}
