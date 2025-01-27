using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass28
{
    private double _z;
    private double _x;
    private double _c;
    private double _y;

    public MyTaskClass28(double z, double x, double c, double y)
    {
        _y = y;
        _z = z;
        _x = x;
        _c = c;
    }

    public void G()
    {
        Console.WriteLine($"G = {(Math.Tan(Math.Pow(_x, 4) - 6) - Math.Pow(Math.Cos(_z + Math.Pow(_x, 3) * _y), 3 * _x)) / Math.Pow(Math.Cos(Math.Pow(_x, 3) * Math.Pow(_c, 2)), 2)}");
    }
}
