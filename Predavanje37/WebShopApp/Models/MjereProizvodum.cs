using System;
using System.Collections.Generic;

namespace WebShopApp.Models;

public partial class MjereProizvodum
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public virtual ICollection<Proizvodi> Proizvodis { get; set; } = new List<Proizvodi>();
}
