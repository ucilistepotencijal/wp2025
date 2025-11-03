using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> brojevi = new List<int>();
        int broj;

        // Unos brojeva
        Console.WriteLine("Unesi brojeve (0 za kraj unosa):");
        do
        {
            Console.Write("Unesi broj: ");
            broj = int.Parse(Console.ReadLine());
            if (broj != 0)
                brojevi.Add(broj);
        } while (broj != 0);

        char opcija;

        do
        {
            Console.WriteLine("\nOdaberi opciju:");
            Console.WriteLine("a) Brojevi iz intervala [1,11]");
            Console.WriteLine("b) Brojevi i njihovi kvadrati (kvadrat > 20)");
            Console.WriteLine("c) Brojevi i njihova frekvencija");
            Console.WriteLine("d) Brojevi veći od 80");
            Console.WriteLine("e) Tri najveća broja");
            Console.WriteLine("x) Izlaz");

            Console.Write("Tvoj izbor: ");
            opcija = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (opcija)
            {
                case 'a':
                    var interval = from b in brojevi
                                   where b >= 1 && b <= 11
                                   select b;

                    Console.WriteLine("Brojevi iz intervala [1,11]:");
                    Console.WriteLine(string.Join(", ", interval));
                    break;

                case 'b':
                    var kvadrati = from b in brojevi
                                   let kvadrat = b * b
                                   where kvadrat > 20
                                   select new { Broj = b, Kvadrat = kvadrat };

                    Console.WriteLine("Brojevi i njihovi kvadrati (kvadrat > 20):");
                    foreach (var x2 in kvadrati)
                        Console.WriteLine($"{x2.Broj} -> {x2.Kvadrat}");
                    break;

                case 'c':
                    var frekvencije = from b in brojevi
                                      group b by b into g
                                      select new { Broj = g.Key, Ponavljanja = g.Count() };

                    Console.WriteLine("Brojevi i njihova frekvencija:");
                    foreach (var f in frekvencije)
                        Console.WriteLine($"{f.Broj} se pojavljuje {f.Ponavljanja} puta");
                    break;

                case 'd':
                    var veciOd80 = from b in brojevi
                                   where b > 80
                                   select b;

                    Console.WriteLine("Brojevi veći od 80:");
                    Console.WriteLine(string.Join(", ", veciOd80));
                    break;

                case 'e':
                    var triNajveca = brojevi.OrderByDescending(b => b).Take(3);

                    Console.WriteLine("Tri najveća broja:");
                    Console.WriteLine(string.Join(", ", triNajveca));
                    break;

                case 'x':
                    Console.WriteLine("Kraj programa.");
                    break;

                default:
                    Console.WriteLine("Nepoznata opcija. Pokušaj ponovo.");
                    break;
            }

        } while (opcija != 'x');
    }
}
