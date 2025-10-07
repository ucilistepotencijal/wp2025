using GDPR;

List<Student> studenti = new List<Student>();

while (true)
{
	Student s = new Student();
	Console.Write("Unesi ime studenta (ili kraj za prekid unosa): ");
	s.Ime = Console.ReadLine();
	studenti.Add(s);

	if (s.Ime.ToLower() == "kraj") break;

	Console.Write("Unesi prezime studenta: ");
	s.Prezime = Console.ReadLine();

	Console.Write("Unesi godinu rođenja (bez točke na kraju): ");
	s.GodinaRodenja = int.Parse(Console.ReadLine());

	Console.Write("Unesi mjesto rodenja: ");
	s.MjestoRodenja = Console.ReadLine();

	Console.Write("Unesi OIB: ");
	s.OIB = Console.ReadLine();

    Console.WriteLine("--------------- Popis studenata -------------");
	foreach (Student x in studenti)
	{
        Console.WriteLine($"Inicijali: {s.Inicijali}");
        Console.WriteLine($"Starost: {s.Starost()} godina");
        Console.WriteLine($"OIB je {(s.ProvjeriOIB() ? "ispravan" : "neispravan")}");
        Console.WriteLine("\n");
    }
}
