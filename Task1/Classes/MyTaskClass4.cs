using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass4
{
    private double _x;
    private double _y;

    public MyTaskClass4(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public void F()
    {
        Console.WriteLine($"F = {Math.Sqrt(Math.Pow(2 + _y, 2) + Math.Pow(Math.Sin(_y + 5), 1 / 7)) / (Math.Log(_x + 1) - Math.Pow(_y, 3))}");
    }
}
