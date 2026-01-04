using System;
using System.Collections.Generic;

namespace WebShopApp.Models;

public partial class Narudzbe
{
    public int Id { get; set; }

    public int? KorisnikId { get; set; }

    public DateTime? DatumKreiranja { get; set; }

    public DateTime? DatumVrijemeDostave { get; set; }

    public bool? JeDostavljeno { get; set; }

    public virtual Korisnici? Korisnik { get; set; }

    public virtual ICollection<NarudzbeDetalji> NarudzbeDetaljis { get; set; } = new List<NarudzbeDetalji>();
}
