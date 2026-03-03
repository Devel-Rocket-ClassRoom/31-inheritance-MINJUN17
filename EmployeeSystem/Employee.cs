using System;
using System.Collections.Generic;
using System.Text;

class Employee
{
    protected string _name;
    protected int _baseSalary;
    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetBaseSalary()
    {
        return _baseSalary;
    }
    public int CalculatePay()
    {
        return _baseSalary;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"[인턴] {GetName()}");
        Console.WriteLine($"기본급: {GetBaseSalary():N0}");
        Console.WriteLine($"총급여: {CalculatePay():N0}");
    }
}
