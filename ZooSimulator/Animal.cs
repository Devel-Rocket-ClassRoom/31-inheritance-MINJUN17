using System;
using System.Collections.Generic;
using System.Text;

class Animal
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    protected string _sound;
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다");
    }
    public void MakeSound()
    {
        Console.WriteLine($"{Name}: {_sound}");
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"이름: {Name}, 나이: {Age}살");
    }
}
