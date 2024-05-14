using Studentadministrasjonssystem;

Student[] students = new Student[]
{
new Student("Hanne", 27, "Programming", 9007),
new Student("Camilla", 24, "Programming", 9492),
}
;Subject[] subjects = new Subject[]
{
new Subject(001, "C#", 30),
new Subject(002, "UX Design", 30),
new Subject(003, "Frontend", 30),
new Subject(004, "Backend", 30),
}
;
Grade[] grades = new Grade[]
{
    new Grade(students[0], subjects[0], 6),
    new Grade(students[1], subjects[1], 5),
};
Student.SkrivUtInfo(9007, students);
Subject.SkrivUtInfo(001, subjects);
Grade.SkrivUtInfo(students[0], grades);