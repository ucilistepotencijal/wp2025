

/*Napravi program koji za upisani tekstualni naziv mjeseca ispisuje njegov
redni broj. Za krivo upisani naziv mjeseca, ispisuje se da taj mjesec ne postoji.*/

    
 Console.Write("Nazivi mjeseca: ");
 string Nazivi = Console.ReadLine();

if (Nazivi == "sijecanj")
{
    Console.WriteLine("Broj mjeseca po redu  je 1.", Nazivi);
}
else if (Nazivi == "veljaca")
{
    Console.WriteLine("Broj mjeseca po redu  je 2.", Nazivi);
}
else if (Nazivi == "ozujak")
{
    Console.WriteLine("Broj mjeseca po redu je 3. ", Nazivi);
}
else if (Nazivi == "travanj")
{
    Console.WriteLine("Broj mjeseca po redu  je 4. ", Nazivi);
}
else if (Nazivi == "svibanj")
{
    Console.WriteLine("Broj mjeseca po redu  je 5. ", Nazivi);
}
else if (Nazivi == "lipanj")
{
    Console.WriteLine("Broj mjeseca po redu  je 6. ", Nazivi);
}
else if (Nazivi == "srpanj")
{
    Console.WriteLine("Broj mjeseca po redu  je 7. ", Nazivi);
}
else if (Nazivi == "kolovoz")
{
    Console.WriteLine("Broj mjeseca po redu  je 8. ", Nazivi);
}
else if (Nazivi == "rujan")
{
    Console.WriteLine("Broj mjeseca po redu  je 9. ", Nazivi);
}
else if (Nazivi == "listopad")
{
    Console.WriteLine("Broj mjeseca po redu  je 10. ", Nazivi);
}
else if (Nazivi == "studeni")
{
    Console.WriteLine("Broj mjeseca po redu  je 11. ", Nazivi);
}
else if (Nazivi == "prosinac")
{
    Console.WriteLine("Broj mjeseca po redu  je 12. ", Nazivi);
}
else 
{
    Console.WriteLine("Mjesec ne postoji");
}








