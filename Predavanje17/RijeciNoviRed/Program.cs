//4. Napiši program koji traži unos rečenice i zatim ispisuje svaku riječ iz rečenice u novi red.

Console.Write("Unesi rečenicu: ");
string recenica = Console.ReadLine();

recenica = recenica.Replace("!", "").Replace(".", "").Replace(",", "").Trim().ToLower();
Console.WriteLine(recenica.Replace(" ", "\n"));