using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass25
{
    private double _a;
    private double _y;
    private double _x;

    public MyTaskClass25(double a, double y, double x)
    {
        _a = a;
        _y = y;
        _x = x;
    }

    public void J()
    {
        Console.WriteLine($"J = {(Math.Pow(1 / Math.Tan(Math.Pow(_a, 3)), 3) + Math.Pow(Math.Atan(_a), 2)) / Math.Sqrt(Math.Pow(_y, Math.Tan(_x)))}");
    }
}
