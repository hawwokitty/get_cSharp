namespace Studentadministrasjonssystem
{
    class Subject (int subjCode, string name, string program, int points)
    {
        public int SubjectCode { get; set; } = subjCode;
        public string SubjectName { get; set; } = name;
        public string Program { get; set; } = program;
        public int SubjectPoints { get; set; } = points;

        public static void SkrivUtInfo(int subjCode, Subject[] subjects)
        {
            Subject subject = Array.Find(subjects, subject => subject.SubjectCode == subjCode);
            Console.WriteLine($"Fagkode: {subject.SubjectCode}");
            Console.WriteLine($"Fagnavn: {subject.SubjectName}");
            Console.WriteLine($"Fagnavn: {subject.Program}");
            Console.WriteLine($"Studiepoeng: {subject.SubjectPoints}");

        }
    }
}
