using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int x = 1;
      int a = 1024;
      for (int i = 5; i >1 ; i--)
      {
        for (int n = 1; n < i; n++)
        {
          Console.Write(" ");
        }
        for (int t = 0; t < x; t++)
        {
          Console.Write($" {a}");
          a = a/2;
        }
        x++;
        Console.WriteLine();
      }
    }
  }
}