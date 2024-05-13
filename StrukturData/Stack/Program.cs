using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Stack games = new Stack() {};

      while (true)
      {
        Console.WriteLine("Tambah Stack game");
        Console.Write("Masukan Game : ");
        string ins = Console.ReadLine()?? "";
        Console.WriteLine();
        games.Push(ins);
        foreach (var game in games)
        {
          Console.WriteLine(game);
        }
        Console.WriteLine();
      }
    }
  }
}