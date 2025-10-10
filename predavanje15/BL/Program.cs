using System;
using DAL;

Console.WriteLine();
Student student = new Student();
student.Ime = "Marko";
student.Prezime = "Marković";
student.Mat = 5;
student.Fiz = 4;
student.Kem = 4;

Console.WriteLine("Prosjek: " + Math.Round(student.VratiProsjek(), 2));

List<Osoba>osoba = OsobeRepo.dohvatiOsobe();

foreach(Osoba o in osoba)
{
    Console.WriteLine("ime: {0}, prezime; {1}", o.Ime, o.Prezime);
}
