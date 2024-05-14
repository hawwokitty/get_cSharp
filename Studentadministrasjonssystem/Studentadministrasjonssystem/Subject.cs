namespace Studentadministrasjonssystem
{
    class Subject (int subjCode, string name, int points)
    {
        int SubjectCode { get; set; } = subjCode;
        string SubjectName { get; set; } = name;
        int SubjectPoints { get; set; } = points;

        public static void SkrivUtInfo(int subjCode, Subject[] subjects)
        {
            Subject subject = Array.Find(subjects, subject => subject.SubjectCode == subjCode);
            Console.WriteLine($"Fagkode: {subject.SubjectCode}");
            Console.WriteLine($"Fagnavn: {subject.SubjectName}");
            Console.WriteLine($"Studiepoeng: {subject.SubjectPoints}");

        }
    }
}
