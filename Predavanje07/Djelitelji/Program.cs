/*Napiši program u kojem se za uneseni prirodni broj ispisuju svi njegovi djelitelji. Ako je broj
djeljiv samo sa 1 i sa samim sobom (ima ukupno 2 djelitelja), ispisuje se dodatna poruka „Broj
je prost“, inače se ispisuje „Broj nije prost“ . 
*/

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
        
        Console.WriteLine("Neispravan unos!");
       

         bFlag = false;
    }
    
} while (!bFlag); // ili: bFlag == false



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
    Console.WriteLine("Broj {0} je prost. ",  iBroj);
}
else
{
    Console.WriteLine("Broj {0} nije prost. ", iBroj);

}