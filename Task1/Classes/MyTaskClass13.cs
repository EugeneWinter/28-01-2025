using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass13
{
    private double _b;
    private double _a;
    private double _x;

    public MyTaskClass13(double a, double b, double x)
    {
        _a = a;
        _b = b;
        _x = x;
    }



    public void R()
    {
        Console.WriteLine($"R = {_a / (_x - _a) + (Math.Pow(_b, _x) + Math.Pow(Math.Cos(_x), 3)) / (Math.Pow(Math.Log2(_a), 3) + 4.5)}");
    }
}
