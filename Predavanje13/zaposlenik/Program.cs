
using ZaposlenikApp;

Zaposlenik z1 = new Zaposlenik
{
    Ime = "igor",
    Prezime = "jakopicek",
    OIB = "12345678901",
    BrojBodova = 2,
    VrijednostBoda = 1000,
};
Console.WriteLine("zaposlenik 1- ime: {0}, prezime: {1}, oib: {2}, broj bodova: {3}, vrijednost boda: {4}",
    z1.Ime,z1.Prezime,z1.OIB,z1.BrojBodova,z1.VrijednostBoda);
Console.WriteLine("neto placa: "+ z1.NetoPlaca());
Console.WriteLine("neto placa: " + z1.BrutoPlaca());

Zaposlenik z2 = new Zaposlenik("ivo", "ivic");
z2.OIB = "09876543212";
z2.BrojBodova= 3;
z2.VrijednostBoda= 1000;
Console.WriteLine("zaposlenik 1- ime: {0}, prezime: {1}, oib: {2}, broj bodova: {3}, vrijednost boda: {4}",
    z2.Ime, z2.Prezime, z2.OIB, z2.BrojBodova, z2.VrijednostBoda);


Zaposlenik z3 = new Zaposlenik("ivo", "ivic", "09876543212");
Console.WriteLine("zaposlenik 1- ime: {0}, prezime: {1}, oib: {2}, broj bodova: {3}, vrijednost boda: {4}",
    z3.Ime, z3.Prezime, z3.OIB, z3.BrojBodova, z3.VrijednostBoda);
z3.BrojBodova = 4;
z3.VrijednostBoda = 1000;