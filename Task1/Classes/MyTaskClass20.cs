using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass20
{
    private double _y;
    private double _x;
    private double _a;
    private double _b;
    private double _c;

    public MyTaskClass20(double y, double x, double a, double b, double c)
    {
        _y = y;
        _x = x;
        _a = a;
        _b = b;
        _c = c;
    }

    public void U()
    {
        Console.WriteLine($"U = {(Math.Pow(Math.Tan(_y), 3) + Math.Pow(Math.Sin(_x), 5) * Math.Sqrt(_b - _c)) / Math.Sqrt(_a - _b + _c)}");
    }
}
