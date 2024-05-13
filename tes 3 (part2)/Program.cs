using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int angka = 1024;

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(angka);
        angka = angka / 2;
      }
    }
  }
}