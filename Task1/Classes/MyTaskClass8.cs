using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass8
{
    private double _a;
    private double _y;
    private double _c;
    private double _x;

    public MyTaskClass8(double y, double c, double a, double x)
    {
        _y = y;
        _c = c;
        _x = x;
        _a = a;
    }

    public void P()
    {
        Console.WriteLine($"P = {(Math.Pow(_a, 5) + Math.Pow(Math.Sin(_y - _c), 4)) / (Math.Pow(Math.Sin(_x + _y), 3) + Math.Abs(_x - _y))}");
    }
}
