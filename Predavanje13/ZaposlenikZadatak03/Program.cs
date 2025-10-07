using ZaposlenikZadatak03;

Zaposlenik z1 = new Zaposlenik
{
    Ime = "Igor",
    Prezime = "Igorić",
    OIB = "12345678901",
    BrojBodova = 2,
    VrijednostBoda = 1200,
};
Console.WriteLine("Zaposlenik 1 - Ime: {0}, Prezime: {1}, OIB: {2}, Broj bodova: {3}, Vrijednost boda: {4}", z1.Ime, 
    z1.Prezime, z1.OIB, z1.BrojBodova, z1.VrijednostBoda);
Console.WriteLine("Neto plaća: " + z1.NetoPlaca());
Console.WriteLine("Bruto plaća: " + z1.BrutoPlaca());

Zaposlenik z2 = new Zaposlenik("Ivo", "Ivić");
z2.OIB = "09874563210";
z2.BrojBodova = 3;
z2.VrijednostBoda = 1000;
Console.WriteLine("Zaposlenik 2 - Ime: {0}, Prezime: {1}, OIB: {2}, Broj bodova: {3}, Vrijednost boda: {4}", z2.Ime,
    z2.Prezime, z2.OIB, z2.BrojBodova, z2.VrijednostBoda);

Zaposlenik z3 = new Zaposlenik("Ivo", "Ivić", "87456157895");
z3.BrojBodova = 4;
z3.VrijednostBoda = 1050;
Console.WriteLine("Zaposlenik 3 - Ime: {0}, Prezime: {1}, OIB: {2}, Broj bodova: {3}, Vrijednost boda: {4}", z3.Ime,
    z3.Prezime, z3.OIB, z3.BrojBodova, z3.VrijednostBoda);




