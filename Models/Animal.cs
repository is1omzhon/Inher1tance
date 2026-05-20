namespace Models.Animal
{
    class Animal
    {
        public string Name{get;set;}
        protected int Age;


        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }

    class Dog : Animal
    {
        public void SetAge(int age)
        {
            this.Age = age;
        }

        public void ShowAge()
        {
            Console.WriteLine($"Age : {Age}");
        } 

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing");
        }
    }

}
