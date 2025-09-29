/* 7. Prilagodi prethodni program Djelitelji.cs tako da se ispisuje je li broj savršen ili nije. Savršen
broj je jednak broju koji je jednak zbroju svojih djelitelja (uključujući broj 1 ali ne i njega
samog) */

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

} while (bFlag == false); // ili: !bFlaf


int brojac = 0;
Console.WriteLine("Djelitelji broja {0} su: ", iBroj);

for (int i = 1; i < iBroj; i++)
{
    if (iBroj % i == 0)
    {
        Console.WriteLine(i);
        brojac += i;
    }
}

if (brojac == iBroj)
{
    Console.WriteLine("Broj {0} je savršen broj.", iBroj);
}
else
{
    Console.WriteLine("Broj {0} nije savršen broj.", iBroj);
}