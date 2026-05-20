namespace Models.Animal
{
    class Animal
    {
        public string Name{get;set;}

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }

    class Dog : Animal
    {
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
