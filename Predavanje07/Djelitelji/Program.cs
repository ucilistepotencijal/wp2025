
int iBroj = -1;
bool bFlag = true;
do
{
    Console.Write("Unesi prirodan broj: ");

    try
    {
        iBroj = int.Parse(Console.ReadLine());
        if (iBroj <= 0)
        {
            throw new Exception();
        }
        bFlag = true;
    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Neispravan unos!");
        Console.ForegroundColor = ConsoleColor.Gray;
        bFlag = false;
    }
    
} while (!bFlag);


int brojac = 0;

Console.WriteLine("Djelitelji broja {0} su: ", iBroj);

for (int i = 1; i <= iBroj; i++)
{
    if (iBroj % i == 0)
    {
        Console.WriteLine(i);
        brojac++;
    }
}

if (brojac == 2)
{
    Console.WriteLine("Broj {0} je prost!", iBroj);
}
else
{
    Console.WriteLine("Broj {0} nije prost!", iBroj);
}