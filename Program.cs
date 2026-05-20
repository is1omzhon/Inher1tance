using Models.Animal;
using Models.TransportSystem;
using Models.EmployeeSystem;
using Models.Person;
using Models.GameCharacters;
using Models.BankSystem;


var dog = new Dog();
dog.Name = "Rex";
dog.Eat();
dog.Bark();

Console.WriteLine();

var cat = new Cat();
cat.Name = "Murka";
cat.Eat();
cat.Meow();

var car = new Car();
car.Brand = "Ford";
car.Move();
car.Drive();
Console.WriteLine();

var bike = new Bike();
bike.Brand = "Yamahuchi";
bike.Move();
bike.Ride();
Console.WriteLine();

var train = new Train();
train.Brand = "Atlas";
train.Move();
train.CarryPassengers();


Console.WriteLine("Objects for Eployee System \n");
var developer = new Developer();
developer.Name = "Alex";
developer.Salary = 1000;
developer.Work();
developer.Code();

Console.WriteLine();

var teacher = new Teacher();
teacher.Name = "Bob";
teacher.Salary = 1200;
teacher.Work();
teacher.Teach();

Console.WriteLine();

var designer = new Designer();
designer.Name = "Oscar";
designer.Salary = 800;
designer.Work();
designer.Design();

Console.WriteLine("Objests for class Person");

var student = new Student("Ali");
student.Grade = 5;
student.ShowName();
student.ShowGrade();

Console.WriteLine();

var teacher1 = new TeacherPerson("Hasan");
teacher1.Subject = "Math";
teacher1.ShowName();
teacher1.ShowSubject();

Console.WriteLine("Object for task 5");
var dog5 = new Dog();
dog5.SetAge(2);
dog5.ShowAge();


Console.WriteLine("\nObjets for class Character");
var warrior = new Warrior("Assasin", 100);
warrior.SwordAttack();
Console.WriteLine();

var archer = new Archer("Arch", 80);
archer.ShootArrow();
Console.WriteLine();
var mage = new Mage("Mage", 56);
mage.CastSpell();
Console.WriteLine();

Console.WriteLine("Objects for task 7.");
var saveAcc = new SavingsAccount();
saveAcc.Balance = 1000;
saveAcc.Deposit = 500;
saveAcc.ShowBalance();
saveAcc.ShowDeposit();
saveAcc.AddInterest();

Console.WriteLine();
var creditCard = new CreditCard();
creditCard.Balance = 200;
creditCard.Deposit = 100;
creditCard.ShowBalance();
creditCard.ShowDeposit();

creditCard.TakeCredit(300);

