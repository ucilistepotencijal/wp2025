/* 3.UnosRijeci
Napiši program koji traži unos riječi sve dok se ne unese „kraj” a zatim prema odabiru korisnika (npr. prema upisanom slovu) izvršava jednu od dolje navedenih metoda. U programu je potrebno
korisniku omogućiti odabir funkcije sve dok ne odabere opciju za kraj, npr. slovo x.
a) Rijeci koje počinju i završavaju određenim slovima
Kreira LINQ upit koji sadrži sve riječi koje počinju i završavaju određenim slovima i ispisuje ih na konzolu.
b) Niz stringova konverƟra u jedan
Kreira LINQ upit koji sadrži jedan string sa svim upisanim stringovima odvojenim zarezima i ispisuje ih na konzolu.
c) Stringovi minimalne duljine
Kreira LINQ upit koji sadrži stringove upisane minimalne duljine i ispisuje ih na konzolu.
d) Poredaj stringove po duljini pa po imenu
Kreira LINQ upit koji sadrži stringove poredane po duljini uzlazno a zatim po imenu i ispisuje ih na konzolu.
e) Poredaj jedinstvene stringove po abecedi
Kreira LINQ upit koji sadrži jednistvene stringove poredane po abecedi i ispisuje ih na konzolu. */

List<string> rijeci = new List<string>();
string unos = "";

while (true)
{
    Console.Write("Unesite riječ ('kraj' za kraj): ");

    unos = Console.ReadLine();
    if (unos.ToLower() == "kraj")
    {
        break;
    }
    else
    {
        rijeci.Add(unos);
    }
}
while (true)
{
    Console.Clear();
    Console.WriteLine("Odaberi jednu od opcija: ");
    Console.WriteLine("a) Riječi koje počinju i završavaju određenim slovima");
    Console.WriteLine("b) Niz stringova konvertira u jedan");
    Console.WriteLine("c) Stringovi minimalne duljine");
    Console.WriteLine("d) Poredaj stringove po duljini pa po imenu");
    Console.WriteLine("e) Poredaj jedinstvene stringove po abecedi");
    Console.WriteLine("x) Kraj");
    Console.Write("Vaš odabir: ");
    string opcija = Console.ReadLine();
 

}