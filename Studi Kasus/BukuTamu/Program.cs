using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string nama,email,komentar;
      Console.WriteLine("Buku Tamu");
      Console.Write("Nama : ");
      nama = Console.ReadLine()?? "";
      Console.Write("Email : ");
      email = Console.ReadLine()?? "";
      Console.Write("Komentar : ");
      komentar = Console.ReadLine()?? "";

      Console.WriteLine($"Terimakasih {nama} dengan {email} atas komentarnya");
    }
  }
}