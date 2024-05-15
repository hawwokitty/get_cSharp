using Studentadministrasjonssystem;

var subjects = new List<Subject>
{
    new Subject(001, "C#", "Programming", 30),
    new Subject(002, "UX Design", "Programming", 30),
    new Subject(003, "Frontend", "Programming", 30),
    new Subject(004, "Backend", "Programming", 30),
};
var students = new List<Student>
{
    new Student("Hanne", 27, "Programming", 9007, subjects),
    new Student("Camilla", 24, "Programming", 9492, subjects),
};
var grades = new List<Grade>
{
    new Grade(students[0], subjects[0], 6),
    new Grade(students[0], subjects[1], 5),
    new Grade(students[0], subjects[2], 6),
    new Grade(students[0], subjects[3], 4),
    new Grade(students[1], subjects[0], 5),
    new Grade(students[1], subjects[1], 1),
    new Grade(students[1], subjects[2], 6),
    new Grade(students[1], subjects[3], 4),
};

students[0].SkrivUtInfo();
students[0].BeregnGjennomsnitt(grades);
students[0].BeregnStudiepoeng();
subjects[0].SkrivUtInfo();
grades[0].SkrivUtInfo();