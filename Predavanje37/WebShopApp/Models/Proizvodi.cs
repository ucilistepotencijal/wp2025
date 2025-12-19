using System;
using System.Collections.Generic;

namespace WebShopApp.Models;

public partial class Proizvodi
{
    public int Id { get; set; }

    public int? MjereProizvodaId { get; set; }

    public DateTime? VrijemeKreiranja { get; set; }

    public string Naziv { get; set; } = null!;

    public decimal Cijena { get; set; }

    public bool Dostupan { get; set; }

    public virtual ICollection<KategorijeProizvodi> KategorijeProizvodis { get; set; } = new List<KategorijeProizvodi>();

    public virtual MjereProizvodum? MjereProizvoda { get; set; }

    public virtual ICollection<NarudzbeDetalji> NarudzbeDetaljis { get; set; } = new List<NarudzbeDetalji>();
}
