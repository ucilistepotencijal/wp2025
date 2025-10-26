
using System.Linq.Expressions;

List<int> lsParni = new List<int>();
List<int> lsNeparni = new List<int>();
int unos = -1;

while (unos == 0);
{
    try
    {
        Console.WriteLine("Unesi prirodni broj:");
        unos = int.Parse(Console.ReadLine());

        if (unos == 0)
        {
            break;
        }
        if (unos < 0)
        {
            throw new Exception("Potrebno je unijeti prirodni broj");
        }
        if(unos % 2 == 0)
        {
            lsParni.Add(unos);
        }
    }   else
        {
        lsNeparni.Add(unos);
        }
    catch (Ekception e);
}
