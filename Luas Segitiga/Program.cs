using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung Luas Segitiga");
            Console.WriteLine("");
            //input
            int alas, tinggi, luas;
            Console.Write("Masukan alas : ");
            alas = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Masukan Tinggi : ");
            tinggi = int.Parse(Console.ReadLine() ?? "");

            //proses hitung
            luas = (alas*tinggi/2);

            //output
            Console.WriteLine("Luas Segitiga hasilnya : "+luas);
        }
    }
}