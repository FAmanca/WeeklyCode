using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string menu, pilihan;
      Console.WriteLine("Menu Kafe akuh ");
      while (true)
      {
        Console.WriteLine("1. Makanan");
        Console.WriteLine("2. Minuman");
        Console.WriteLine("3. Cemilan");
        labelPilihan:
        Console.WriteLine();
        Console.Write("Pilihan Mu : ");
        menu = Console.ReadLine() ?? ""; 
        if (menu == "1")
        {
          Console.WriteLine("Nasgor Ayam");
          Console.WriteLine("Nasgor Special");
          Console.WriteLine("Nasgor Keju");
          Console.Write("Kembali Ke Menu ? (y/n) : ");
          pilihan = Console.ReadLine() ?? "";
          if (pilihan.ToLower() == "n")
          {
            break;
          }   
        }
        else if (menu == "2")
        {
          Console.WriteLine("Teh Manis");
          Console.WriteLine("Jeruk Panas");
          Console.WriteLine("Chocolate");
          Console.Write("Kembali Ke Menu ? (y/n) : ");
          pilihan = Console.ReadLine() ?? "";
          if (pilihan.ToLower() == "n")
          {
            break;
          }   
        }
        else if (menu == "3")
        {
          Console.WriteLine("Kentang Goreng");
          Console.WriteLine("Sosis");
          Console.WriteLine("Es krim");
          Console.Write("Kembali Ke Menu ? (y/n) : ");
          pilihan = Console.ReadLine() ?? "";
          if (pilihan.ToLower() == "n")
          {
            break;
          }   
        }
        else
        {
          Console.WriteLine("menu Invalid !");
          Console.WriteLine("pilih kembali");
          goto labelPilihan;
        }
      }
    }
  }
}