

using GDPR;
using System.Xml;

List<Student> studenti = new List<Student>();
do
{
    try
    {
        Student student = new Student();
        Console.Write("Ime (unesi 'kraj' za kraj unosa) : ");
        student.Ime = Console.ReadLine();
        if (student.Ime.ToLower() == "kraj")
        {
            break;
        }
        Console.Write("Prezime: ");
        student.Prezime = Console.ReadLine();
        Console.Write("Godina rođenja: ");
        student.GodinaRodenja = int.Parse(Console.ReadLine());
        Console.Write("Mjesto studiranja: ");
        student.MjestoStudiranja = Console.ReadLine();
        Console.Write("OIB: ");
        student.OIB = Console.ReadLine();
        studenti.Add(student);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Dogodila se greška pri unosu! Detalji: {e.Message}");
    }
    finally
    {
        Console.WriteLine("----------------------------------------");
    }
} while (true);

foreach (Student student in studenti)
{
    Console.WriteLine($"Inicijali: {student.Inicijali()}");
    Console.WriteLine($"Starost: {student.Starost()}");
    Console.WriteLine(student.ProvjeriOIB() ? "OIB je ispravan!" : "OIB nije ispravan!");
    Console.WriteLine("------------------------------");
}

foreach (Student student in studenti)
{
    if (student.Starost() > 24 && student.MjestoStudiranja.ToLower() == "osijek")
    {
        Console.WriteLine($"Student {student.Ime} {student.Prezime} iz Osijeka je star {student.Starost()} g.");
    }
}