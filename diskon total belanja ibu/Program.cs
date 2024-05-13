using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double total, totalakhir, diskon;
          Console.WriteLine("Diskon Kasir");
          Console.Write("Masukan Harga Total belanja : ");
          total=double.Parse(Console.ReadLine() ?? "");

          if(total>=150000)
          {
            Console.WriteLine("Selamat anda mendapatkan diskon sebesar 5%");
            diskon=(total*0.05);
            totalakhir=(total-diskon);
            Console.WriteLine("Diskon belanjaan : "+diskon);
            Console.WriteLine("Total akhir pembayaran : "+totalakhir);
          }
          else
          {
            Console.WriteLine("Anda tidak mendapatkan diskon");
            totalakhir=total;
            Console.WriteLine("Total akhir pembayaran : "+totalakhir);
          }
        }
    }
}