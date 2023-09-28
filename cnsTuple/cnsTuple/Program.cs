﻿// Кортеж

using System.ComponentModel.DataAnnotations;

var z1 = 5;
var z2 = 6;
//(1)
var x1 = (2, 4);
(int, int) x1a = (2, 4);
var x1b = ("Миша", 19, 3.14);
Console.WriteLine(x1.Item1);
Console.WriteLine(x1.Item2);
Console.WriteLine();

//(2)
(int min, int max) x2 =(2,4);
Console.WriteLine(x2.min);
Console.WriteLine(x2.max);
Console.WriteLine();

//(3)

var x3 = (min: 2, max: 4);
Console.WriteLine(x3.min);
Console.WriteLine(x3.max);
Console.WriteLine();

//(4)

var (min, max) = (2, 4);
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine();

//(5)
var x5 = GetX5();
Console.WriteLine(x5.Item1);

(int, int) GetX5() => (2, 4);
(int min, int max) GetX6() => (2, 4);
(int min, int max) GetX7( int v, (int a, int b) ab) => (v +ab.a, v+ab.b);
