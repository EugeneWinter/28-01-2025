using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass30
{
    private double _x;

    public MyTaskClass30(double x)
    {
        _x = x;
    }

    public void K()
    {
        Console.WriteLine($"K = {Math.Sqrt(Math.Pow(3 + _x, 6) - Math.Log(_x)) / (Math.Exp(0) + Math.Asin(6 * Math.Pow(_x, 2)))}");
    }
}
