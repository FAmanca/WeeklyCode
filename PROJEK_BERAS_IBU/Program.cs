using System;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROJEK BERAS IBU");
            Console.WriteLine("============================");
            Console.WriteLine("            Pasar           ");
            Console.WriteLine("============================");
            Console.WriteLine("Harga Gula/kg       : 16000");
            Console.WriteLine("Harga Tepung/kg     : 15000");
            Console.WriteLine("Harga Beras/karung  : 305000");
            Console.WriteLine("============================");
            Console.WriteLine("");

            int g, t, b, to;
            
            Console.Write("Masukan Jumlah KG Gula : ");
            g = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Masukan Jumlah KG Tepung : ");
            t = int.Parse(Console.ReadLine() ?? "");
            Console.Write("Masukan Jumlah Karung Beras : ");
            b = int.Parse(Console.ReadLine() ?? "");

            to=((g*16000)+(t*15000)+(b*305000));
            Console.WriteLine("Total Belanja Adalah : Rp."+to);
            Console.Write("Masukan Jumlah Uang");
        }
    }
}