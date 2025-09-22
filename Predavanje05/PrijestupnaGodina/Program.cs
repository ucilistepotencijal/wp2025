

Console.Write("Unesi godinu: ");
int godina = int.Parse(Console.ReadLine());
//                    *                    +  
if (godina % 4 == 0 && godina % 100 != 0 || godina % 400 == 0)
{
    Console.WriteLine("Godina " + godina + " je prijestupna");
}
else
{
    Console.WriteLine("Godina " + godina + " nije prijestupna");
}

// 2. način
if (DateTime.IsLeapYear(godina))
{
    Console.WriteLine("Godina je prijestupna!");
}
else
{
    Console.WriteLine("Godina nije prijestupna");
}