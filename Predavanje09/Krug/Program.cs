/* 1. Napiši program u kojem se za uneseni polumjer r ispisuje opseg i površina kruga.
O=2∗r∗π , P = r2π */

using System.Collections;

while (true)
{
    try
    {
        Console.Write("Unesi polumjer r: ");
        double r = double.Parse(Console.ReadLine());

        if (r == 0)
        {
            Console.WriteLine("Polumjer ne može biti 0!");
            continue;
        }

        OpsegKruga(r);
        PovrsinaKruga(r);

    }

    catch (System.Exception)
    {
        Console.WriteLine("Dogodila se greška, ponovno unesi polumjer: ");
    }
}
        partial class Program
{
    static void OpsegKruga(double r)
    {
        Console.WriteLine("\nOpseg kruga polumjera {0} je {1}", r, (2 * r * Math.PI));
    }


    static void PovrsinaKruga(double r)
    {
        Console.WriteLine("Povrsina kruga polumjera {0} je {1}", r, (r * r) * Math.PI);
    }
}
    
          
     

