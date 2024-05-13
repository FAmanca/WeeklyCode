using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Menampilkan Angka Genap");
      for (int i = 2; i <= 10; i++)
      {
        Console.Write(i);
        i++;
      }
      Console.WriteLine(" ");
    }
  }
}