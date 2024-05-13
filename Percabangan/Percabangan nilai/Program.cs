using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int nilai;
      Console.Write("masukan nilai");
      nilai = int.Parse(Console.ReadLine() ?? "");

      if (nilai>70)
      {
        Console.WriteLine("Lulus");
      }
      else
      {
        Console.WriteLine("Tidak Lulus");
      }
    }
  }
}