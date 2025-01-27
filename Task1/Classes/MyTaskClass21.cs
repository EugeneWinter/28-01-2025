using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass21
{
    private double _z;
    private double _x;
    private double _a;


    public MyTaskClass21(double z, double a, double x)
    {
        _z = z;
        _x = x;
        _a = a;
    }

    public void N()
    {
        Console.WriteLine($"N = {Math.Pow(_z + Math.Sqrt(_z * _x), 1.5) / (Math.Exp(_x) + Math.Pow(_a, 5) * Math.Atan(_x))}");
    }
}
