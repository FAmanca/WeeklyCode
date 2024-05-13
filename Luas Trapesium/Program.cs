using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      float a,b,t,luas;
      Console.WriteLine("Program Menghitung Luas Trapesium");

      Console.Write("masukan nilai a : ");
      a = float.Parse(Console.ReadLine() ?? "");

      Console.Write("masukan nilai b : ");
      b = float.Parse(Console.ReadLine() ?? "");

      Console.Write("masukan nilai t : ");
      t = float.Parse(Console.ReadLine() ?? "");

      luas = (0.5f *(a+b)*t);
      Console.WriteLine("Luas Trapesium adalah : "+luas+" cm2");
    }
  }
}