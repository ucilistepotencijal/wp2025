/* Zadatak 1: Napravi program koji traži unos teksta, a zatim ispisuje taj tekst
„naopako”.
 Npr. za uneseni tekst „Danas je lijep dan” treba ispisati „nad pejil ej sanaD” */

string recenica = "";
while(recenica.Length < 1)
{
	Console.Write("Unesi rečenicu: ");
	recenica = Console.ReadLine().Trim('.', ',', '?', '!');
	if (recenica.Length == 0)
	{
		Console.WriteLine("Unos ne smije biti prazan. Molimo ponovite unos.");
		recenica = "";
	}
}

string recenica1 = new string (recenica.Reverse().ToArray());
foreach (char c in recenica1)
{
    Console.Write(c);
}