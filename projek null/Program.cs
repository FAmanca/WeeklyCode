using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menghitung banyak");
            int a, b, c, d, e, f, g, h, j;
            Console.WriteLine("Masukan b : ");
            b= int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Masukan c : ");
            c= int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Masukan e : ");
            e= int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Masukan f : ");
            f= int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Masukan h : ");
            h= int.Parse(Console.ReadLine() ?? "");;

            //proses            
            a=b+c;
            d=e*f;
            g=h/4;
            j=a+d+g;
            //output
            Console.WriteLine("Nilai j adalah : "+j);
        }
    }
}
