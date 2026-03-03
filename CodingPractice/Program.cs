using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

//// 1-1

//Child child = new Child();
//child.Greet();
//child.Study();
//class Parent
//{
//    public void Greet()
//    {
//        Console.WriteLine("안녕하세요!");
//    }
//}

//class Child : Parent
//{
//    public void Study()
//    {
//        Console.WriteLine("공부합니다.");
//    }
//}

////1-2
//Dog dog = new Dog();
//Cat cat = new Cat();
//dog.Name = "초코";
//cat.Name = "나비";
//dog.Eat();
//dog.Bark();
//cat.Eat();
//cat.Meow();
//class Animal
//{
//    public string Name;
//    public void Eat()
//    {
//        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
//    }
//}
//class Dog:Animal
//{
//    public void Bark()
//    {
//        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
//    }
//}
//class Cat : Animal
//{
//    public void Meow()
//    {
//        Console.WriteLine($"{Name}이(가) 야옹 웁니다.");
//    }
//}

////2
//Product product = new Product();
//Console.WriteLine(product.ToString());
//Console.WriteLine(product.GetType()); 
//class Product
//{
//    public string Name;
//    public int Price;
//}

////3
//Child child = new Child();
//child.ShowValues();
//class Parent
//{
//    private int number1;
//    protected int number2;
//    public int number3;
//}
//class Child : Parent
//{
//    public void ShowValues()
//    {
//        //Console.WriteLine(number1);
//        Console.WriteLine(number2);
//        Console.WriteLine(number3);
//    }
//}

////4
//Manager manager = new Manager();
//manager.ShowDepartment();
//manager.ShowInfo();
//class Employee
//{
//    protected string _department = "개발팀";
//    public void ShowDepartment()
//    {
//        Console.WriteLine($"부서: {_department}");
//    }
//}
//class Manager : Employee
//{
//    public void ShowInfo()
//    {
//        Console.WriteLine($"소속부서: {base._department}");
//    }
//}

////5-1
//Student student = new Student("홍길동", 4);
//class Person
//{
//    protected string Name;
//    public Person(string name)
//    {
//        Name = name;
//        Console.WriteLine($"Person 생성자 호출: {Name}");
//    }
//}
//class Student : Person
//{
//    private int Grade;
//    public Student(string name, int grade): base(name)
//    {
//        Grade = grade;
//        Console.WriteLine($"Student 생성자 호출: {Grade}학년");
//    }
//}

////5-2
//Dog dog = new Dog();
//class Animal
//{
//    public Animal()
//    {
//        Console.WriteLine("Animal 기본 생성자");
//    }
//}
//class Dog : Animal
//{
//    public Dog()
//    {
//        Console.WriteLine("Dog 기본생성자");
//    }
//}

////6-1
//Dog dog = new Dog { Name = "멍멍이" };
//Animal animal = dog;
//animal.Eat();
//class Animal
//{
//    public string Name;
//    public void Eat()
//    {
//        Console.WriteLine($"{Name}이(가) 먹습니다");
//    }
//}
//class Dog : Animal
//{
//    public void Bark()
//    {
//        Console.WriteLine($"{Name}이(가) 짖습니다");
//    }
//}

////6-2
//Dog dog = new Dog { Name = "멍멍이" };
//Animal animal = dog;
//Dog dog2 = (Dog)animal;
//dog2.Bark();

//class Animal
//{
//    public string Name;
//    public void Eat()
//    {
//        Console.WriteLine($"{Name}이(가) 먹습니다");
//    }
//}
//class Dog : Animal
//{
//    public void Bark()
//    {
//        Console.WriteLine($"{Name}이(가) 짖습니다");
//    }
//}

////6-3
//Animal animal = new Dog { Name = "멍멍이" };
//if(animal is Dog)
//{
//    Dog dog = (Dog)animal;
//    dog.Bark();
//}

////6-4
//Animal animal = new Dog { Name = "멍멍이" };
//if(animal is Dog dog)
//{
//    dog.Bark();
//}

