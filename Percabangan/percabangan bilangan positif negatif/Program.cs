using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int x;

      Console.Write("Masukan Bilangan : ");
      x = int.Parse(Console.ReadLine()?? "");

      if (x !=0)
      {
        if (x >0)
        {
          Console.WriteLine("Bilangan Positif");
        }
        else if (x <0)
        {
          Console.WriteLine("Bilangan Negatif");
        }
      }
      else
      {
        Console.WriteLine("Bilangan Nol");
      }
    }
  }
}