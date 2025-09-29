/* Napiši program koji će u funkciji na temelju unesene prosječne ocjene ispisaƟ poruku o
uspjehu.
Primjer: Za unesenu prosječnu ocjenu 3,4 program ispisuje „Prosjek je dobar“. */

using System.Collections;

Console.Write("Unesi prosječnu ocjenu: ");
double ocjena = double.Parse(Console.ReadLine());

Console.WriteLine("Uspjeh je {0}.", Prosjek(ocjena));

partial class Program
{
    static string Prosjek(double prosjek)
    {
        if (prosjek >= 4.5)
        {
            return "odličan";
        }
        else if (prosjek >= 3.5)
        {
            return "vrlo dobar";
        }
        else if (prosjek >= 2.5)
        {
            return "dobar";

        }
        else if (prosjek >= 1.5)
        {
            return "dovoljan";
        }
        else
        {
            return "nedovoljan";       
        }
    }
}