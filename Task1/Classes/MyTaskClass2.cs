using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass2
{
    private double _c;
    private double _x;
    private double _t;

    public MyTaskClass2(double c, double x, double t)
    {
        _c = c;
        _x = x;
        _t = t;
    }

    public void L()
    {
        Console.WriteLine($"L = {Math.Pow(1 / Math.Tan(_c), 2) + (2 * Math.Pow(_x, 2) + 5) / Math.Sqrt(_c + _t)}");
    }
}
