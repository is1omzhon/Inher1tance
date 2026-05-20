namespace Models.Person
{
    class Person
    {
        public string Name {get; set;}

        public Person(string name)
        {
            this.Name = name;
        }

        public void ShowName()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    class Student : Person
    {
        public double Grade{get; set;}

        public Student(string name) : base(name){}

        public void ShowGrade()
        {
            Console.WriteLine($"Grade: {Grade} ");
        }
    }

    class TeacherPerson : Person
    {
        public string Subject {get; set;}

        public TeacherPerson(string name) : base(name){}

        public void ShowSubject()
        {
            Console.WriteLine($"Subject: {Subject}");
        }
    } 
}