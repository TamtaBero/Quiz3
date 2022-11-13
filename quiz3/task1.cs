class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Person() { Name = "John"; Surname = "Smith"; }

    public Person(string n, string s)
    {
        Name = n;
        Surname = s;
    }

    public override string ToString()
    {
        return String.Format("Person name: {0}, surname: {1}", Name, Surname);
    }
}

class Student : Person
{
    string ID {
        get { return ID; }
        set
        { 
            if (value.Length <= 11){
                ID = value;
            }
        }
    }
    List<Semester> semesters = new List<Semester>();
    int GPA { get { return GPA; } 
        set
        {
            this.GPA = Math.Min(35, value);
        }
    }

    string fullName
    {
        get
        {
            return Name + ' ' + Surname;
        }
    }

    public Student() { }

    public Student(string n, string s, string id, List<Semester> sems) : base(n, s)
    {
        this.ID = id;
        this.semesters = sems;
    }

    public void addSemester()
    {
        semesters.Add(new Semester());
    }

    public void addSemester(Semester sem)
    {
        semesters.Add(sem);
    }

    public void addSubject(int semInd, Subject sub)
    {
        semesters[semInd].addSubject(sub);
 
    }

    public void showSemesters()
    {
        for (int i = 0; i < semesters.Count; i++)
        {
            Semester semester = semesters[i];
            Console.WriteLine(String.Format("{0}) {1}", i, semester.ToString()));
        }
    }

    public override string ToString()
    {
        return String.Format("Student ID:{0}, name: {1}, surname: {2}, GPA: {3}\nSemesters: {4}", ID, Name, Surname, GPA, semesters);
    }
}

class Teacher : Person
{
    Subject[] subjects { get; set; }

    public Teacher() { subjects = new Subject[3]; }

    public Teacher(string n, string s) : base(n, s) { subjects = new Subject[3]; }

    public Teacher(string n, string s, Subject[] subarr) : base(n, s)
    {
        subjects = subarr;
    }

    public override string ToString()
    {
        return String.Format("Teacher name: {0}, surname: {1}\n Subjects: {2}", Name, Surname, subjects);
    }
}

class Subject
{
    string subjectName { get; set; }
    List<Subject> prequisites { get; set; }
    int credits { get; set; }
    int maxStudents { get; set; }

    public Subject() { }

    public Subject(string subjectName, List<Subject> prequisites, int credits, int maxStudents)
    {
        this.subjectName = subjectName;
        this.prequisites = prequisites;
        this.credits = credits;
        this.maxStudents = maxStudents;
    }

    public string basicInfo()
    {
        return String.Format("Subject name: {0} , Credits: {1}", subjectName, credits);
    }

    public override string ToString()
    {
        return String.Format("{0}, maximum number of students: {1}, prequisites: {2}", basicInfo(), maxStudents, prequisites);
    }
}

class Semester
{
    List<Subject> subjects = new List<Subject>();

    public Semester() { }

    public Semester(List<Subject> subs)
    {
        subjects = subs;
    }

    public void addSubject(Subject sub)
    {
        subjects.Add(sub);
    }

    public override string ToString()
    {
        string output = "Semester subjects:";
        for (int i=0; i < subjects.Count; i++){
            output = String.Format("{0} {1}){2}", output, i, subjects[i].basicInfo());
        }
        return output;
    }
}