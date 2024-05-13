using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Looping TEXT NESTED_LOOP");
      Console.WriteLine("");
      int i, j;
      i = 0;
      while (i < 5)
      {
        j = 1;
        while (j <= 3)
        {
          Console.Write("NESTED-LOOP  ");
          j++;
        }
        Console.WriteLine(" ");
        i++;
      }

    }
  }
}