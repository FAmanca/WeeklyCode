using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung nilai A");
            Console.WriteLine("");

            int a, b, c;
            Console.Write("Masukan b : ");
            b = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Masukan c : ");
            c = int.Parse(Console.ReadLine() ?? "");

            a=(b+c);

            Console.WriteLine("Nilai A adalah : "+a);
        }
    }
}