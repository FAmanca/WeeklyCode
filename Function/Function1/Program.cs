using System;

namespace Function1 // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    
    static void Main(string[] args)
    {
      float HitungLuasSegitiga(float alas, float tinggi)
      {
        return 0.5f * alas * tinggi;
      }

      void DisplayLuas(float alas, float tinggi)
      {
        float Luas = HitungLuasSegitiga(alas, tinggi);
        Console.WriteLine($"Luas Segitiga Adalah : {Luas}");
        return;
      }

      Console.Write("Masukan Alas : ");
      float alas = float.Parse(Console.ReadLine() ?? "");

      Console.Write("Masukan Tinggi : ");
      float tinggi = float.Parse(Console.ReadLine() ?? "");

      DisplayLuas(alas, tinggi);    
    }
  }
}