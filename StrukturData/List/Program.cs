using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<string> fruits = new List<string>();
      fruits.Add("apel");
      fruits.Add("jeruk");
      fruits.Add("pisang");
      fruits.Add("strawberry");
      fruits.Add("alpukat");
      fruits.Add("lengkeng");
      fruits.Add("pir");
      fruits.Sort();

      foreach (var fruit in fruits)
      {
        Console.WriteLine(fruit);
      }

      Console.Write("Cek buah : ");
      string cek = Console.ReadLine() ?? "";

      if (fruits.Contains(cek))
      {
        Console.WriteLine("Barang ADA");
      }
      else
      {
        Console.WriteLine("Barang Tidak Ada");
      }
    }
  }
}

