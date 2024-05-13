using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int bil;

      Console.Write("masukan bilangan : ");
      bil = int.Parse(Console.ReadLine()?? "");

      switch (bil)
      {
          case 1 :
            Console.WriteLine("Anda Memasukan Bilangan satu");
            break;

        case 2:
          Console.WriteLine("Anda Memasukan Bilangan dua");
          break;

        case 3:
          Console.WriteLine("Anda Memasukan Bilangan tiga");
          break;

        default:
          Console.WriteLine("Anda memasukan Bilangan selain 1, 2, dan 3");
          break;
      }
    }
  }
}