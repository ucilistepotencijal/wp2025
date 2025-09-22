
Console.Write("Upiši bilo koju godinu: ");
int year = int.Parse(Console.ReadLine());

if (year % 4 == 0 && year % 100 != 0)
{
    Console.WriteLine("Godina {0} je prijestupna!", year);
}
else if (year % 400 == 0)
{
    Console.WriteLine("Godina {0} je prijestupna!", year);
}
else
{
    Console.WriteLine("Godina {0} nije prijestupna!", year);
}


// drugi način

if (DateTime.IsLeapYear(year))
{
    Console.WriteLine("Godina je prijestupna");
}
else
{
    Console.WriteLine("Godina nije prijestupna");
}