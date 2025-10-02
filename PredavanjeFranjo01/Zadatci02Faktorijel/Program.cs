


Console.Write("Unesi x faktorijel: ");
double x = double.Parse(Console.ReadLine());
double faktorijel = 1;
for (int i = 1; i <= x; i++)
{
    faktorijel *= i;
}

Console.WriteLine("Faktorijel broja {0} je {1}", x, faktorijel);