using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass24
{
    private double _a;
    private double _b;
    private double _x;
    private double _z;

    public MyTaskClass24(double a, double b, double x, double z)
    {
        _a = a;
        _b = b;
        _x = x;
        _z = z;
    }

    public void F()
    {
        Console.WriteLine($"F = {(Math.Pow(Math.Cos(_b * Math.Pow(_x, 5)), 7) - (Math.Sin(Math.Pow(_a, 2)) + Math.Cos(Math.Pow(_x, 3) + Math.Pow(_z, 5) - Math.Pow(_a, 2)))) / (Math.Asin(Math.Pow(_a, 2)) + Math.Acos(Math.Pow(_x, 7) - Math.Pow(_a, 2)))}");
    }
}
