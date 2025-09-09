Console.OutputEncoding = System.Text.Encoding.UTF8;
string ime = "Pero";
string prezime = "Perić";

//1. Konkatenacija (spajanje) pomoću + operatora
Console.WriteLine(ime + " " + prezime);

//2. Placeholderi (mjesta za zamjenu) - koristi se indeks varijable
Console.WriteLine( "{0} {1}", ime, prezime);

string punoIme = string.Format("{0} {1}", ime, prezime);
Console.WriteLine(punoIme);