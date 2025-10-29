//Napravi program koji za upisani tekstualni naziv mjeseca ispisuje njegov
//redni broj. Za krivo upisani naziv mjeseca, ispisuje se da taj mjesec ne postoji.
//2 boda

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Upiši naziv mjeseca: ");
string naziv = Console.ReadLine();

switch (naziv.ToLower())
{
	case "siječanj":
        Console.WriteLine("1. mjesec");
		break;
    case "veljača":
        Console.WriteLine("2. mjesec");
        break;
    case "ožujak":
        Console.WriteLine("3. mjesec");
        break;
    case "travanj":
        Console.WriteLine("4. mjesec");
        break;
    case "svibanj":
        Console.WriteLine("5. mjesec");
        break;
    case "lipanj":
        Console.WriteLine("6. mjesec");
        break;
    case "srpanj":
        Console.WriteLine("7. mjesec");
        break;
    case "kolovoz":
        Console.WriteLine("8. mjesec");
        break;
    case "rujan":
        Console.WriteLine("9. mjesec");
        break;
    case "listopad":
        Console.WriteLine("10. mjesec");
        break;
    case "studeni":
        Console.WriteLine("11. mjesec");
        break;
    case "prosinac":
        Console.WriteLine("12. mjesec");
        break;
    default:
        Console.WriteLine("Upisani mjesec ne postoji!");
		break;
}
