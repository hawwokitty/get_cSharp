namespace Studentadministrasjonssystem
{
    class Subject (int subjCode, string name, string program, int points)
    {
        public int SubjectCode { get; set; } = subjCode;
        public string SubjectName { get; set; } = name;
        public string Program { get; set; } = program;
        public int SubjectPoints { get; set; } = points;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {SubjectCode}");
            Console.WriteLine($"Fagnavn: {SubjectName}");
            Console.WriteLine($"Fagnavn: {Program}");
            Console.WriteLine($"Studiepoeng: {SubjectPoints}");

        }
    }
}
