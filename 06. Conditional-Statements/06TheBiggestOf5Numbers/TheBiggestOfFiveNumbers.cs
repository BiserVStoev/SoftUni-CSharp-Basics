﻿using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        if (a > b && b == c && c < d && d > e)
        {
            Console.WriteLine(a);
        }
        else if (a > b && a < c && c > d && d == e)
        {
            Console.WriteLine(c);
        }
        else if (b > a && b > c && c > d && d > e)
        {
            Console.WriteLine(b);
        }
        else if (a > b && a == c && c < d && d == e)
        {
            Console.WriteLine(d);
        }
        else if (a < b && e > c && c > d && d < e)
        {
            Console.WriteLine(e);
        }
    }
}
