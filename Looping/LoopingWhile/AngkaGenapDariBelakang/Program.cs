using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Menampilkan angka Genap Dari Belakang");
      int i;
      i=12;
      while (i>0)
      {
        Console.Write(i+" ");
        i--;
        i--;
      }
    }
  }
}