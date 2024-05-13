using System;

namespace Penjualan
{
  internal class Program
  {
    static void Main(string[] args)
    {
      float X,Y,P=0,Q;
      Console.WriteLine("Percabangan p=x+y");

      Console.Write("Masukan X : ");
      X = float.Parse(Console.ReadLine() ?? "");

      Console.Write("Masukan Y : ");
      Y = float.Parse(Console.ReadLine() ?? "");
      
      P = X + Y;
      if (P >= 75)
      {
        Q = X * Y;
      }
      Q = X /Y;
      Console.WriteLine("Nilai Q Adalah : "+Q);
    }
  }
}