namespace Models.EmployeeSystem
{
    class EmployeeSystem
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} is working. The salary is {Salary}$");
        }
    }

    class Developer : EmployeeSystem
    {
        public void Code()
        {
            Console.WriteLine($"{Name} is coding.");
        }
    }

    class Teacher : EmployeeSystem
    {
        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching.");
        }
    }

    class Designer : EmployeeSystem
    {
        public void Design()
        {
            Console.WriteLine($"{Name} is designing.");
        }
    }
}