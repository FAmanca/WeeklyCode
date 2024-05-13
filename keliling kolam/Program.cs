using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Keliling Kolam");
            Console.WriteLine("");

            int p, l, k;
            
            Console.Write("Masukan Panjang Kolam : ");
            p = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Masukan Lebar kolam : ");
            l = int.Parse(Console.ReadLine() ?? "");

            k=((p*2)+(l*2));
            Console.WriteLine("Keliling Kolam Adalah : "+k);
        }
    }
}