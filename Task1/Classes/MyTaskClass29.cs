using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass29
{
    private double _y;
    private double _d;
    private double _x;

    public MyTaskClass29(double y, double d, double x)
    {
        _y = y;
        _d = d;
        _x = x;
    }

    public void R()
    {
        Console.WriteLine($"R = {(Math.Pow(Math.Cos(_y), 2) + 2.4 * _d) / (Math.Exp(_y) + Math.Log(Math.Pow(Math.Sin(_x), 2) + 6))}");
    }
}
