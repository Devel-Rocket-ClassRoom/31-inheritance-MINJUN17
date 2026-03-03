using System;
using System.Collections.Generic;
using System.Text;


class Manager : Employee
{
    private int _bonus;
    public Manager(string name, int baseSalary, int bonus) : base(name, baseSalary)
    {
        _bonus = bonus;
    }
    public new int CalculatePay()
    {
        return _bonus + _baseSalary;
    }
    public new void PrintInfo()
    {
        Console.WriteLine($"[매니저] {GetName()}");
        Console.WriteLine($"기본급: {GetBaseSalary():N0}원");
        Console.WriteLine($"보너스: {_bonus:N0}원");
        Console.WriteLine($"총급여: {CalculatePay():N0}원");
        Console.WriteLine();
    }
}