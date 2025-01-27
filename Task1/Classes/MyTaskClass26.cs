using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass26
{
    private double _x;
    private double _y;
    private double _k;

    public MyTaskClass26(double x, double y, double k)
    {
        _y = y;
        _x = x;
        _k = k;
    }

    public void U()
    {
        Console.WriteLine($"U = {(Math.Log(Math.Pow(_x, 3) + _y) - Math.Pow(_y, 4)) / (Math.Exp(_y) + 5.4 * Math.Pow(_k, 3))}");
    }
}
