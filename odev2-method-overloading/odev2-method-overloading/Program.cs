using System;

// Matematik işlemleri için sınıf
class Matematik
{
    // İki sayıyı toplayan metot (int)
    public int Topla(int a, int b)
    {
        return a + b;
    }

    // Üç sayıyı toplayan metot (int)
    public int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    // İki sayıyı toplayan metot (double)
    public double Topla(double a, double b)
    {
        return a + b;
    }

    // Üç sayıyı toplayan metot (double)
    public double Topla(double a, double b, double c)
    {
        return a + b + c;
    }

    // İki sayıyı çarpan metot (int)
    public int Carp(int a, int b)
    {
        return a * b;
    }

    // Üç sayıyı çarpan metot (int)
    public int Carp(int a, int b, int c)
    {
        return a * b * c;
    }

    // İki sayıyı çarpan metot (double)
    public double Carp(double a, double b)
    {
        return a * b;
    }

    // Üç sayıyı çarpan metot (double)
    public double Carp(double a, double b, double c)
    {
        return a * b * c;
    }
}

// Program sınıfı
class Program
{
    static void Main()
    {
        Matematik mat = new Matematik();

        Console.WriteLine("Toplamalar:");
        Console.WriteLine(mat.Topla(3, 5)); // int, 2 parametre
        Console.WriteLine(mat.Topla(3, 5, 7)); // int, 3 parametre
        Console.WriteLine(mat.Topla(3.5, 2.5)); // double, 2 parametre
        Console.WriteLine(mat.Topla(1.1, 2.2, 3.3)); // double, 3 parametre

        Console.WriteLine("\nÇarpmalar:");
        Console.WriteLine(mat.Carp(3, 5)); // int, 2 parametre
        Console.WriteLine(mat.Carp(3, 5, 7)); // int, 3 parametre
        Console.WriteLine(mat.Carp(3.5, 2.5)); // double, 2 parametre
        Console.WriteLine(mat.Carp(1.1, 2.2, 3.3)); // double, 3 parametre
    }
}