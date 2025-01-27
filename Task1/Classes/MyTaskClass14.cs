using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass14
{
    private double _x;

    public MyTaskClass14(double x)
    {
        _x = x;
    }



    public void R()
    {

        Console.WriteLine($"R = {Math.Sin(Math.Pow(Math.Pow(_x, 2) + 4, 3) + 4.3) / Math.Pow(Math.Sin(Math.Pow(_x, 4)), 3)}");

    }
}
