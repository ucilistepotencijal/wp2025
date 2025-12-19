using System;
using System.Collections.Generic;

namespace WebShopApp.Models;

public partial class NarudzbeDetalji
{
    public int Id { get; set; }

    public int? NarudzbaId { get; set; }

    public int? ProizvodId { get; set; }

    public int Kolicina { get; set; }

    public decimal JedCijena { get; set; }

    public virtual Narudzbe? Narudzba { get; set; }

    public virtual Proizvodi? Proizvod { get; set; }
}
