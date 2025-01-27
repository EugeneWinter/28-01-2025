using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass1
{
    private double _x;
    private double _a;
    private double _c;

    public MyTaskClass1(double x, double a, double c)
    {
        _x = x;
        _a = a;
        _c = c;
    }

    public void L()
    {
        Console.WriteLine($"L = {(Math.Sqrt(Math.Exp(_x) - Math.Pow(Math.Cos(Math.Pow(_x, 2) * Math.Pow(_a, 5)), 4)) + Math.Pow(Math.Atan(_a - Math.Pow(_x, 5)), 4)) / (Math.E * Math.Sqrt(Math.Abs(_a + _x * Math.Pow(_c, 4))))}");
    }
}
