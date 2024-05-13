using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Looping angka 12345");
      for (int i = 1; i < 6; i++)
      {
        Console.Write(i);
        Console.Write(" ");
      }
    }
  }
}
