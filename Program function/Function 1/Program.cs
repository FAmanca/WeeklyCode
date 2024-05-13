using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Segitiga()
    {
      float a,t,luas;
      Console.WriteLine("Program menghitung Luas Segitiga");
      Console.WriteLine();
      Console.Write("Masukan a : ");
      a = float.Parse(Console.ReadLine()?? "");
      Console.Write("Masukan t : ");
      t = float.Parse(Console.ReadLine()?? "");

      luas = (0.5f*a*t);
      Console.WriteLine("Luas Segitiga : "+luas);
    }

    static void Persegi()
    {
      int s,luas;
      Console.WriteLine("Program menghitung Luas Persegi");
      Console.WriteLine();
      Console.Write("Masukan sisi : ");
      s = int.Parse(Console.ReadLine() ?? "");

      luas = s*s;
      Console.WriteLine("Luas persegi : " + luas);
    }

    static void Lingkaran()
    {
      float PHI = 3.14f;
      float r,luas;

      Console.WriteLine("Program menghitung luas Lingkaran");
      Console.WriteLine();

      Console.Write("Masukan jari-jari : ");
      r = float.Parse(Console.ReadLine() ?? "");

      luas = PHI*r*r;
      Console.WriteLine("Luas lingkaran : " + luas);
    }

    static void Main(string[] args)
    {
      string input;
      Console.WriteLine("+--------------------------------------------+");
      Console.WriteLine("Progream menggunakan Function");
      Console.WriteLine("Kode |                 Fungsi                ");
      Console.WriteLine("+--------------------------------------------+");
      Console.WriteLine("SG . |Untuk Menjalankan program Luas Segitiga");
      Console.WriteLine("PR . |Untuk Menjalankan program Luas Persegi");
      Console.WriteLine("LN . |Untuk Menjalankan program Luas Lingkaran");
      Console.WriteLine("EXT. |Untuk Keluar dari program");
      Console.WriteLine("+--------------------------------------------+");
      while (true)
      {

      Console.Write("Masukan Perintah Berdasarkan kode : ");
      input = Console.ReadLine()?? "";

      if (input.ToLower() == "sg")
      {
          Console.WriteLine("menghitung Luas Segitiga");
          Segitiga();
      }
      else if (input.ToLower() == "pr")
      {
          Console.WriteLine("menghitung Luas Persegi");
          Persegi();
      }
      else if (input.ToLower() == "ln")
      {
        Console.WriteLine("menghitung Luas Lingkaran");
        Lingkaran();
      }
      else if (input.ToLower() == "ext")
      {
        Console.WriteLine("keluar Dari Program");
        break;
      }
      }
    }
  }
}