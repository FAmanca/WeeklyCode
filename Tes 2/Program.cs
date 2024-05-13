using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Tes 2 (Program Total bayar)");
      float pembelian, total, diskon;

      Console.Write("Masukan Total Pembayaran : ");
      pembelian = float.Parse(Console.ReadLine()?? "");

      if (pembelian >= 1000000) {
        Console.WriteLine("Mendapat Diskon 10% !");
        diskon = pembelian * 0.1f;
        total = pembelian - diskon;
      }

      else {
        Console.WriteLine("Mendapat Diskon 5% !");
        diskon = pembelian * 0.05f;
        total = pembelian - diskon;
      }

      Console.WriteLine($"Total Pembayaran : {total}");
    }
  }
}