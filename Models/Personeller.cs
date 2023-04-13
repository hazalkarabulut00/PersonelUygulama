using System;
using System.Collections.Generic;

namespace PersonelUygulama.Models;

public partial class Personeller
{
    public int PersonelId { get; set; }

    public string AdSoyad { get; set; } = null!;

    public DateTime DogumTarihi { get; set; }

    public DateTime IseBaslamaTarihi { get; set; }

    public decimal Maas { get; set; }

    public string Departman { get; set; } = null!;
}
