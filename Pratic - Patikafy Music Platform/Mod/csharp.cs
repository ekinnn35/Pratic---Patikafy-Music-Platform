using System;
using System.Collections.Generic;
using System.Linq;

class Sanatci
{
    public string Ad { get; set; }
    public string MuzikTuru { get; set; }
    public int CikisYili { get; set; }
    public int AlbumSatisi { get; set; }
}

class Program
{
    static void Main()
    {
        List<Sanatci> sanatcilar = new List<Sanatci>
        {
            new Sanatci { Ad = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968, AlbumSatisi = 20 },
            new Sanatci { Ad = "Sezen Aksu", MuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatisi = 10 },
            new Sanatci { Ad = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatisi = 3 },
            new Sanatci { Ad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatisi = 5 },
            new Sanatci { Ad = "Sıla", MuzikTuru = "Pop", CikisYili = 2009, AlbumSatisi = 3 },
            new Sanatci { Ad = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbumSatisi = 10 },
            new Sanatci { Ad = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatisi = 40 },
            new Sanatci { Ad = "Hande Yener", MuzikTuru = "Pop", CikisYili = 1999, AlbumSatisi = 7 },
            new Sanatci { Ad = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbumSatisi = 5 },
            new Sanatci { Ad = "Gülben Ergen", MuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatisi = 10 },
            new Sanatci { Ad = "Neşet Ertaş", MuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatisi = 2 }
        };

        var sIleBaslayanlar = sanatcilar.Where(s => s.Ad.StartsWith("S"));
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        foreach (var s in sIleBaslayanlar)
        {
            Console.WriteLine(s.Ad);
        }
    }
}
