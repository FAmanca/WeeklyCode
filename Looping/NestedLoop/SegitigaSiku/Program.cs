using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("SegigaSiku");
      int n = 5;
      for (int i = 1; i <= n; i += 2)
      {
        for (int j = 1; j <= (n - i) / 2; j++)
        {
          Console.Write(" ");
        }
        for (int j = 1; j <= i; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }
  }
}