using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Looping angka 12345");
      int i;
      i=1;
      while (i<6)
      {
        Console.Write(i); 
        i++;
      }
    }
  }
}