using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int Jumlahlembar;
      string pilihan, disc;
      float hargaLembar = 250f;
      float diskon, totalBayar, total;
      Console.WriteLine("fotocopy Program");
      Console.Write("Apakah Anda Termasuk Anggota ? (y/n) : ");
      pilihan = Console.ReadLine() ?? "";
      if (pilihan.ToLower() == "y")
      {
        Console.Write("Masukan jumlah lembar : ");
        Jumlahlembar = int.Parse(Console.ReadLine() ?? "");
        total = hargaLembar * Jumlahlembar;
        if (Jumlahlembar > 300)
        {
          diskon = total * 0.2f;
          disc = "20%";
          struk();
        }
        else if (Jumlahlembar > 100)
        {
          diskon = total * 0.1f;
          disc = "10%";
          struk();
        }
        else
        {
          diskon = 0;
          disc = "Tidak mendapatkan diskon";
          struk();
        }
      }
      else if (pilihan.ToLower() == "n")
      {
        Console.Write("Masukan jumlah lembar : ");
        Jumlahlembar = int.Parse(Console.ReadLine() ?? "");
        total = hargaLembar * Jumlahlembar;
        if (Jumlahlembar > 300)
        {
          diskon = total * 0.02f;
          disc = "2%";
          struk();
        }
        else if (Jumlahlembar > 100)
        {
          diskon = total * 0.01f;
          disc = "1%";
          struk();
        }
        else
        {
          diskon = 0;
          disc = "Tidak mendapatkan diskon";
          struk();
        }
      }
      void struk()
      {
        totalBayar = total - diskon;
        Console.WriteLine("+==========================================================+");
        Console.WriteLine("                          FOTOCOPY                          ");
        Console.WriteLine("+==========================================================+");
        Console.WriteLine($"Harga Per Lembar                : Rp.{hargaLembar}");
        Console.WriteLine($"Total                           : Rp.{total}");
        Console.WriteLine($"Mendapat Diskon                 : {disc}");
        Console.WriteLine($"Total Diskon Sebanyak           : Rp.{diskon}");
        Console.WriteLine($"Total yang harus dibayar adalah : Rp.{totalBayar}");
        Console.WriteLine("+==========================================================+");
        Console.WriteLine("                        TERIMA KASIH                        ");
        Console.WriteLine("+==========================================================+");
      }
    }
  }
}