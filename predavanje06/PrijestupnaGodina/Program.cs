
Console.Write("Unesite godinu: ");
int godina = int.Parse(Console.ReadLine());

if ((godina % 4 == 0 && godina % 100 != 0) || godina % 400 == 0)
{
    Console.WriteLine("Godina je prijestupna.");
}
else
{
    Console.WriteLine("Godina nije prijestupna.");
}
