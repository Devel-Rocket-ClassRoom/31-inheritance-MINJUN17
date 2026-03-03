using System;
using System.Collections.Generic;
using System.Text;


class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age)
    {
        _sound = "뿌우!";
    }
    public void SprayWater()
    {
        Console.WriteLine($"{Name}이(가) 물을 뿌립니다.");
    }
}