////6-5
//Animal animal = new Cat();
//Dog dog = animal as Dog;
//if(dog != null)
//{
//    dog.Bark();
//}
//else
//{
//    Console.WriteLine("Dog타입이 아닙니다");
//}
//class Animal
//{
//    public string Name;
//    public void Eat()
//    {
//        Console.WriteLine($"{Name}이(가) 먹습니다");
//    }
//}
//class Dog : Animal
//{
//    public void Bark()
//    {
//        Console.WriteLine($"{Name}이(가) 짖습니다");
//    }
//}
//class Cat : Animal
//{

//}

////7
//Asset[] assets = new Asset[3];
//assets[0] = new Stock() { Name = "삼성전자", Shares = 100 };
//assets[1] = new House() { Name = "아파트", mortgage = 3000000 };
//assets[2] = new Stock() { Name = "SK하이닉스", Shares = 50 };
//foreach(Asset asset in assets)
//{
//    Console.WriteLine($"{asset.Name}");
//}
//class Asset
//{
//    public string Name;
//}
//class Stock : Asset
//{
//    public int Shares;
//}
//class House: Asset
//{
//    public decimal mortgage;
//}

////8-1
//Rectangle rectangle = new Rectangle() { Name = "사각형", height = 5, width = 10 };
//Circle circle = new Circle() { Name = "원", radius = 3 };
//Console.WriteLine($"{rectangle.Name} 넓이: {rectangle.GetArea()}");
//Console.WriteLine($"{circle.Name} 넓이: {circle.GetArea()}");
//abstract class Shape
//{
//    public string Name;
//    public abstract double GetArea();
//}
//class Rectangle : Shape
//{
//    public double width;
//    public double height;
//    public override double GetArea()
//    {
//        return width * height;
//    }
//}

//class Circle : Shape
//{
//    public double radius;
//    public override double GetArea()
//    {
//        return Math.PI * radius * radius;
//    }
//}

////8-2
//Car car = new Car();
//car.Start();
//car.Stop();
//abstract class Vehicle
//{
//    public abstract void Start();
//    public void Stop()
//    {
//        Console.WriteLine("정지합니다.");
//    }
//}
//class Car : Vehicle
//{
//    public override void Start()
//    {
//        Console.WriteLine("자동차 시동을 켭니다.");
//    }
//}

////9
//FinalClass cla = new FinalClass();
//cla.Display();
//sealed class FinalClass
//{
//    public void Display()
//    {
//        Console.WriteLine("이 클래스는 상속할 수 없습니다.");
//    }
//}

////10
//Child child = new Child();
//Parent parent = child;
//Console.WriteLine($"child.Value: {child.Value}");  
//Console.WriteLine($"parent.Value: {parent.Value}");
//child.Show();  
//parent.Show();
//class Parent
//{
//    public int Value = 10;
//    public void Show()
//    {
//        Console.WriteLine($"Parent.Show()");
//    }
//}
//class Child : Parent
//{
//    public new int Value = 20;
//    public new void Show()
//    {
//        Console.WriteLine($"Child.Show()");
//    }
//}


////11
//Dog dog = new Dog();
//Console.WriteLine(dog is Animal);
//Console.WriteLine(dog is Dog);
//Console.WriteLine(dog is Cat);
//class Animal
//{

//}
//class Dog : Animal { }
//class Cat : Animal { }

//12
GameCharacter[] characters = new GameCharacter[]
{
    new Warrior("아서", 25),
    new Mage("멀린", 40),
    new Warrior("란슬롯", 30)
};
foreach(GameCharacter character in characters)
{
    character.ShowStatus();
    character.Attack();
    Console.WriteLine();
}

abstract class GameCharacter
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }
    public GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public abstract void Attack();
    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] 체력: {Health}");
    }
}
class Warrior : GameCharacter
{
    public int Strength { get; private set; }
    public Warrior(string name, int strength):base(name,150)
    {
        Strength = strength;
    }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 검으로 {Strength} 데미지를 입힙니다");
    }
}

class Mage : GameCharacter
{
    public int MagicPower { get; private set;  }
    public Mage(string name, int magicPower) : base(name, 80)
    {
        MagicPower = magicPower;
    }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 마법으로 {MagicPower} 데미지를 입힙니다");
    }
}