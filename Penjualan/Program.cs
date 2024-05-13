using System;

namespace Penjualan
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double penjualan, j, k, b; 
          b=0;
          k=0;
          j=0;
          Console.Write("Masukan Penjualan : "); 
          penjualan=double.Parse(Console.ReadLine() ?? "");
          if (penjualan>0)
          {
            if (penjualan>500000)
            {
              k=(0.2*penjualan);
              j=30000;
              b=k+j;
            }
            else if (penjualan>200000 && penjualan==500000)
            {
              k=(0.15*penjualan);
              j=20000;
              b=k+j;
            }
            else if (penjualan==200000)
            {
              k=(0.1*penjualan);
              j=10000;
              b=k+j;
            }
            else
            {
              Console.WriteLine("tidak mendapatkan bonus");
            }
            //Console.WriteLine("Anda mendapatkan komisi penjualan sebesar : "+k);
            //Console.WriteLine("Anda Mendapatkan uang jasa sebesar : "+j);
            Console.WriteLine("mendapatkan total bonus dari penjualan sebesar : "+b);
          }
          else
          {
            Console.WriteLine("ANGKA TIDAK BOLEH NEGATIF !!!");
          }
        }
    }
}