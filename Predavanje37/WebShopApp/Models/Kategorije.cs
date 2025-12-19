using System;
using System.Collections.Generic;

namespace WebShopApp.Models;

public partial class Kategorije
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public string? Opis { get; set; }

    public virtual ICollection<KategorijeProizvodi> KategorijeProizvodis { get; set; } = new List<KategorijeProizvodi>();
}
