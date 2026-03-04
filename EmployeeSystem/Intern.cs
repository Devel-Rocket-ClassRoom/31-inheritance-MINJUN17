using System;
using System.Collections.Generic;
using System.Text;

class Intern:Employee
{
    public Intern(string name) : base(name, 1500000) { }
    public new int CalculatePay()
    {
        return 1500000;
    }
    public new void PrintInfo()
    {
        Console.WriteLine($"[인턴] {GetName()}");
        Console.WriteLine($"기본급: {GetBaseSalary():N0}원");
        Console.WriteLine($"총급여: {CalculatePay():N0}원");
    }
}
