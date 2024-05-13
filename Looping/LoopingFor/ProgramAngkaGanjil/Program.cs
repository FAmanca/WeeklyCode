using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Menampilkan Angka Ganjil");
      for (int i = 1; i < 10; i++)
      {
        Console.Write(i);
        i++;
      }
      Console.WriteLine(" ");
    }
  }
}