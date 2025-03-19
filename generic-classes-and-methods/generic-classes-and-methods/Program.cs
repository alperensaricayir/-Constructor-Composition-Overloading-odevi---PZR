using System;

public class Kutu<T>  // Generic sınıf
{
    private T veri;

    public void Ata(T deger)
    {
        veri = deger;
    }

    public T Getir()
    {
        return veri;
    }
}

class Program
{
    static void Main()
    {
        Kutu<int> intKutu = new Kutu<int>();  // Generic sınıf kullanımı
        intKutu.Ata(10);
        Console.WriteLine(intKutu.Getir());  // Çıktı: 10

        Kutu<string> stringKutu = new Kutu<string>();
        stringKutu.Ata("Merhaba Dünya");
        Console.WriteLine(stringKutu.Getir());  // Çıktı: Merhaba Dünya
    }
}
//using System.Diagnostics.Metrics;
//using System;

//**Generic Class’lar ve Generic Method’lar (Boxing & Unboxing)**

//**1. Generic Yapılar Nedir?**
//Generic yapılar, C#’ta farklı veri tipleriyle çalışabilen esnek ve tekrar kullanılabilir kodlar yazmayı sağlayan bir özelliktir. **Generic sınıflar ve metodlar**, belirli bir veri tipine bağlı kalmadan farklı veri türlerini işleyebilir.

//**2. Generic Sınıflar (Generic Classes)**
//Generic sınıflar, veri tipi belirtilmeden tanımlanır ve kullanılacak veri tipi çağrıldığında belirlenir.
//Örnek:
//```csharp
//class Kutu<T>  // T: Tür parametresi
//{
//    private T veri;
//    public void Ata(T deger) { veri = deger; }
//    public T Getir() { return veri; }
//}

//// Kullanımı
//Kutu<int> intKutu = new Kutu<int>();
//intKutu.Ata(10);
//Console.WriteLine(intKutu.Getir());  // Çıktı: 10
//```

//**3.Generic Metotlar(Generic Methods) * *
//Generic metotlar, metodun çağrıldığı anda veri tipi belirlenerek çalışır.
//```csharp
//class Islemler
//{
//    public static void Yazdir<T>(T deger)
//    {
//        Console.WriteLine(deger);
//    }
//}

//// Kullanımı
//Islemler.Yazdir(100);   // Çıktı: 100
//Islemler.Yazdir("Merhaba"); // Çıktı: Merhaba
//```

//**4.Boxing & Unboxing Nedir?**
//Boxing ve Unboxing, değer türleri (int, double) ile referans türleri (object) arasındaki dönüşümleri ifade eder.
//- **Boxing:**Değer tipinin object türüne dönüştürülmesidir.
//```csharp
//int sayi = 42;
//object kutu = sayi; // Boxing
//```
//-**Unboxing:**Object türündeki verinin tekrar değer türüne dönüştürülmesidir.
//```csharp
//object obj = 42;
//int geriAlinanSayi = (int)obj; // Unboxing
//```
//**Performans Etkisi: **
//-Boxing ve Unboxing işlemleri ek bellek ve işlem yükü oluşturur.
//- **Generic kullanımı**, Boxing & Unboxing işlemlerini önleyerek daha hızlı ve verimli bir kod yazılmasını sağlar.

//**Sonuç**
//Generic yapılar, C#’ta daha esnek ve performanslı kod yazmayı sağlar. Boxing & Unboxing işlemlerinden kaçınarak belleği daha verimli kullanmak mümkündür.

