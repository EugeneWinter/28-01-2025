using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass17
{
    private double _y;
    private double _x;
    private double _a;
    private double _b;

    public MyTaskClass17(double y, double x, double a, double b)
    {
        _y = y;
        _x = x;
        _a = a;
        _b = b;
    }

    public void T()
    {
        Console.WriteLine($"T = {(Math.Sqrt(_x + _b - _a) + Math.Log(_y)) / Math.Atan(_b + _a)}");
    }
}
