using System;

namespace Rolercoaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int t;
          Console.WriteLine("Wahana Rolecoaster");
          Console.WriteLine("Ket : Jika tinggi lebih dari 150 boleh naik");

          Console.Write("Masukan Tinggi : ");
          t=int.Parse(Console.ReadLine() ?? "");

          if (t>150)
          {
            Console.WriteLine("Dibolehkan menaiki wahana");
          }
          else
          {
            Console.WriteLine("Tidak Dibolehkan Naik wahana");
          }
        }
    }
}
