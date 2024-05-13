using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i <3; i++)
      {
        for (int j = 1; j <=3; j++)
        {
          Console.Write(j);
        }
        Console.Write(" ");
      }
    }
  }
}