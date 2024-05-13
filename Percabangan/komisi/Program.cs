using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      float pendapatan, jasa=0, komisi=0, total=0;

      Console.Write("Masukan Pendapatan Hari Ini : ");
      pendapatan = float.Parse(Console.ReadLine()?? "");
      
      if (pendapatan >= 0)
      {
        if (pendapatan >= 500000)
        {
          jasa = 30000;
          komisi = 0.2f*pendapatan;
        }
        else if (pendapatan >200000 && pendapatan <500000)
        {
          jasa = 20000;
          komisi = 0.15f*pendapatan;
        }
        else
        {
          jasa = 10000;
          komisi = 0.1f*pendapatan;
        }
        //* Menghitung total
        total = komisi+jasa;
        Console.WriteLine("Uang Jasa : Rp."+jasa);
        Console.WriteLine("Uang Jasa : Rp."+komisi);
        Console.WriteLine("==================================");
        Console.WriteLine("Hasil Total : Rp."+total);
      }
      else
      {
        Console.WriteLine("Angka tidak boleh negatif");
      }
    }
  }
}