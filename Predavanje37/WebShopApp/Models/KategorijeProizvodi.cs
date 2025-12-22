using System;
using System.Collections.Generic;

namespace WebShopApp.Models;

public partial class KategorijeProizvodi
{
    public int Id { get; set; }

    public int? Proizvod { get; set; }

    public int? KategorijaId { get; set; }

    public virtual Kategorije? Kategorija { get; set; }

    public virtual Proizvodi? ProizvodNavigation { get; set; }
}
