using System;
using System.Collections.Generic;

namespace WebShopApp.Models;

public partial class Korisnici
{
    public int Id { get; set; }

    public string Ime { get; set; } = null!;

    public string Prezime { get; set; } = null!;

    public string? Email { get; set; }

    public string? AdresaDostave { get; set; }

    public string? Kontakt { get; set; }

    public string? Napomena { get; set; }

    public virtual ICollection<Narudzbe> Narudzbes { get; set; } = new List<Narudzbe>();
}
