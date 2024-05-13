using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int jam, menit, detik, todetik;

          Console.WriteLine("Konversi jam menit detik ke detik");

          Console.Write("Masukan Jam : ");
          jam=int.Parse(Console.ReadLine() ?? "");

          Console.Write("Masukan menit : ");
          menit=int.Parse(Console.ReadLine() ?? "");

          Console.Write("Masukan detik : ");
          detik=int.Parse(Console.ReadLine() ?? "");

          todetik=((jam*3600)+(menit*60)+detik);

          Console.WriteLine("Total detik adalah : "+todetik+" detik");
        }
    }
}