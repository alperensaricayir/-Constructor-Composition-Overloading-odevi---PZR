using System;

// Kapı sınıfı
class Kapi
{
    public int KapıSayisi { get; }
    public Kapi(int kapıSayisi)
    {
        KapıSayisi = kapıSayisi;
    }
}

// Pencere sınıfı
class Pencere
{
    public int PencereSayisi { get; }
    public Pencere(int pencereSayisi)
    {
        PencereSayisi = pencereSayisi;
    }
}

// Kasa sınıfı
class Kasa
{
    public string KasaTipi { get; }
    public Kasa(string kasaTipi)
    {
        KasaTipi = kasaTipi;
    }
}

// Marka sınıfı
class Marka
{
    public string MarkaAdi { get; }
    public string Model { get; }
    public Marka(string markaAdi, string model)
    {
        MarkaAdi = markaAdi;
        Model = model;
    }
}

// Araba sınıfı (Composition kullanılıyor)
class Araba
{
    public Marka MarkaBilgisi { get; }
    public Kapi KapiBilgisi { get; }
    public Pencere PencereBilgisi { get; }
    public Kasa KasaBilgisi { get; }
    public double Fiyat { get; }

    public Araba(Marka marka, Kapi kapi, Pencere pencere, Kasa kasa, double fiyat)
    {
        MarkaBilgisi = marka;
        KapiBilgisi = kapi;
        PencereBilgisi = pencere;
        KasaBilgisi = kasa;
        Fiyat = fiyat;
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Arabanın markası {MarkaBilgisi.MarkaAdi}, modeli {MarkaBilgisi.Model}, kapı sayısı {KapiBilgisi.KapıSayisi}, pencere sayısı {PencereBilgisi.PencereSayisi}, kasası {KasaBilgisi.KasaTipi}, fiyatı {Fiyat:N0} TL’dir.");
    }
}

// Program sınıfı
class Program
{
    static void Main()
    {
        // BMW X5 nesnesi oluşturuluyor
        Marka bmw = new Marka("BMW", "X5");
        Kapi kapi = new Kapi(4);
        Pencere pencere = new Pencere(4);
        Kasa kasa = new Kasa("Sedan");
        double fiyat = 2000000;

        Araba bmwX5 = new Araba(bmw, kapi, pencere, kasa, fiyat);
        bmwX5.BilgileriYazdir();
    }
}