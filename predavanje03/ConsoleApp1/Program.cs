// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);

Console.Write(1);
Console.Write(2);
Console.Write(3);

int a = 1;
int b = 2;
int c = 3;

Console.WriteLine("\nbrojevi redom (konkatenacija): " + a + " " + b + " " + c + " ");

Console.WriteLine("brojevi redom (placeholderi): {0} {1} {2}", a, b, c);

Console.WriteLine("");
int broj = 5;

Console.WriteLine(broj++);
Console.WriteLine("povecaj za jedan: " + broj);

Console.WriteLine("");
int broj2 = 5;

Console.WriteLine(broj2--);
Console.WriteLine("smanji za jedan: " + broj2);

Console.WriteLine("");
int aa = 11;
int bb = 13;

Console.WriteLine($"{aa} + {bb} = {aa + bb}");
Console.WriteLine($"{aa} - {bb} = {aa - bb}");
Console.WriteLine($"{aa} * {bb} = {aa * bb}");
Console.WriteLine($"{aa} / {bb} = {aa / bb}");


