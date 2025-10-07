
using enkaps;



try
{
	Proizvod p = new Proizvod();
	Console.WriteLine("unesi naziv proizvoda ");
	p.Naziv = Console.ReadLine();
	
	Console.Write("unesi cijenu: ");
	p.cijena = double.Parse(Console.ReadLine());
	
	Console.Write("unesi marzu: ");
	p.marza =  double.Parse(Console.ReadLine());
	
	Console.Write("unesi porez: ");
	p.Porez =  double.Parse(Console.ReadLine());
}
catch (FormatException fe)
{

    Console.WriteLine("greska, krivi format: "+ fe.Message);
}
catch (Exception e)
{

    Console.WriteLine("greska, dogodila se ex: " + e.Message);
}
finally
{
    Console.WriteLine("program je zavrsio");
}

