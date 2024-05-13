using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      float beli,disc,total;

      Console.Write("Masukan Pembelian : ");
      beli = float.Parse(Console.ReadLine()?? "");

      if (beli >=100000)
      {
        disc=0.1f*beli;
        total=beli-disc;
      }
      else
      {
        disc=0.5f*beli;
        total=beli*disc;
      }
      Console.WriteLine("Pembelian : "+beli);
      Console.WriteLine("Diskon : "+disc);
      Console.WriteLine("Total Pembayaran : "+total);
    }
  }
}