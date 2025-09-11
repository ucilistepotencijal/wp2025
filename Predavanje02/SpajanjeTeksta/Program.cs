Console.OutputEncoding = System.Text.Encoding.UTF8;

string ime = "Pero";
string prezime = "Perić";
string grad = "Osijek";


//1. Konkatenacija (spajanje) pomoću + operatora
Console.WriteLine(ime + " " + prezime);

//2. Placeholders (mjesta za zamjenu) 
Console.WriteLine("{0} {1} {2}", ime, prezime, grad);


string punoIme = string.Format("{0} {1} {2}", ime, prezime, grad);
Console.WriteLine(punoIme);




