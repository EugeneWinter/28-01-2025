using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass15
{
    private double _y;
    private double _m;

    public MyTaskClass15(double y, double m)
    {
        _y = y;
        _m = m;

    }



    public void N()
    {

        Console.WriteLine($"N = {(Math.Pow(_m, 2) + 2.8 * _m + 0.355) / (Math.Cos(2 * _y) + 3.6)}");

    }
}
