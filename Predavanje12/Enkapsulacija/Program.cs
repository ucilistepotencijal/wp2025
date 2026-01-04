using Enkapsulacija;

try
{
	Proizvod p = new Proizvod();
	Console.Write("Unesi naziv proizvoda: ");
	p.Naziv = Console.ReadLine();
	Console.Write("Unesi cijenu: ");
	p.Cijena = double.Parse(Console.ReadLine());
	Console.Write("Unesi maržu: ");
	p.Marza = double.Parse(Console.ReadLine());
	Console.Write("Unesi porez: ");
	p.Porez = double.Parse(Console.ReadLine());
}
catch (FormatException fe)
{
	Console.WriteLine("Greška! Unos je upisan u krivom formatu. Detalji: " + fe.Message);
}
catch (Exception e)
{
	Console.WriteLine("Greška! Dogodio se exception. Detalji: " + e.Message);
}
finally
{
	Console.WriteLine("Program je završio!");
}


