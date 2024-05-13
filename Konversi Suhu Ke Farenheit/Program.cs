using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celsius Ke Farenheit");
            Console.WriteLine("");

            int c, f;
            
            Console.Write("Masukan Suhu Celsius : ");
            c = int.Parse(Console.ReadLine() ?? "");

            f=((c*9/5)+32);
            Console.WriteLine("Suhu Farenheit adalah : "+f);
        }
    }
}