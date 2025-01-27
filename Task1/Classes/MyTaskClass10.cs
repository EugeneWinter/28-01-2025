using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass10
{
    private double _x;
    private double _y;

    public MyTaskClass10(double x, double y)
    {
        _y = y;
        _x = x;
    }

    public void U()
    {
        Console.WriteLine($"U = {(Math.Exp(Math.Pow(_x, 3)) + Math.Pow(Math.Cos(_x - 4), 2)) / (Math.Atan(_x) + 5.2 * _y)}");
    }
}
