using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          while (true)
          {
            int n;
            Console.Write("Masukan Nomor : ");
            n = int.Parse(Console.ReadLine() ?? "");
            if (n==23)
            {
              Console.WriteLine("Akses diterima ");
              break;
            }
            else
            {
              Console.Clear();
              Console.WriteLine("Akses Ditolak ");
              Console.WriteLine("Masukan nomor ulang ");
            }
          }
        }
    }
}