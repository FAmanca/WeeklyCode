using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung Luas Persegi");
            Console.WriteLine("");

            //input
            int panjang, lebar, luas;
            Console.Write("Masukan Panjang : ");
            panjang = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Masukan Lebar : ");
            lebar= int.Parse(Console.ReadLine() ?? "");

            //proses hitung
            luas = (panjang*lebar);

            //output
            Console.WriteLine("Luas Persegi hasilnya : "+luas);
        }
    }
}