using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass27
{
    private double _y;
    private double _a;
    private double _x;
    private double _c;

    public MyTaskClass27(double y, double a, double x, double c)
    {
        _y = y;
        _a = a;
        _x = x;
        _c = c;
    }

    public void P()
    {
        Console.WriteLine($"P = {(Math.Pow(_a, 5) + Math.Acos(_a + Math.Pow(_x, 3)) - Math.Pow(Math.Sin(_y - _c), 4)) / (Math.Pow(Math.Sin(_x + _y), 3) + Math.Abs(_x - _y))}");
    }
}
