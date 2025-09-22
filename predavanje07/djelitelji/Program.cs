using System.Data;

int broj = -1;
bool bFlag = true;
do
{
    Console.WriteLine("unesi prirodan broj: ");
    try
    {
        broj = int.Parse(Console.ReadLine());
        if(broj <= 0)
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
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("dijelitelji broja {0} su: ", broj); 

for(int i = 1; i <= broj; i++)
{
    if(broj % i == 0)
    {
        Console.WriteLine(i);
        brojac++;
    }
}
if (brojac == 2)
{
    Console.WriteLine("broj {0} je prost", broj);

}
else 
{
    Console.WriteLine("broj {0} nije prost", broj);
}
