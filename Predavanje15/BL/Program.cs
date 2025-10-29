using DAL;

Console.WriteLine();
Student student = new Student();
student.Ime = "Marko";
student.Prezime = "Marković";
student.Matematika = 5;
student.Fizika = 4;
student.Kemija = 4;
Console.WriteLine("Prosjek: " + Math.Round(student.VratiProsjek(), 2));

List<Osoba> osobe = OsobeRepo.DohvatiOsobe();

foreach (Osoba o in osobe)
{
    Console.WriteLine("Ime: {0}, Prezime: {1}", o.Ime, o.Prezime);
}