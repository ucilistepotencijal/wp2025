/* Napravi program koji za upisani tekstualni naziv mjeseca ispisuje njegov
redni broj. Za krivo upisani naziv mjeseca, ispisuje se da taj mjesec ne postoji.*/

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Upiši naziv mjeseca: ");
string naziv = Console.ReadLine();



    if (naziv.ToLower() == "siječanj")
    {
       Console.WriteLine("Redni broj mjeseca {0} je 1.", naziv);
    }
    else if (naziv.ToLower() == "veljača")
    {
       Console.WriteLine("Redni broj mjeseca {0} je 2.", naziv);
    }
    else if (naziv.ToLower() == "ožujak")
    {
       Console.WriteLine("Redni broj mjeseca {0} je 3.", naziv);
    }
    else if (naziv.ToLower() == "travanj")
    {
       Console.WriteLine("Redni broj mjeseca {0} je 4.", naziv);
    }
    else if (naziv.ToLower() == "svibanj")
    {
       Console.WriteLine("Redni broj mjeseca {0} je 5.", naziv);
    }
    else if (naziv.ToLower() == "lipanj")
    {
       Console.WriteLine("Redni broj mjeseca {0} je 6.", naziv);
    }
    else if (naziv.ToLower() == "srpanj")
    {
       Console.WriteLine("Redni broj mjeseca {0} je 7.", naziv);
    }
    else if (naziv.ToLower() == "kolovoz")
    {
        Console.WriteLine("Redni broj mjeseca {0} je 8.", naziv);
    }
    else if (naziv.ToLower() == "rujan")
    {
        Console.WriteLine("Redni broj mjeseca {0} je 9.", naziv);
    }
    else if (naziv.ToLower() == "listopad")
    {
        Console.WriteLine("Redni broj mjeseca {0} je 10.", naziv);
    }
    else if (naziv.ToLower() == "studeni")
    {
        Console.WriteLine("Redni broj mjeseca {0} je 11.", naziv);
    }
    else if (naziv.ToLower() == "prosinac")
    {
         Console.WriteLine("Redni broj mjeseca {0} je 12.", naziv);
    }
    else
    {
        Console.WriteLine("Upisani mjesec ne postoji!");
    }

















