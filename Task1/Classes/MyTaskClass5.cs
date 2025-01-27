using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass5
{
    private double _x;
    private double _c;
    private double _y;
    private double _z;

    public MyTaskClass5(double x, double c, double y, double z)
    {
        _y = y;
        _z = z;
        _x = x;
        _c = c;
    }

    public void G()
    {
        Console.WriteLine($"G = {(Math.Tan(Math.Pow(_x, 4) - 6) - Math.Pow(Math.Cos(_z + _x * _y), 3)) / Math.Pow(Math.Cos(Math.Pow(_x, 3) + Math.Pow(_c, 2)), 4)}");
    }
}
