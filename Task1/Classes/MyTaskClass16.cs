using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass16
{
    private double _y;
    private double _t;
    private double _x;

    public MyTaskClass16(double y, double t, double x)
    {
        _y = y;
        _t = t;
        _x = x;
    }

    public void P()
    {
        Console.WriteLine($"P = {(Math.Pow(Math.Sin(_x), 3) + Math.Log(2 * _y + 3 * _x)) / (Math.Pow(_t, Math.E) + Math.Sqrt(_x))}");
    }
}
