// See https://aka.ms/new-console-template for more information


using Exercise3;
using System.Globalization;

Prism p1 = new(6, 4, 5, 6);

Console.WriteLine(p1.GetNumOfSides());

Trapezoid t1 = new(4,3, 7, 4, 6, 4);
Console.WriteLine(t1.Area());
Console.WriteLine(t1.Perimeter());
Console.WriteLine();

Triangle triangle = new(3, 3, 5, 7, 4);
Console.WriteLine(triangle.Perimeter());
Console.WriteLine(triangle.Area());