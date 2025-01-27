using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass19
{
    private double _y;
    private double _a;
    private double _b;
    private double _r;
    private double _x;
    private double _k;

    public MyTaskClass19(double y, double a, double b, double r, double x, double k)
    {
        _y = y;
        _a = a;
        _b = b;
        _r = r;
        _x = x;
        _k = k;
    }

    public void D()
    {
        Console.WriteLine($"D = {(Math.Pow(_k, -_a * _r * _x) - _a * Math.Sqrt(6) - Math.Cos(3 * _a * _b)) / Math.Pow(Math.Sin(_a * Math.Asin(_x) + Math.Log(_y)), 2)}");
    }
}
