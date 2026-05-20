namespace Models.GameCharacters
{
    class Character
    {
        public string Name{get; set;}
        public double Health{ get; set;}

        public Character(string name, double health)
        {
            this.Name = name;
            this.Health = health;
        }

        public void Attack()
        {
            Console.WriteLine($"Name : {Name} attacks!, Health: {Health}");
        }
    }

    class Warrior : Character
    {
        public Warrior(string name, double health) : base(name, health){}

        public void SwordAttack()
        {
            Attack();
            Console.WriteLine($"{Name} swings a SWORD!!!");
        } 
    }

    class Archer : Character
    {
        public Archer(string name, double health) : base(name, health){}

        public void ShootArrow()
        {
            Attack();
            Console.WriteLine($"{Name} shoots an ARROW!!!");
        }
    }

    class Mage : Character
    {
        public Mage(string name, double health) : base(name, health){}

        public void CastSpell()
        {
            Attack();
            Console.WriteLine($"{Name} casts a SPELL!!!");
        }
    }

}