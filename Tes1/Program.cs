using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double A,B,C;
      double X;
      Console.WriteLine("Tes 1 (cari X)");

      Console.Write("Masukan A : ");
      A = double.Parse(Console.ReadLine()?? "");
      Console.Write("Masukan B : ");
      B = double.Parse(Console.ReadLine()?? "");
      Console.Write("Masukan C : ");
      C = double.Parse(Console.ReadLine()?? "");

      //* Proses
      X = Math.Pow(A,2) + B * Math.Pow(C,3);

      //* Output
      Console.WriteLine($"X = {X}");
    }
  }
}