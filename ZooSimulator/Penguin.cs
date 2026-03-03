using System;
using System.Collections.Generic;
using System.Text;


class Penguin : Animal
{
    public Penguin(string name, int age) : base(name, age)
    {
        _sound = "꽥꽥!";
    }
    public void Swim()
    {
        Console.WriteLine($"{Name}이(가) 수영을 합니다.");
    }
}
