


/*
Zadatak 1: Napravi program koji traži unos teksta, a zatim ispisuje taj tekst
„naopako”. 
 Npr. za uneseni tekst „Danas je lijep dan” treba ispisati „nad pejil ej sanaD”
*/


using System;

public class Program
{
    static void Main()
    {
        Console.Write("Unesite tekst: ");
        string unos = Console.ReadLine();

        string naopako = new string(unos.Reverse().ToArray());

        Console.WriteLine("Naopako tekst: " + naopako);
    }
}
