using Studentadministrasjonssystem;

Subject[] subjects = new Subject[]
{
new Subject(001, "C#", "Programming", 30),
new Subject(002, "UX Design","Programming", 30),
new Subject(003, "Frontend","Programming", 30),
new Subject(004, "Backend", "Programming",30),
};
Student[] students = new Student[]
{
new Student("Hanne", 27, "Programming", 9007, subjects),
new Student("Camilla", 24, "Programming", 9492, subjects),
};
Grade[] grades = new Grade[]
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
Student.SkrivUtInfo(9007, students);
Subject.SkrivUtInfo(001, subjects);
Grade.SkrivUtInfo(students[0], subjects[0], grades);
Student.BeregnGjennomsnitt(9007, students, grades);
Student.BeregnStudiepoeng(9007, students, subjects);