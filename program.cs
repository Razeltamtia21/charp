using System;

public class program
{
    public static void Run()
    {
        Console.Write("Masukkan nama: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan usia: ");
        int usia = int.Parse(Console.ReadLine());

        string kategori;
        if (usia < 7)
        {
            kategori = "Anak-anak";
        }
        else if (usia >= 7 && usia < 13)
        {
            kategori = "Remaja awal";
        }
        else if (usia >= 13 && usia < 18)
        {
            kategori = "Remaja";
        }
        else if (usia >= 18 && usia < 60)
        {
            kategori = "Dewasa";
        }
        else
        {
            kategori = "Lansia";
        }

        Console.WriteLine($"\nNama: {nama}");
        Console.WriteLine($"Usia: {usia} tahun");
        Console.WriteLine($"Kategori: {kategori}");
    }
}
