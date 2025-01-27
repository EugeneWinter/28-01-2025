using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass22
{
    private double _y;
    private double _x;

    public MyTaskClass22(double y, double x)
    {
        _y = y;
        _x = x;
    }

    public void F()
    {
        Console.WriteLine($"F = {Math.Cos(Math.Pow(_x, 2) + 2) + (3.5 * Math.Pow(_x, 2) + 1) / Math.Pow(Math.Cos(_y), 2)}");
    }
}
