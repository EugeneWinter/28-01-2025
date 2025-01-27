using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass11
{
    private double _y;
    private double _x;

    public MyTaskClass11(double y, double x)
    {
        _y = y;
        _x = x;
    }



    public void I()
    {

        Console.WriteLine($"I = {2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(_y), 2))) / (Math.Exp(_y) + Math.Pow(Math.Sin(_x), 2))}");

    }
}
