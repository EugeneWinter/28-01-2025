using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes;
public class MyTaskClass3
{
    private double _h;
    private double _y;

    public MyTaskClass3(double h, double y)
    {
        _h = h;
        _y = y;
    }

    public void A()
    {
        Console.WriteLine($"A = {(Math.Tan(Math.Pow(_y, 3) - Math.Pow(_h, 4)) + Math.Pow(_h, 2)) / (Math.Pow(Math.Sin(_h), 3) + _y)}");
    }
}
