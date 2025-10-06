using KlaseObjekti;

//Instanca klase osoba
Osoba osoba = new Osoba(); //Od onog nacrta smo dobili jedinku - jednu osobu. Npr kad se spajamo na bazu podataka, vadimo podatke od jednoj osobi.
osoba.Ime = "Pero";
osoba.Prezime = "Perić";

string punoIme = osoba.VratiPunoIme(); //Console.Writeline pozivamo direktno na klasi. 
// Poziv metode se radi s točkom. Get i set se isto rade s točkom (pridruživanje svojstava je to).

Console.WriteLine("Puno ime osobe je " + punoIme);

Osoba osoba2 = new Osoba(); 
Console.Write("Unesi ime: ");
osoba2.Ime = Console.ReadLine();

Console.Write("Unesi prezime: ");
osoba2.Prezime = Console.ReadLine();

Console.WriteLine("Puno ime je {0}", osoba2.VratiPunoIme()); //metoda mora imati zagrade. Trenutno su prazne.

Osoba osoba3 = new Osoba
{
    Ime = "Josip",
    Prezime = "Josipović"
};

Console.WriteLine(osoba3.VratiPunoIme());

