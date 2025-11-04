using Interfejsi3;
using System.Collections;

Osoba o1 = new Osoba();
o1.Ime = "Ivo";

Osoba o2 = o1;
o2.Ime = "Ana";

//objekti se prosljeđju po referenci: o2=o1 pokazuje na istu memorijsku lokaciju
Console.WriteLine(o1.Ime);
Console.WriteLine(o2.Ime);

//možemo ispitati jesu li objekti jednaki po refernci
Console.WriteLine(object.ReferenceEquals(o1, o2));

Console.WriteLine("---------------------------------------");

o1.Ime = "Ivo";
Osoba o3 = (Osoba)o1.Clone();
o3.Ime = "Ana";
Console.WriteLine(o1.Ime);
Console.WriteLine(o3.Ime);

Console.WriteLine(object.ReferenceEquals(o1, o3));

//svojstvo Partner
o1.Partner = o3;
Console.WriteLine(o1.Ime + ", partner: " + o1.Partner.Ime);

o3.Partner = o1;    
Console.WriteLine(o3.Ime + ", partner: " + o3.Partner.Ime);

Console.WriteLine(object.ReferenceEquals(o3, o1.Partner));


IDisposable dis = o1;
dis.Dispose();

if (o1.Partner != null) Console.WriteLine(o1.Partner.Ime);

//primjer korištenja vlastitiog interfejsa
ArrayList lista = new ArrayList();

Osoba osoba = new Osoba();
osoba.Ime = "Ana";
osoba.Prezime = "Anić";

Zivotinja zivotinja = new Zivotinja();
zivotinja.NarodniNaziv = "Divlja svinja";
zivotinja.LatinskiNaziv = "Sus scrofa";

lista.Add(zivotinja);
lista.Add(osoba);

Console.WriteLine("--------------------------------");
foreach (IMojInterface item in lista)
{
    Console.WriteLine(item.PunoIme());
}

