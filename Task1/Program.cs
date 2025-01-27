using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Classes;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №3");
            Console.WriteLine("1-30");
            int sm = Convert.ToInt32(Console.ReadLine());

            switch (sm)
            {
                case 1:
                    double L, a, c, x;

                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение c");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*L = (Math.Sqrt(Math.Exp(x) - Math.Pow(Math.Cos(Math.Pow(x, 2) * Math.Pow(a, 5)), 4)) + Math.Pow(Math.Atan(a - Math.Pow(x, 5)), 4)) / (Math.E * Math.Sqrt(Math.Abs(a + x * Math.Pow(c, 4))));
                    Console.WriteLine($"L = {L}");*/
                    MyTaskClass1 myTaskClass1 = new MyTaskClass1(a, c, x);
                    myTaskClass1.L();
                    break;

                case 2:
                    double t;

                    Console.WriteLine("Введите значение c");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение t");
                    t = Convert.ToDouble(Console.ReadLine());
                    /*L = Math.Pow(1 / Math.Tan(c), 2) + (2 * Math.Pow(x, 2) + 5) / Math.Sqrt(c + t);
                    Console.WriteLine($"L = {L}");*/
                    MyTaskClass2 myTaskClass2 = new MyTaskClass2(c, x, t);
                    myTaskClass2.L();
                    break;

                case 3:
                    double A, h, y;

                    Console.WriteLine("Введите значение h");
                    h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    /*A = (Math.Tan(Math.Pow(y, 3) - Math.Pow(h, 4)) + Math.Pow(h, 2)) / (Math.Pow(Math.Sin(h), 3) + y);
                    Console.WriteLine($"A = {A}");*/
                    MyTaskClass3 myTaskClass3 = new MyTaskClass3(h, y);
                    myTaskClass3.A();
                    break;

                case 4:
                    double F;

                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    /*F = Math.Sqrt(Math.Pow(2 + y, 2) + Math.Pow(Math.Sin(y + 5), 1 / 7)) / (Math.Log(x + 1) - Math.Pow(y, 3));
                    Console.WriteLine($"F = {F}");*/
                    MyTaskClass4 myTaskClass4 = new MyTaskClass4(x, y);
                    myTaskClass4.F();
                    break;

                case 5:
                    double G, z;

                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение z");
                    z = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение c");
                    c = Convert.ToDouble(Console.ReadLine());
                    /*G = (Math.Tan(Math.Pow(x, 4) - 6) - Math.Pow(Math.Cos(z + x * y), 3)) / Math.Pow(Math.Cos(Math.Pow(x, 3) + Math.Pow(c, 2)), 4);
                    Console.WriteLine($"G = {G}");*/
                    MyTaskClass5 myTaskClass5 = new MyTaskClass5(x, z, y, c);
                    myTaskClass5.G();
                    break;

                case 6:
                    double K, b;

                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    /*K = (Math.Sqrt(x + b - a) + Math.Log(y)) / Math.Atan(b + a);
                    Console.WriteLine($"K = {K}");*/
                    MyTaskClass6 myTaskClass6 = new MyTaskClass6(x, b, a, y);
                    myTaskClass6.K();
                    break;

                case 7:
                    double D;

                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    /*D = (Math.Cos(Math.Pow(x , 3) + 7) - Math.Sin(y - a)) / (Math.Log(Math.Pow(x , 4)) + 2 * Math.Pow(Math.Sin(x), 5));
                    Console.WriteLine($"D = {D}");*/
                    MyTaskClass7 myTaskClass7 = new MyTaskClass7(x, y, a);
                    myTaskClass7.D();
                    break;

                case 8:
                    double P;

                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение c");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*P = (Math.Pow(a ,5) + Math.Pow(Math.Sin(y - c), 4))/ (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y));
                    Console.WriteLine($"P = {P}");*/
                    MyTaskClass8 myTaskClass8 = new MyTaskClass8(a, y, c, x);
                    myTaskClass8.P();
                    break;

                case 9:
                    double R, d;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение d");
                    d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*R = (Math.Pow(Math.Cos(y), 3) + Math.Pow(2, x) * d)/ (Math.Exp(y) + Math.Log(Math.Pow(Math.Sin(x), 2) + 7.4));
                    Console.WriteLine($"R = {R}");*/
                    MyTaskClass9 myTaskClass9 = new MyTaskClass9(y, d, x);
                    myTaskClass9.R();
                    break;

                case 10:
                    double U;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*U = (Math.Exp(Math.Pow(_x ,3)) + Math.Pow(Math.Cos(_x - 4), 2)) / (Math.Atan(_x) + 5.2 * _y);
                    Console.WriteLine($"U = {U}");*/
                    MyTaskClass10 myTaskClass10 = new MyTaskClass10(y, x);
                    myTaskClass10.U();
                    break;

                case 11:
                    double I;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*I = (2.33 * Math.Log(Math.Sqrt(1+ Math.Pow(Math.Cos(y),2)))) / (Math.Exp(y) + Math.Pow(Math.Sin(x), 2));
                    Console.WriteLine($"I = {I}");*/
                    MyTaskClass11 myTaskClass11 = new MyTaskClass11(y, x);
                    myTaskClass11.I();
                    break;

                case 12:

                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    /*G = (Math.Pow(Math.Cos(Math.Abs(y + x)), 3) - (x + y)) / Math.Pow(Math.Atan(x + a), 4) * Math.Pow(x, 5);
                    Console.WriteLine($"R = {R}");*/
                    MyTaskClass12 myTaskClass12 = new MyTaskClass12(x, y, a);
                    myTaskClass12.G();
                    break;

                case 13:
                    
                    Console.WriteLine("Введите значение b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    /*R = (a / (x - a) ) + ((Math.Pow(b, x) + Math.Pow(Math.Cos(x), 3)) / (Math.Pow(Math.Log2(a), 3) + 4.5));
                    Console.WriteLine($"R = {R}");*/
                    MyTaskClass13 myTaskClass13 = new MyTaskClass13(b, x, a);
                    myTaskClass13.R();
                    break;

                case 14:

                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*R = (Math.Sin(Math.Pow(Math.Pow(x , 2) + 4, 3) + 4.3)) / (Math.Pow(Math.Sin(Math.Pow(x, 4)), 3));
                    Console.WriteLine($"R = {R}");*/
                    MyTaskClass14 myTaskClass14 = new MyTaskClass14(x);
                    myTaskClass14.R();
                    break;

                case 15:
                    double N, m;

                    Console.WriteLine("Введите значение t");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение m");
                    m = Convert.ToDouble(Console.ReadLine());
                    /*N = (Math.Pow(_m, 2) + 2.8 * _m + 0.355) / (Math.Cos(2 * _y) + 3.6);
                    Console.WriteLine($"N = {N}");*/
                    MyTaskClass15 myTaskClass15 = new MyTaskClass15(y, m);
                    myTaskClass15.N();
                    break;

                case 16:

                    Console.WriteLine("Введите значение t");
                    t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    /*P = (Math.Pow(Math.Sin(x), 3) + Math.Log(2 * y + 3 * x)) / (Math.Pow(t, Math.E) + Math.Sqrt(x));
                    Console.WriteLine($"P = {P}");*/
                    MyTaskClass16 myTaskClass16 = new MyTaskClass16(y, t, x);
                    myTaskClass16.P();
                    break;

                case 17:
                    double T;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    /*T = (Math.Sqrt(x + b - a) + Math.Log(y)) / Math.Atan(b + a);
                    Console.WriteLine($"T = {T}");*/
                    MyTaskClass17 myTaskClass17 = new MyTaskClass17(x, y, b, a);
                    myTaskClass17.T();
                    break;

                case 18:
                    double S;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение t");
                    t = Convert.ToDouble(Console.ReadLine());
                    /*S = (4.351 * Math.Pow(_y, 3) + 2 * _t * Math.Log(_t))/ Math.Sqrt(Math.Cos(2 * _y) + 4.351);
                    Console.WriteLine($"S = {S}");*/
                    MyTaskClass18 myTaskClass18 = new MyTaskClass18(y, t);
                    myTaskClass18.S();
                    break;

                case 19:
                    double k, r;

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение k");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение r");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*D = (Math.Pow(k, -a * r * x) - a * Math.Sqrt(6) - Math.Cos(3 * a * b))/ Math.Pow(Math.Sin(a * Math.Asin(x) + Math.Log(y)), 2);
                    Console.WriteLine($"D = {D}");*/
                    MyTaskClass19 myTaskClass19 = new MyTaskClass19(a, b, k, r, x, y);
                    myTaskClass19.D();
                    break;

                case 20:
                    
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение c");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    /*U = (Math.Pow(Math.Tan(y), 3) + Math.Pow(Math.Sin(x), 5) * Math.Sqrt(b - c)) / Math.Sqrt(a - b + c);
                    Console.WriteLine($"U = {U}");*/
                    MyTaskClass20 myTaskClass20 = new MyTaskClass20(a, b, c, x, y);
                    myTaskClass20.U();
                    break;

                case 21:
                    
                    Console.WriteLine("Введите значение z");
                    z = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    /*N = Math.Pow(z + Math.Sqrt(z * x), 1.5) / (Math.Exp(x) + Math.Pow(a, 5) * Math.Atan(x));
                    Console.WriteLine($"N = {N}");*/
                    MyTaskClass21 myTaskClass21 = new MyTaskClass21(z, x, a);
                    myTaskClass21.N();
                    break;

                case 22:

                    Console.WriteLine("Введите значение u");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*F = Math.Cos(Math.Pow(x, 2) + 2) + (3.5 * Math.Pow(x, 2) + 1) / Math.Pow(Math.Cos(y), 2);
                    Console.WriteLine($"F = {F}");*/
                    MyTaskClass22 myTaskClass22 = new MyTaskClass22(x, y);
                    myTaskClass22.F();
                    break;

                case 23:
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение z");
                    z = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    /*F = Math.Sqrt(Math.Abs(x) + Math.Pow(Math.Cos(x), 3) + Math.Pow(z, 4)) / (Math.Log(x) - Math.Asin(_b * x - a));
                    Console.WriteLine($"F = {F}");*/
                    MyTaskClass23 myTaskClass23 = new MyTaskClass23(z, b, x, a);
                    myTaskClass23.R();
                    break;

                case 24:
                    double f;

                    Console.WriteLine("Введите значение b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение z");
                    z = Convert.ToDouble(Console.ReadLine());
                    /*f = (Math.Pow(Math.Cos(_b * Math.Pow(_x, 5)), 7) - (Math.Sin(Math.Pow(_a, 2)) + Math.Cos(Math.Pow(_x, 3) + Math.Pow(_z, 5) - Math.Pow(_a, 2)))) / (Math.Asin(Math.Pow(_a, 2)) + Math.Acos(Math.Pow(_x, 7) - Math.Pow(_a, 2)));
                    Console.WriteLine($"f = {f}");*/
                    MyTaskClass24 myTaskClass24 = new MyTaskClass24(b, x, a, z);
                    myTaskClass24.F();
                    break;

                case 25:
                    double J;

                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*J = (Math.Pow(1 / Math.Tan(Math.Pow(a, 3)), 3) + Math.Pow(Math.Atan(a), 2)) / Math.Sqrt(Math.Pow(y, Math.Tan(x)));
                    Console.WriteLine($"J = {J}");*/
                    MyTaskClass25 myTaskClass25 = new MyTaskClass25(a, y, x);
                    myTaskClass25.J();
                    break;

                case 26:

                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение k");
                    k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    /*U = (Math.Log(Math.Pow(x, 3) + y) - Math.Pow(y, 4)) / (Math.Exp(y) + 5.4 * Math.Pow(k, 3));
                    Console.WriteLine($"U = {U}");*/
                    MyTaskClass26 myTaskClass26 = new MyTaskClass26(x, y, k);
                    myTaskClass26.U();
                    break;

                case 27:
                    Console.WriteLine("Введите значение a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение c");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    /*P = (Math.Pow(a, 5) + Math.Acos(a + Math.Pow(x, 3)) - Math.Pow(Math.Sin(y - c), 4)) / (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y));
                    Console.WriteLine($"P = {P}");*/
                    MyTaskClass27 myTaskClass27 = new MyTaskClass27(a, x, c, y);
                    myTaskClass27.P();
                    break;

                case 28:

                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение z");
                    z = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение c");
                    c = Convert.ToDouble(Console.ReadLine());
                    /*G = (Math.Tan(Math.Pow(x, 4) - 6) - Math.Pow(Math.Cos(z + Math.Pow(x, 3) * y), 3 * x)) / Math.Pow(Math.Cos(Math.Pow(x, 3) * Math.Pow(c, 2)), 2);
                    Console.WriteLine($"G = {G}");*/
                    MyTaskClass28 myTaskClass28 = new MyTaskClass28(x, y, z, c);
                    myTaskClass28.G();
                    break;

                case 29:

                    Console.WriteLine("Введите значение y");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение d");
                    d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*R = (Math.Pow(Math.Cos(y), 2) + 2.4 * d) / (Math.Exp(y) + Math.Log(Math.Pow(Math.Sin(x), 2) + 6));
                    Console.WriteLine($"R = {R}");*/
                    MyTaskClass29 myTaskClass29 = new MyTaskClass29(y, d, x);
                    myTaskClass29.R();
                    break;

                case 30:

                    Console.WriteLine("Введите значение x");
                    x = Convert.ToDouble(Console.ReadLine());
                    /*K = Math.Sqrt(Math.Pow(3 + x, 6) - Math.Log(x)) / (Math.Exp(0) + Math.Asin(6 * Math.Pow(x, 2)));
                    Console.WriteLine($"K = {K}");*/
                    MyTaskClass30 myTaskClass30 = new MyTaskClass30(x);
                    myTaskClass30.K();
                    break;
            }
        }
    }
}